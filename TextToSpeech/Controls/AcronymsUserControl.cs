﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocysCom.TextToSpeech.Monitor.Controls
{
	public partial class AcronymsUserControl : UserControl
	{
		public AcronymsUserControl()
		{
			InitializeComponent();

		}

		private void SettingsControl_Load(object sender, EventArgs e)
		{
			var list = SettingsManager.Current.Acronyms;
			SettingsControl.DataGridView.DataSource = SettingsManager.Current.Acronyms.Items;
		}
	}
}
