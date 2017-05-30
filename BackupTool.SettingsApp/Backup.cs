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

        static List<string> backupItemList = new List<string>();

        public Backup(List<string> itemList) {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
            backupItemList = itemList;
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
                backupItemList.AddRange(FileDialog.FileNames);
                UpdateItemList();
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
            if (listBoxSelectedItems.SelectedIndex == -1) {
                MessageBox.Show("Selecione um item para remover.");
            } else {
                backupItemList.RemoveAt(listBoxSelectedItems.SelectedIndex);
                UpdateItemList();
            }
        }

        public void AddToItemList(List<string> items) {
            foreach (string t in items) { 
                MessageBox.Show(t);
                //backupItemList.Add(t);
            }
            UpdateItemList();
        }

        private void UpdateItemList() {
            MessageBox.Show("Lista de dados atualizada", "Olha eu aqui");
            listBoxSelectedItems.DataSource = null;
            listBoxSelectedItems.DataSource = backupItemList;
        }
    }
}