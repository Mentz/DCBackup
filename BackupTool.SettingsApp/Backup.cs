using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

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

        private List<string> backupItemList;

        #endregion

        public void AddToItemList(List<string> items) {
            foreach (string t in items) {
                backupItemList.Add(t);
            }
            UpdateItemList();
        }

        public List<string> GetSelectedItemList() {
            return backupItemList;
        }

        private void UpdateItemList() {
            listBoxSelectedItems.DataSource = null;
            listBoxSelectedItems.DataSource = backupItemList;
        }

        #region FormEventHandlers

        private void radioButtonFolders_CheckedChanged(object sender, EventArgs e) {
            if (!radioButtonFolders.Checked) {
                buttonAddFile.Enabled = true;
                buttonAddFolder.Enabled = false;
                backupItemList.Clear();
                UpdateItemList();
            }
        }

        private void radioButtonFiles_CheckedChanged(object sender, EventArgs e) {
            if (!radioButtonFiles.Checked) {
                buttonAddFile.Enabled = false;
                buttonAddFolder.Enabled = true;
                backupItemList.Clear();
                UpdateItemList();
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e) {
            SearchDirectory newTreeSelect = new SearchDirectory();
            newTreeSelect.SetSelectedItems(GetSelectedItemList());
            newTreeSelect.setTreeViewRoots();
            if (newTreeSelect.ShowDialog(this) == DialogResult.OK) {
                List<string> things = new List<string>();
                foreach (string s in newTreeSelect.GetSelectedItems()) {
                    things.Add(s);
                }
                ClearItemList();
                AddToItemList(things);
            }

            newTreeSelect.Dispose();
            newTreeSelect = null;
        }

        private void ClearItemList() {
            backupItemList.Clear();
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e) {
            if (listBoxSelectedItems.SelectedIndex == -1) {
                MessageBox.Show("Selecione um item para remover.");
            }
            else {
                //Remove vários itens, meu pai pediu para habilitar a remoção de vários itens. Apesar de eu descordar com isso.
                backupItemList.Clear();
                foreach (string items in listBoxSelectedItems.Items) {
                    bool CheckToRemove = false;
                    foreach (int itemToRemove in listBoxSelectedItems.SelectedIndices) {
                        if (items == listBoxSelectedItems.Items[itemToRemove].ToString()) {
                            CheckToRemove = true;
                        }
                    }
                    
                    if (CheckToRemove == false) {
                        backupItemList.Add(items);
                    }
                }
                UpdateItemList();
            }
        }

        private void buttonSaveProfile_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxProfileName_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !(char.IsLetterOrDigit(e.KeyChar) || char.Equals(e.KeyChar, '-') || char.Equals(e.KeyChar, '_'))) {
                e.Handled = true;
            }
        }

        private void buttonAddFile_Click(object sender, EventArgs e) {
            FileDialog.ShowDialog();
            AddToItemList(FileDialog.FileNames.ToList<string>());
            UpdateItemList();
        }

        private void listBoxSelectedItems_MouseDoubleClick(object sender, MouseEventArgs e) {
            //for(int i = listBoxSelectedItems.SelectedItem.ToString().Count() - 1; i >= 0; i++) {

            //}
            if (listBoxSelectedItems.SelectedIndex != -1) {
                DirectoryInfo dir = new DirectoryInfo(listBoxSelectedItems.SelectedItem.ToString());
                if (dir.Extension.ToString() != "")
                    Process.Start(Path.GetDirectoryName(dir.ToString()));
                else
                    Process.Start(listBoxSelectedItems.SelectedItem.ToString());
            }
        }

        #endregion
    }
}