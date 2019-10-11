﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace JocysCom.TextToSpeech.Monitor.Audio
{
	[Serializable, StructLayout(LayoutKind.Sequential)]
	public class KeyValue : KeyValue<string>
	{
		public KeyValue() { }

		public KeyValue(string key, string value) : base(key, value) { }
	}

	[Serializable, StructLayout(LayoutKind.Sequential)]
	public class KeyValue<T> : INotifyPropertyChanged
	{

		public KeyValue()
		{
		}

		public KeyValue(T key, T value)
		{
			_key = key;
			_value = value;
		}

		T _key;
		T _value;
		public T Key
		{
			get { return _key; }
			set
			{
				if (!Equals(_key, value))
				{
					_key = value;
					OnPropertyChanged();
				}
			}
		}
		public T Value
		{
			get { return _value; }
			set
			{
				if (!Equals(_value, value))
				{
					_value = value;
					OnPropertyChanged();
				}
			}
		}

		public override string ToString()
		{
			return string.Format("[{0},{1}]", Key, Value);
		}

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler == null)
				return;
			handler(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion

	}
}
