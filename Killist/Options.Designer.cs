﻿namespace Killist
{
	partial class Options
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.listBox_processes = new System.Windows.Forms.ListBox();
			this.textBox_process = new System.Windows.Forms.TextBox();
			this.button_add = new System.Windows.Forms.Button();
			this.button_remove = new System.Windows.Forms.Button();
			this.tray = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenu_tray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_enabled = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_settings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.label_processName = new System.Windows.Forms.Label();
			this.checkBox_instaKill = new System.Windows.Forms.CheckBox();
			this.link_github = new System.Windows.Forms.LinkLabel();
			this.label_processesList = new System.Windows.Forms.Label();
			this.contextMenu_tray.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox_processes
			// 
			this.listBox_processes.FormattingEnabled = true;
			this.listBox_processes.Location = new System.Drawing.Point(14, 26);
			this.listBox_processes.Name = "listBox_processes";
			this.listBox_processes.Size = new System.Drawing.Size(233, 134);
			this.listBox_processes.TabIndex = 0;
			// 
			// textBox_process
			// 
			this.textBox_process.Location = new System.Drawing.Point(14, 181);
			this.textBox_process.Name = "textBox_process";
			this.textBox_process.Size = new System.Drawing.Size(164, 20);
			this.textBox_process.TabIndex = 1;
			this.textBox_process.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_process_KeyDown);
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(184, 180);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(63, 23);
			this.button_add.TabIndex = 2;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_remove
			// 
			this.button_remove.Location = new System.Drawing.Point(184, 209);
			this.button_remove.Name = "button_remove";
			this.button_remove.Size = new System.Drawing.Size(63, 24);
			this.button_remove.TabIndex = 3;
			this.button_remove.Text = "Remove";
			this.button_remove.UseVisualStyleBackColor = true;
			this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
			// 
			// tray
			// 
			this.tray.ContextMenuStrip = this.contextMenu_tray;
			this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
			this.tray.Text = "Killist";
			this.tray.Visible = true;
			// 
			// contextMenu_tray
			// 
			this.contextMenu_tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_enabled,
            this.toolStripMenuItem_settings,
            this.toolStripSeparator1,
            this.toolStripMenuItem_exit});
			this.contextMenu_tray.Name = "contextMenu_tray";
			this.contextMenu_tray.Size = new System.Drawing.Size(117, 76);
			// 
			// toolStripMenuItem_enabled
			// 
			this.toolStripMenuItem_enabled.Name = "toolStripMenuItem_enabled";
			this.toolStripMenuItem_enabled.Size = new System.Drawing.Size(116, 22);
			this.toolStripMenuItem_enabled.Text = "Enabled";
			this.toolStripMenuItem_enabled.Click += new System.EventHandler(this.toolStripMenuItem_enabled_Click);
			// 
			// toolStripMenuItem_settings
			// 
			this.toolStripMenuItem_settings.Name = "toolStripMenuItem_settings";
			this.toolStripMenuItem_settings.Size = new System.Drawing.Size(116, 22);
			this.toolStripMenuItem_settings.Text = "Settings";
			this.toolStripMenuItem_settings.Click += new System.EventHandler(this.toolStripMenuItem_settings_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
			// 
			// toolStripMenuItem_exit
			// 
			this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
			this.toolStripMenuItem_exit.Size = new System.Drawing.Size(116, 22);
			this.toolStripMenuItem_exit.Text = "Exit";
			this.toolStripMenuItem_exit.Click += new System.EventHandler(this.toolStripMenuItem_exit_Click);
			// 
			// label_processName
			// 
			this.label_processName.AutoSize = true;
			this.label_processName.Location = new System.Drawing.Point(11, 165);
			this.label_processName.Name = "label_processName";
			this.label_processName.Size = new System.Drawing.Size(216, 13);
			this.label_processName.TabIndex = 7;
			this.label_processName.Text = "Process Name (without .exe, Case sensitive)";
			// 
			// checkBox_instaKill
			// 
			this.checkBox_instaKill.AutoSize = true;
			this.checkBox_instaKill.Location = new System.Drawing.Point(14, 214);
			this.checkBox_instaKill.Name = "checkBox_instaKill";
			this.checkBox_instaKill.Size = new System.Drawing.Size(125, 17);
			this.checkBox_instaKill.TabIndex = 8;
			this.checkBox_instaKill.Text = "InstaKill (CPU heavy)";
			this.checkBox_instaKill.UseVisualStyleBackColor = true;
			this.checkBox_instaKill.CheckedChanged += new System.EventHandler(this.checkBox_instaKill_CheckedChanged);
			// 
			// link_github
			// 
			this.link_github.AutoSize = true;
			this.link_github.Location = new System.Drawing.Point(207, 10);
			this.link_github.Name = "link_github";
			this.link_github.Size = new System.Drawing.Size(40, 13);
			this.link_github.TabIndex = 9;
			this.link_github.TabStop = true;
			this.link_github.Text = "GitHub";
			this.link_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_github_LinkClicked);
			// 
			// label_processesList
			// 
			this.label_processesList.AutoSize = true;
			this.label_processesList.Location = new System.Drawing.Point(12, 10);
			this.label_processesList.Name = "label_processesList";
			this.label_processesList.Size = new System.Drawing.Size(75, 13);
			this.label_processesList.TabIndex = 10;
			this.label_processesList.Text = "Processes List";
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 243);
			this.Controls.Add(this.label_processesList);
			this.Controls.Add(this.link_github);
			this.Controls.Add(this.checkBox_instaKill);
			this.Controls.Add(this.label_processName);
			this.Controls.Add(this.button_remove);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.textBox_process);
			this.Controls.Add(this.listBox_processes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Killist";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.Shown += new System.EventHandler(this.Main_Shown);
			this.contextMenu_tray.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox_processes;
		private System.Windows.Forms.TextBox textBox_process;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_remove;
		private System.Windows.Forms.NotifyIcon tray;
		private System.Windows.Forms.ContextMenuStrip contextMenu_tray;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_settings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_enabled;
		private System.Windows.Forms.Label label_processName;
		private System.Windows.Forms.CheckBox checkBox_instaKill;
		private System.Windows.Forms.LinkLabel link_github;
		private System.Windows.Forms.Label label_processesList;
	}
}

