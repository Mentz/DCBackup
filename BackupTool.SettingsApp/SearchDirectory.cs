using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BackupTool.SettingsApp
{
    public partial class SearchDirectory : Form
    {
        public List<string> itemsMarcados;
       
        public SearchDirectory()
        {
            InitializeComponent();
            itemsMarcados = new List<string>();
        }

        public void expandParent(TreeNode no) {
            if(no.Parent != null) {
                no.Parent.Expand();
                expandParent(no.Parent);
            }
        }

        public void newTreeViewRoot(string name, string diretorio, string imageIndex) {
            TreeNode no = new TreeNode();
            no.Text = name;
            no.Tag = diretorio;
            no.SelectedImageKey = imageIndex;
            no.ImageKey = imageIndex;
            DriveInfo d = new DriveInfo(diretorio);

            if (d.IsReady == true) { 
                string[] dirs = Directory.GetDirectories(no.Tag.ToString());
                foreach (string dAtual in dirs) {
                    DirectoryInfo dInfo = new DirectoryInfo(dAtual);
                    TreeNode tmp = new TreeNode();
                    tmp.Text = dInfo.Name;
                    tmp.Tag = dInfo;
                    tmp.ImageIndex = 0;

                    try {
                        if (dInfo.GetDirectories().Count() > 0)
                            tmp.Nodes.Add(null, "...", 0, 0);
                        no.Nodes.Add(tmp);
                    } catch (Exception ex) {
                        //
                    }

                    foreach (string str in itemsMarcados) {
                        if (str == tmp.Tag.ToString()) {
                            tmp.Checked = true;
                            tmp.Expand();
                            expandParent(tmp);
                        }
                        if (str == no.Tag.ToString()) {
                            no.Checked = true;
                            no.Expand();
                            expandParent(no);
                        }
                    }
                }
            }
            directoryTree.Nodes.Add(no);
        }

        public void setTreeViewRoots() {
            newTreeViewRoot("Arquivos pessoais", Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Personal");
            foreach (string dir in Environment.GetLogicalDrives()) {
                DriveInfo drive = new DriveInfo(dir);
               
                newTreeViewRoot(dir, dir, drive.DriveType.ToString());
            }
        }

        public void SetSelectedItems(List<string> list) {
            itemsMarcados.AddRange(list);
        }

        public List<string> GetSelectedItems() {
            return itemsMarcados;
        }

        private void directoryTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0) {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null) {
                    e.Node.Nodes.Clear();
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                    foreach (string dir in dirs){
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 0);

                        bool diretorioAutorizado = true;
                        try {
                            node.Tag = di;
                            if (di.GetDirectories().Count() > 0) {
                                node.Nodes.Add(null, "...", 0, 0);
                            }
                        }
                        catch (UnauthorizedAccessException){
                            diretorioAutorizado = false;
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message, "Erro ao listar diretório",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally {
                            //node.Checked = e.Node.Checked;
                            if (diretorioAutorizado == true) {
                                foreach (string a in itemsMarcados)
                                    if (a == node.Tag.ToString()) {
                                        node.Checked = true;
                                        node.Expand();
                                        expandParent(node);
                                    }
                                e.Node.Nodes.Add(node);
                            }
                        }
                    }
                }
            }
        }

        private void directoryTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null) {
                if (e.Node.Checked == true) {
                    bool found = false;
                    foreach (string t in itemsMarcados) {
                        //MessageBox.Show(t + " " + e.Node.Tag.ToString());
                        if (t == e.Node.Tag.ToString()) {
                            found = true;
                        }
                    }
                    if (found == false)
                        itemsMarcados.Add(e.Node.Tag.ToString());
                }


                if (e.Node.Checked == false) {
                    for (int i = 0; i < itemsMarcados.Count; i++) {
                        if (itemsMarcados[i] == e.Node.Tag.ToString())
                            itemsMarcados.RemoveAt(i);
                    }
                }
            }

            /*if(e.Node.Checked == false) {
                TreeNode no = e.Node.Parent;
            no.Checked = false;
            }
            recursion(e.Node);
            */
            //MessageBox.Show(e.Node.ToString());
        }

        public void recursion(TreeNode no) {
            if (no.Nodes.Count > 0) {
                foreach (TreeNode n in no.Nodes) {
                    n.Checked = no.Checked;
                    if (n.Nodes.Count > 0)
                        recursion(n);
                }
            }
        }

        private void buttonUpdateList_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
