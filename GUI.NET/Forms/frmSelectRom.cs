﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesen.GUI.Forms
{
	public partial class frmSelectRom : BaseForm
	{
		private List<string> _romFiles;
		private int SelectedIndex { get; set; }
		private string _previousSearch = "";

		public frmSelectRom(List<string> romFiles)
		{
			InitializeComponent();

			_romFiles = romFiles;
			lblRomCount.Text = ResourceHelper.GetMessage("RomsFound", _romFiles.Count.ToString());

			lstRoms.Sorted = true;
			this.DialogResult = DialogResult.Cancel;

			UpdateList();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(txtSearch.Focused) {
				if(keyData == Keys.Down || keyData == Keys.PageDown || keyData == Keys.Up || keyData == Keys.PageUp) {
					lstRoms.Focus();
					if(lstRoms.Items.Count > 0) {
						lstRoms.SelectedIndex = 0;
					}
					return true;
				}
			} else if(lstRoms.Focused && lstRoms.SelectedIndex <= 0) {
				if(keyData == Keys.Up || keyData == Keys.PageUp) {
					txtSearch.Focus();
					txtSearch.SelectAll();
					return true;
				}
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}		

		private void UpdateList()
		{
			lstRoms.Items.Clear();
			if(string.IsNullOrWhiteSpace(_previousSearch)) {
				lstRoms.Items.AddRange(_romFiles.ToArray());
			} else {
				List<string> romsToAdd = new List<string>();
				foreach(string rom in _romFiles) {
					if(rom.IndexOf(_previousSearch, StringComparison.InvariantCultureIgnoreCase) >= 0) {
						romsToAdd.Add(rom);
					}
				}
				lstRoms.Items.AddRange(romsToAdd.ToArray());
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			txtSearch.Focus();
		}

		public static bool SelectRom(ref ResourcePath resource)
		{
			List<string> archiveRomList = InteropEmu.GetArchiveRomList(resource.Path);

			if(archiveRomList.Contains(resource.InnerFile)) {
				return true;
			}

			if(archiveRomList.Count > 1) {
				frmSelectRom frm = new frmSelectRom(archiveRomList);
				if(frm.ShowDialog(null, Application.OpenForms[0]) == DialogResult.OK) {
					resource.InnerFile = frm.lstRoms.SelectedItem.ToString();
				} else {
					return false;
				}
			} else if(archiveRomList.Count == 1) {
				resource.InnerFile = archiveRomList[0];
			} else {
				resource.InnerFile = "";
			}

			return true;
		}

		void SetSelectedIndex()
		{
			this.SelectedIndex = _romFiles.IndexOf(lstRoms.SelectedItem.ToString());
			this.DialogResult = DialogResult.OK;
		}

		private void lstRoms_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnOK.Enabled = lstRoms.SelectedItems.Count > 0;
		}

		private void lstRoms_DoubleClick(object sender, EventArgs e)
		{
			SetSelectedIndex();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SetSelectedIndex();
		}

		private void tmrSearch_Tick(object sender, EventArgs e)
		{
			if(txtSearch.Text.Trim() != _previousSearch) {
				_previousSearch = txtSearch.Text.Trim();
				UpdateList();
			}
		}
	}
}
