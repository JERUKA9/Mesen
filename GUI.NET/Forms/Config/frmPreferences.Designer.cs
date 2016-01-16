﻿namespace Mesen.GUI.Forms.Config
{
	partial class frmPreferences
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
			if(disposing && (components != null)) {
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
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.chkAutoLoadIps = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.chkSingleInstance = new System.Windows.Forms.CheckBox();
			this.chkDisableScreensaver = new System.Windows.Forms.CheckBox();
			this.chkMuteSoundInBackground = new System.Windows.Forms.CheckBox();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tpgGeneral = new System.Windows.Forms.TabPage();
			this.tpgFileAssociations = new System.Windows.Forms.TabPage();
			this.grpFileAssociations = new System.Windows.Forms.GroupBox();
			this.tlpFileFormat = new System.Windows.Forms.TableLayoutPanel();
			this.chkNesFormat = new System.Windows.Forms.CheckBox();
			this.chkFdsFormat = new System.Windows.Forms.CheckBox();
			this.chkMmoFormat = new System.Windows.Forms.CheckBox();
			this.chkMstFormat = new System.Windows.Forms.CheckBox();
			this.tpgAdvanced = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.chkUseAlternativeMmc3Irq = new System.Windows.Forms.CheckBox();
			this.chkAllowInvalidInput = new System.Windows.Forms.CheckBox();
			this.chkRemoveSpriteLimit = new System.Windows.Forms.CheckBox();
			this.tlpMain.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.tpgGeneral.SuspendLayout();
			this.tpgFileAssociations.SuspendLayout();
			this.grpFileAssociations.SuspendLayout();
			this.tlpFileFormat.SuspendLayout();
			this.tpgAdvanced.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// baseConfigPanel
			// 
			this.baseConfigPanel.Location = new System.Drawing.Point(0, 239);
			this.baseConfigPanel.Size = new System.Drawing.Size(394, 29);
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpMain.Controls.Add(this.checkBox1, 0, 4);
			this.tlpMain.Controls.Add(this.chkAutoLoadIps, 0, 1);
			this.tlpMain.Controls.Add(this.flowLayoutPanel6, 0, 0);
			this.tlpMain.Controls.Add(this.chkDisableScreensaver, 0, 2);
			this.tlpMain.Controls.Add(this.chkMuteSoundInBackground, 0, 3);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(3, 3);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 5;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.Size = new System.Drawing.Size(380, 207);
			this.tlpMain.TabIndex = 1;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new System.Drawing.Point(3, 95);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(204, 17);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Pause emulation when in background";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// chkAutoLoadIps
			// 
			this.chkAutoLoadIps.AutoSize = true;
			this.chkAutoLoadIps.Location = new System.Drawing.Point(3, 26);
			this.chkAutoLoadIps.Name = "chkAutoLoadIps";
			this.chkAutoLoadIps.Size = new System.Drawing.Size(132, 17);
			this.chkAutoLoadIps.TabIndex = 9;
			this.chkAutoLoadIps.Text = "Auto-load IPS patches";
			this.chkAutoLoadIps.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.AutoSize = true;
			this.flowLayoutPanel6.Controls.Add(this.chkSingleInstance);
			this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Size = new System.Drawing.Size(380, 23);
			this.flowLayoutPanel6.TabIndex = 10;
			// 
			// chkSingleInstance
			// 
			this.chkSingleInstance.AutoSize = true;
			this.chkSingleInstance.Location = new System.Drawing.Point(3, 3);
			this.chkSingleInstance.Name = "chkSingleInstance";
			this.chkSingleInstance.Size = new System.Drawing.Size(228, 17);
			this.chkSingleInstance.TabIndex = 11;
			this.chkSingleInstance.Text = "Only allow one instance of Mesen at a time";
			this.chkSingleInstance.UseVisualStyleBackColor = true;
			// 
			// chkDisableScreensaver
			// 
			this.chkDisableScreensaver.AutoSize = true;
			this.chkDisableScreensaver.Enabled = false;
			this.chkDisableScreensaver.Location = new System.Drawing.Point(3, 49);
			this.chkDisableScreensaver.Name = "chkDisableScreensaver";
			this.chkDisableScreensaver.Size = new System.Drawing.Size(245, 17);
			this.chkDisableScreensaver.TabIndex = 11;
			this.chkDisableScreensaver.Text = "Disable screensaver while emulation is running";
			this.chkDisableScreensaver.UseVisualStyleBackColor = true;
			// 
			// chkMuteSoundInBackground
			// 
			this.chkMuteSoundInBackground.AutoSize = true;
			this.chkMuteSoundInBackground.Enabled = false;
			this.chkMuteSoundInBackground.Location = new System.Drawing.Point(3, 72);
			this.chkMuteSoundInBackground.Name = "chkMuteSoundInBackground";
			this.chkMuteSoundInBackground.Size = new System.Drawing.Size(182, 17);
			this.chkMuteSoundInBackground.TabIndex = 12;
			this.chkMuteSoundInBackground.Text = "Mute sound when in background";
			this.chkMuteSoundInBackground.UseVisualStyleBackColor = true;
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.tpgGeneral);
			this.tabMain.Controls.Add(this.tpgFileAssociations);
			this.tabMain.Controls.Add(this.tpgAdvanced);
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.Location = new System.Drawing.Point(0, 0);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(394, 239);
			this.tabMain.TabIndex = 2;
			// 
			// tpgGeneral
			// 
			this.tpgGeneral.Controls.Add(this.tlpMain);
			this.tpgGeneral.Location = new System.Drawing.Point(4, 22);
			this.tpgGeneral.Name = "tpgGeneral";
			this.tpgGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tpgGeneral.Size = new System.Drawing.Size(386, 213);
			this.tpgGeneral.TabIndex = 0;
			this.tpgGeneral.Text = "General";
			this.tpgGeneral.UseVisualStyleBackColor = true;
			// 
			// tpgFileAssociations
			// 
			this.tpgFileAssociations.Controls.Add(this.grpFileAssociations);
			this.tpgFileAssociations.Location = new System.Drawing.Point(4, 22);
			this.tpgFileAssociations.Name = "tpgFileAssociations";
			this.tpgFileAssociations.Padding = new System.Windows.Forms.Padding(3);
			this.tpgFileAssociations.Size = new System.Drawing.Size(386, 213);
			this.tpgFileAssociations.TabIndex = 2;
			this.tpgFileAssociations.Text = "File Associations";
			this.tpgFileAssociations.UseVisualStyleBackColor = true;
			// 
			// grpFileAssociations
			// 
			this.grpFileAssociations.Controls.Add(this.tlpFileFormat);
			this.grpFileAssociations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpFileAssociations.Location = new System.Drawing.Point(3, 3);
			this.grpFileAssociations.Name = "grpFileAssociations";
			this.grpFileAssociations.Size = new System.Drawing.Size(380, 207);
			this.grpFileAssociations.TabIndex = 12;
			this.grpFileAssociations.TabStop = false;
			this.grpFileAssociations.Text = "File Associations";
			// 
			// tlpFileFormat
			// 
			this.tlpFileFormat.ColumnCount = 2;
			this.tlpFileFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpFileFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpFileFormat.Controls.Add(this.chkNesFormat, 0, 0);
			this.tlpFileFormat.Controls.Add(this.chkFdsFormat, 0, 1);
			this.tlpFileFormat.Controls.Add(this.chkMmoFormat, 1, 0);
			this.tlpFileFormat.Controls.Add(this.chkMstFormat, 1, 1);
			this.tlpFileFormat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpFileFormat.Location = new System.Drawing.Point(3, 16);
			this.tlpFileFormat.Name = "tlpFileFormat";
			this.tlpFileFormat.RowCount = 4;
			this.tlpFileFormat.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpFileFormat.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpFileFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpFileFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpFileFormat.Size = new System.Drawing.Size(374, 188);
			this.tlpFileFormat.TabIndex = 0;
			// 
			// chkNesFormat
			// 
			this.chkNesFormat.AutoSize = true;
			this.chkNesFormat.Location = new System.Drawing.Point(3, 3);
			this.chkNesFormat.Name = "chkNesFormat";
			this.chkNesFormat.Size = new System.Drawing.Size(51, 17);
			this.chkNesFormat.TabIndex = 10;
			this.chkNesFormat.Text = ".NES";
			this.chkNesFormat.UseVisualStyleBackColor = true;
			// 
			// chkFdsFormat
			// 
			this.chkFdsFormat.AutoSize = true;
			this.chkFdsFormat.Enabled = false;
			this.chkFdsFormat.Location = new System.Drawing.Point(3, 26);
			this.chkFdsFormat.Name = "chkFdsFormat";
			this.chkFdsFormat.Size = new System.Drawing.Size(162, 17);
			this.chkFdsFormat.TabIndex = 12;
			this.chkFdsFormat.Text = ".FDS (Famicom Disk System)";
			this.chkFdsFormat.UseVisualStyleBackColor = true;
			// 
			// chkMmoFormat
			// 
			this.chkMmoFormat.AutoSize = true;
			this.chkMmoFormat.Enabled = false;
			this.chkMmoFormat.Location = new System.Drawing.Point(190, 3);
			this.chkMmoFormat.Name = "chkMmoFormat";
			this.chkMmoFormat.Size = new System.Drawing.Size(133, 17);
			this.chkMmoFormat.TabIndex = 11;
			this.chkMmoFormat.Text = ".MMO (Mesen Movies)";
			this.chkMmoFormat.UseVisualStyleBackColor = true;
			// 
			// chkMstFormat
			// 
			this.chkMstFormat.AutoSize = true;
			this.chkMstFormat.Enabled = false;
			this.chkMstFormat.Location = new System.Drawing.Point(190, 26);
			this.chkMstFormat.Name = "chkMstFormat";
			this.chkMstFormat.Size = new System.Drawing.Size(144, 17);
			this.chkMstFormat.TabIndex = 13;
			this.chkMstFormat.Text = ".MST (Mesen Savestate)";
			this.chkMstFormat.UseVisualStyleBackColor = true;
			// 
			// tpgAdvanced
			// 
			this.tpgAdvanced.Controls.Add(this.tableLayoutPanel1);
			this.tpgAdvanced.Location = new System.Drawing.Point(4, 22);
			this.tpgAdvanced.Name = "tpgAdvanced";
			this.tpgAdvanced.Padding = new System.Windows.Forms.Padding(3);
			this.tpgAdvanced.Size = new System.Drawing.Size(386, 213);
			this.tpgAdvanced.TabIndex = 1;
			this.tpgAdvanced.Text = "Advanced";
			this.tpgAdvanced.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.chkUseAlternativeMmc3Irq, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.chkAllowInvalidInput, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.chkRemoveSpriteLimit, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 207);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// chkUseAlternativeMmc3Irq
			// 
			this.chkUseAlternativeMmc3Irq.AutoSize = true;
			this.chkUseAlternativeMmc3Irq.Location = new System.Drawing.Point(3, 3);
			this.chkUseAlternativeMmc3Irq.Name = "chkUseAlternativeMmc3Irq";
			this.chkUseAlternativeMmc3Irq.Size = new System.Drawing.Size(197, 17);
			this.chkUseAlternativeMmc3Irq.TabIndex = 0;
			this.chkUseAlternativeMmc3Irq.Text = "Use alternative MMC3 IRQ behavior";
			this.chkUseAlternativeMmc3Irq.UseVisualStyleBackColor = true;
			// 
			// chkAllowInvalidInput
			// 
			this.chkAllowInvalidInput.AutoSize = true;
			this.chkAllowInvalidInput.Location = new System.Drawing.Point(3, 26);
			this.chkAllowInvalidInput.Name = "chkAllowInvalidInput";
			this.chkAllowInvalidInput.Size = new System.Drawing.Size(341, 17);
			this.chkAllowInvalidInput.TabIndex = 1;
			this.chkAllowInvalidInput.Text = "Allow invalid input (e.g Down + Up or Left + Right at the same time)";
			this.chkAllowInvalidInput.UseVisualStyleBackColor = true;
			// 
			// chkRemoveSpriteLimit
			// 
			this.chkRemoveSpriteLimit.AutoSize = true;
			this.chkRemoveSpriteLimit.Location = new System.Drawing.Point(3, 49);
			this.chkRemoveSpriteLimit.Name = "chkRemoveSpriteLimit";
			this.chkRemoveSpriteLimit.Size = new System.Drawing.Size(205, 17);
			this.chkRemoveSpriteLimit.TabIndex = 2;
			this.chkRemoveSpriteLimit.Text = "Remove sprite limit (Reduces flashing)";
			this.chkRemoveSpriteLimit.UseVisualStyleBackColor = true;
			// 
			// frmPreferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 268);
			this.Controls.Add(this.tabMain);
			this.Name = "frmPreferences";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.Controls.SetChildIndex(this.baseConfigPanel, 0);
			this.Controls.SetChildIndex(this.tabMain, 0);
			this.tlpMain.ResumeLayout(false);
			this.tlpMain.PerformLayout();
			this.flowLayoutPanel6.ResumeLayout(false);
			this.flowLayoutPanel6.PerformLayout();
			this.tabMain.ResumeLayout(false);
			this.tpgGeneral.ResumeLayout(false);
			this.tpgFileAssociations.ResumeLayout(false);
			this.grpFileAssociations.ResumeLayout(false);
			this.tlpFileFormat.ResumeLayout(false);
			this.tlpFileFormat.PerformLayout();
			this.tpgAdvanced.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.CheckBox chkAutoLoadIps;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.CheckBox chkSingleInstance;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox chkDisableScreensaver;
		private System.Windows.Forms.CheckBox chkMuteSoundInBackground;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tpgGeneral;
		private System.Windows.Forms.TabPage tpgFileAssociations;
		private System.Windows.Forms.GroupBox grpFileAssociations;
		private System.Windows.Forms.TableLayoutPanel tlpFileFormat;
		private System.Windows.Forms.CheckBox chkNesFormat;
		private System.Windows.Forms.CheckBox chkFdsFormat;
		private System.Windows.Forms.CheckBox chkMmoFormat;
		private System.Windows.Forms.CheckBox chkMstFormat;
		private System.Windows.Forms.TabPage tpgAdvanced;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckBox chkUseAlternativeMmc3Irq;
		private System.Windows.Forms.CheckBox chkAllowInvalidInput;
		private System.Windows.Forms.CheckBox chkRemoveSpriteLimit;
	}
}