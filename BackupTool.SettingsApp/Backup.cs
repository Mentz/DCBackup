using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupTool.SettingsApp {
    public partial class Backup: Form {
        public Backup() {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void radioButtonFolders_CheckedChanged(object sender, EventArgs e) {
            if (!radioButtonFolders.Checked) {
                listBoxSelectedItems.DataSource = null;
            }
        }

        private void radioButtonFiles_CheckedChanged(object sender, EventArgs e) {
            if (!radioButtonFiles.Checked) {
                listBoxSelectedItems.DataSource = null;
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e) {
            if (radioButtonFiles.Checked) {
                FileDialog.ShowDialog();
                List<string> fileList = new List<string>();
                fileList.AddRange(FileDialog.FileNames);
                listBoxSelectedItems.DataSource = fileList;
            }
            else if (radioButtonFolders.Checked) {
                TreeSelect treeSelect = new TreeSelect();
                treeSelect.Show();
            }
            else {
                MessageBox.Show("Houve um erro (cód. 0001).\nFavor comunicar ao programador Leonardo.");
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e) {

        }
    }
}