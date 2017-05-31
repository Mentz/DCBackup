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

        #region InitMethods

        public Backup() {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
            backupItemList = new List<string>();
        }

        private void Backup_Load(object sender, EventArgs e) {
            toolTips.SetToolTip(this.textBoxProfileName, "O nome só poderá ter caracteres do alfabeto, números e\n" +
                "os símbolos underline \"_\" e hífen \"-\".");
            toolTips.SetToolTip(this.radioButtonFiles, "O backup irá guardar somente os\narquivos selecionados.\n\n" +
                "Alterar essa opção irá reiniciar a lista de itens\ndo perfil de backup atual.");
            toolTips.SetToolTip(this.radioButtonFolders, "O backup irá guardar somente os arquivos\nguardados diretamente na pasta selecionada.\n\n" +
                "Alterar essa opção irá reiniciar a lista de itens\ndo perfil de backup atual.");
        }

        #endregion

        #region GlobalVariables

        List<string> backupItemList;

        #endregion

        public void AddToItemList(List<string> items) {
            foreach (string t in items) {
                backupItemList.Add(t);
            }
            UpdateItemList();
        }

        private void UpdateItemList() {
            listBoxSelectedItems.DataSource = null;
            listBoxSelectedItems.DataSource = backupItemList;
        }

        #region FormEventHandlers

        private void radioButtonFolders_CheckedChanged(object sender, EventArgs e) {
            if (!radioButtonFolders.Checked) {
                backupItemList.Clear();
                UpdateItemList();
            }
        }

        private void radioButtonFiles_CheckedChanged(object sender, EventArgs e) {
            if (!radioButtonFiles.Checked) {
                backupItemList.Clear();
                UpdateItemList();
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

                if (treeSelect.ShowDialog(this) == DialogResult.OK) {
                    List<string> things = new List<string>();
                    foreach (TreeNode s in treeSelect.selectedNodes) {
                        things.Add(s.FullPath.Replace("\\\\", "\\"));
                    }
                    AddToItemList(things);
                }

                treeSelect.Dispose();
            }
            else {
                MessageBox.Show("Houve um erro (cód. 0001).\nFavor comunicar ao programador Leonardo:\n\nRadio unselected.");
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e) {
            if (listBoxSelectedItems.SelectedIndex == -1) {
                MessageBox.Show("Selecione um item para remover.");
            }
            else {
                backupItemList.RemoveAt(listBoxSelectedItems.SelectedIndex);
                UpdateItemList();
            }
        }

        private void buttonSaveProfile_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxProfileName_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !(char.IsLetterOrDigit(e.KeyChar) || char.Equals(e.KeyChar, '-') || char.Equals(e.KeyChar, '_'))) {
                e.Handled = true;
            }
        }

        #endregion

    }
}