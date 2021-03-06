﻿namespace Mesen.GUI.Debugger.Controls
{
	partial class ctrlMemoryAccessCounters
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblViewMemoryType = new System.Windows.Forms.Label();
			this.cboMemoryType = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblSort = new System.Windows.Forms.Label();
			this.cboSort = new System.Windows.Forms.ComboBox();
			this.chkHighlightUninitRead = new System.Windows.Forms.CheckBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.ctrlScrollableTextbox = new Mesen.GUI.Debugger.ctrlScrollableTextbox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.lblViewMemoryType);
			this.flowLayoutPanel1.Controls.Add(this.cboMemoryType);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 26);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// lblViewMemoryType
			// 
			this.lblViewMemoryType.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblViewMemoryType.AutoSize = true;
			this.lblViewMemoryType.Location = new System.Drawing.Point(3, 7);
			this.lblViewMemoryType.Name = "lblViewMemoryType";
			this.lblViewMemoryType.Size = new System.Drawing.Size(33, 13);
			this.lblViewMemoryType.TabIndex = 0;
			this.lblViewMemoryType.Text = "View:";
			// 
			// cboMemoryType
			// 
			this.cboMemoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMemoryType.FormattingEnabled = true;
			this.cboMemoryType.Items.AddRange(new object[] {
            "Console RAM",
            "PRG ROM",
            "Cartridge Save RAM",
            "Cartridge Work RAM"});
			this.cboMemoryType.Location = new System.Drawing.Point(42, 3);
			this.cboMemoryType.Name = "cboMemoryType";
			this.cboMemoryType.Size = new System.Drawing.Size(121, 21);
			this.cboMemoryType.TabIndex = 1;
			this.cboMemoryType.SelectedIndexChanged += new System.EventHandler(this.cboMemoryType_SelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.ctrlScrollableTextbox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.chkHighlightUninitRead, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnReset, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 307);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel2.Controls.Add(this.lblSort);
			this.flowLayoutPanel2.Controls.Add(this.cboSort);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(335, 3);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(182, 26);
			this.flowLayoutPanel2.TabIndex = 3;
			// 
			// lblSort
			// 
			this.lblSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSort.AutoSize = true;
			this.lblSort.Location = new System.Drawing.Point(3, 7);
			this.lblSort.Name = "lblSort";
			this.lblSort.Size = new System.Drawing.Size(43, 13);
			this.lblSort.TabIndex = 0;
			this.lblSort.Text = "Sort by:";
			// 
			// cboSort
			// 
			this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSort.FormattingEnabled = true;
			this.cboSort.Items.AddRange(new object[] {
            "Address",
            "Read Count",
            "Write Count",
            "Execute Count",
            "Uninitialized Reads"});
			this.cboSort.Location = new System.Drawing.Point(52, 3);
			this.cboSort.Name = "cboSort";
			this.cboSort.Size = new System.Drawing.Size(121, 21);
			this.cboSort.TabIndex = 1;
			this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
			// 
			// chkHighlightUninitRead
			// 
			this.chkHighlightUninitRead.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkHighlightUninitRead.AutoSize = true;
			this.chkHighlightUninitRead.Location = new System.Drawing.Point(3, 284);
			this.chkHighlightUninitRead.Name = "chkHighlightUninitRead";
			this.chkHighlightUninitRead.Size = new System.Drawing.Size(422, 17);
			this.chkHighlightUninitRead.TabIndex = 4;
			this.chkHighlightUninitRead.Text = "Highlight uninitialized memory reads (only accurate if debugger is active at powe" +
    "r on)";
			this.chkHighlightUninitRead.UseVisualStyleBackColor = true;
			this.chkHighlightUninitRead.CheckedChanged += new System.EventHandler(this.chkHighlightUninitRead_CheckedChanged);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(436, 281);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset Counts";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// ctrlScrollableTextbox
			// 
			this.ctrlScrollableTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.ctrlScrollableTextbox, 2);
			this.ctrlScrollableTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlScrollableTextbox.Location = new System.Drawing.Point(3, 35);
			this.ctrlScrollableTextbox.Name = "ctrlScrollableTextbox";
			this.ctrlScrollableTextbox.ShowContentNotes = false;
			this.ctrlScrollableTextbox.ShowLineNumberNotes = false;
			this.ctrlScrollableTextbox.Size = new System.Drawing.Size(508, 240);
			this.ctrlScrollableTextbox.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(514, 32);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// ctrlMemoryAccessCounters
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ctrlMemoryAccessCounters";
			this.Size = new System.Drawing.Size(514, 307);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlScrollableTextbox ctrlScrollableTextbox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblViewMemoryType;
		private System.Windows.Forms.ComboBox cboMemoryType;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label lblSort;
		private System.Windows.Forms.ComboBox cboSort;
		private System.Windows.Forms.CheckBox chkHighlightUninitRead;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}
