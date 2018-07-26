﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using static System.Environment;

namespace JocysCom.ClassLibrary.Controls.IssuesControl
{
	public class IssueHelper
	{

		class SearchArg
		{
			public SearchArg(RegistryKey key, string path, string productKeyName, string uninstallKeyName1 = null, string uninstallKeyName2 = null)
			{
				Key = key;
				Path = path;
				ProductKeyName = productKeyName;
				UninstallKeyName1 = uninstallKeyName1;
				UninstallKeyName2 = uninstallKeyName2;
			}
			public RegistryKey Key;
			public string Path;
			public string ProductKeyName;
			public string UninstallKeyName1;
			public string UninstallKeyName2;
		}

		/// <summary>
		/// Use registry because "SELECT Name, Caption FROM Win32_Product" management query object is super slow.
		/// </summary>
		/// <returns></returns>
		public static bool IsInstalled(string name, bool uninstall = false)
		{
			var args = new List<SearchArg>();
			args.Add(new SearchArg(Registry.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName", "UninstallPath", "UninstallString"));
			args.Add(new SearchArg(Registry.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName", "UninstallPath", "UninstallString"));
			// Add support for 32-bit installers.
			if (Environment.Is64BitOperatingSystem)
			{
				args.Add(new SearchArg(Registry.CurrentUser, @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName", "UninstallPath", "UninstallString"));
				args.Add(new SearchArg(Registry.LocalMachine, @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName", "UninstallPath", "UninstallString"));
			}
			args.Add(new SearchArg(Registry.LocalMachine, @"SOFTWARE\Classes\Installer\Products", "ProductName"));
			foreach (var arg in args)
			{
				using (var key = arg.Key.OpenSubKey(arg.Path))
				{
					if (key == null)
						continue;
					foreach (string subkey_name in key.GetSubKeyNames())
					{
						using (var subKey = key.OpenSubKey(subkey_name))
						{
							if (subKey == null)
								continue;
							var displayName = (string)subKey.GetValue(arg.ProductKeyName, "");
							// If product found then...
							if (displayName.ToUpper().Contains(name.ToUpper()))
							{
								if (uninstall)
								{
									string uninstallCommand = null;
									if (!string.IsNullOrEmpty(arg.UninstallKeyName1))
										uninstallCommand = (string)subKey.GetValue(arg.UninstallKeyName1, "");
									// If uninstall command was not found then try other key.
									if (!string.IsNullOrEmpty(arg.UninstallKeyName2) && string.IsNullOrEmpty(uninstallCommand))
										uninstallCommand = (string)subKey.GetValue(arg.UninstallKeyName2, "");
									// If uninstall command was found then...
									if (!string.IsNullOrEmpty(uninstallCommand))
									{
										// Get first space.
										var splitIndex = uninstallCommand.StartsWith("\"")
											// Split from second quote.
											? uninstallCommand.IndexOf('\"', 1)
											// Split from first space.
											: uninstallCommand.IndexOf(' ');
										var upath = uninstallCommand.Substring(0, splitIndex);
										var uargs = uninstallCommand.Substring(splitIndex);
										OpenPath(upath, uargs);
									}
								}
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Get real version of windows because Environment.OSVersion.Version
		/// returns older version unless allowed by application manifest.
		/// </summary>
		public static Version GetRealOSVersion()
		{
			if (OSVersion == null)
			{
				OSVersion = GetFileVersion(SpecialFolder.System, "kernel32.dll");
			}
			return OSVersion;
		}

		public static Version GetFileVersion(SpecialFolder folder, string name)
		{
			if (OSVersion == null)
			{
				var system = Environment.GetFolderPath(folder);
				var file = Path.Combine(system, name);
				var vi = FileVersionInfo.GetVersionInfo(file);
				var version = new Version(vi.ProductMajorPart, vi.ProductMinorPart, vi.ProductBuildPart, vi.FilePrivatePart);
				OSVersion = version;
			}
			return OSVersion;
		}


		static Version OSVersion;


		public static bool IsInstalled2(string name, bool uninstall = false)
		{
			var scope = new ManagementScope(@"\\.\root\cimv2");
			scope.Connect();
			// https://msdn.microsoft.com/en-us/library/aa394378(v=vs.85).aspx
			var query = new ObjectQuery("SELECT * FROM Win32_Product");
			var searcher = new ManagementObjectSearcher(scope, query);
			var results = searcher.Get();
			foreach (ManagementObject result in results)
			{
				foreach (PropertyData p in result.Properties)
				{
					Console.WriteLine("{0}: {1}", p.Name, p.Value);
					var found = (p.Name == "Name" || p.Name == "Caption") && string.Format("{0}", p.Value).Contains(name);
					if (found)
					{
						if (uninstall)
						{
							// The Win32_Product class has these methods:
							//
							// Admin - Performs an administrative install of an associated Win32_Product instance using the installation package provided through PackageLocation, and any command line options that are supplied.
							// Advertise - Advertises an associated Win32_Product instance using the installation package provided through PackageLocation and any command line options that are supplied.
							// Configure - Configures the associated instance of Win32_Product to the specified install state and level.
							// Install - Installs an associated Win32_Product instance using the installation package provided through PackageLocation and any command line options that are supplied.
							// Reinstall - Reinstalls the associated instance of Win32_Product using the specified reinstallation mode.
							// Uninstall - Uninstalls the associated instance of Win32_Product.
							// Upgrade - Upgrades the associated Win32_Product instance using the upgrade package provided through PackageLocation and any command line options that are supplied.
							//
							// 0 - Successful completion, 2147549445 - 	RPC Server Fault Error.
							var returnValue = (UInt32)result.InvokeMethod("Uninstall", null);
							if (returnValue == 0)
							{
								MessageBox.Show("Successfully uninstalled");
							}
							else
							{
								// Try to run as an administrator.
								var ex = new Win32Exception(unchecked((int)returnValue));
								MessageBox.Show(ex.Message);
							}
						}
						break;
					}
				}
			}
			results.Dispose();
			searcher.Dispose();
			return false;
		}

		public static bool IsInstalledHotFix(int id)
		{
			string query = string.Format("SELECT HotFixID FROM Win32_QuickFixEngineering", id);
			var searcher = new ManagementObjectSearcher(query);
			var collection = searcher.Get();
			var list = new List<string>();
			foreach (ManagementObject quickFix in collection)
				list.Add(quickFix["HotFixID"].ToString());
			var installed = list.Contains("KB" + id.ToString());
			//MessageBox.Show(string.Join(", ", list.OrderBy(x => x)));
			searcher.Dispose();
			return installed;
		}

		public static void OpenPath(string path, string arguments = null)
		{
			try
			{
				var fi = new FileInfo(path);
				//if (!fi.Exists) return;
				// Brings up the "Windows cannot open this file" dialog if association not found.
				var psi = new ProcessStartInfo(path);
				psi.UseShellExecute = true;
				psi.WorkingDirectory = fi.Directory.FullName;
				psi.ErrorDialog = true;
				if (arguments != null) psi.Arguments = arguments;
				Process.Start(psi);
			}
			catch (Exception) { }
		}

		public static void HoldWhileRunning(string processName, string argumentFilter = null)
		{
			var semaphore = new SemaphoreSlim(0);
			var timer = new System.Timers.Timer();
			timer.AutoReset = false;
			timer.Interval = 5000;
			timer.Elapsed += delegate (object sender, System.Timers.ElapsedEventArgs e)
			{
				var release = false;
				try
				{
					var items = Process.GetProcessesByName(processName);
					if (string.IsNullOrEmpty(argumentFilter))
					{
						if (items.Length == 0)
							release = true;
					}
					else
					{
						var found = false;
						foreach (Process item in items)
						{
							if (item.StartInfo.Arguments.ToLower().Contains(argumentFilter.ToLower()))
								found = true;
						}
						if (!found)
							release = true;
					}
				}
				catch (Exception)
				{
					release = true;
				}
				if (release)
				{
					// Unlock EventArgsSemaphore.Wait() line.
					semaphore.Release();
				}
				else
				{
					timer.Start();
				}
			};
			timer.Start();
			// Wait here until all items returns to the pool.
			semaphore.Wait();
			timer.Dispose();
		}

	}
}
