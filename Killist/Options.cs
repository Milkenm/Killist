﻿using System;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Killist.Properties;

namespace Killist
{
	public partial class Options : Form
	{
		private Thread _killThread;
		private int _timer;
		private bool _isEnabled = true;

		public Options()
		{
			InitializeComponent();

			this.LoadSettings();

			this.toolStripMenuItem_enabled.Checked = this._isEnabled;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this._killThread = new Thread(async () =>
			{
				while (true)
				{
					await Task.Delay(1);

					if (this._isEnabled && this.listBox_processes.Items.Count > 0)
					{
						this._timer++;

						Debug.WriteLine(this._timer + " / " + (this._timer / 1000));

						if ((this._timer / 1000) >= Settings.Default.SecondsDelay)
						{
							this._timer = 0;

							this.KillerThread();
						}
					}
				}
			});
			this._killThread.Start();
		}

		private void Main_Shown(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void KillerThread()
		{
			Process[] processes = Process.GetProcesses();

			foreach (string processName in listBox_processes.Items)
			{
				// Check if the process exists
				Process process = processes.Where(p => p.ProcessName == processName).FirstOrDefault();
				// Kill the process if it exists
				try
				{
					process?.Kill();
				}
				catch { }
			}
		}

		private void LoadSettings()
		{
			this.listBox_processes.Items.Clear();

			if (Settings.Default.ProcessesList == null)
			{
				Settings.Default.ProcessesList = new StringCollection();
			}

			foreach (string processName in Settings.Default.ProcessesList)
			{
				this.listBox_processes.Items.Add(processName);
			}

			this.numeric_delay.Value = Settings.Default.SecondsDelay;
		}

		private void SaveSettings()
		{
			if (Settings.Default.SecondsDelay != this.numeric_delay.Value)
			{
				this._timer = 0;
			}

			Settings.Default.ProcessesList.Clear();
			foreach (string processName in this.listBox_processes.Items)
			{
				Settings.Default.ProcessesList.Add(processName);
			}

			Settings.Default.SecondsDelay = (int)this.numeric_delay.Value;

			Settings.Default.Save();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			// Trim user input
			string newProcess = this.textBox_process.Text.Trim();
			// Check if string is null
			if (string.IsNullOrEmpty(newProcess))
			{
				return;
			}

			// Add process to the list
			this.listBox_processes.Items.Add(newProcess);

			// Save
			this.SaveSettings();
		}

		private void button_remove_Click(object sender, EventArgs e)
		{
			// Check if there is any element selected
			if (this.listBox_processes.SelectedIndex == -1)
			{
				return;
			}

			// Remove the process
			this.listBox_processes.Items.RemoveAt(this.listBox_processes.SelectedIndex);

			// Save
			this.SaveSettings();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;

			this.Hide();
		}

		private void toolStripMenuItem_settings_Click(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void toolStripMenuItem_enabled_Click(object sender, EventArgs e)
		{
			this._isEnabled = !this.toolStripMenuItem_enabled.Checked;

			if (!this._isEnabled)
			{
				this._timer = 0;
			}

			this.toolStripMenuItem_enabled.Checked = this._isEnabled;
		}

		private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}