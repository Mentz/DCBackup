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
        public List< List<string> > itemsToExpand;

        public SearchDirectory()
        {
            InitializeComponent();
            this.ControlBox = false;
            itemsMarcados = new List<string>();
            itemsToExpand = new List< List<string> > (20);
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
                checkNodeToExpand(no);
                foreach (string dAtual in dirs) {
                    DirectoryInfo dInfo = new DirectoryInfo(dAtual);
                    if (dInfo.ToString() == "C:\\Arquivos de Programas" || dInfo.ToString() == "C:\\Documents and Settings")
                        continue;
                    TreeNode tmp = new TreeNode();
                    tmp.Text = dInfo.Name;

                    if (tmp.Text == "Program Files")
                        tmp.Text = "Arquivos de Programas";
                    else if (tmp.Text == "Program Files (x86)")
                        tmp.Text = "Arquivos de Progamas (x86)";

                    tmp.Tag = dInfo;
                    tmp.ImageIndex = 0;
                    try {
                        no.Nodes.Add(tmp);
                        if (dInfo.GetDirectories().Count() > 0) {
                            tmp.Nodes.Add(null, "...", 0, 0);
                        }
                        checkNodeToExpand(tmp);
                    } catch (Exception ex) {
                        //
                    }

                    foreach (string str in itemsMarcados) {
                        if (str == tmp.Tag.ToString())
                            tmp.Checked = true;
                        if (str == no.Tag.ToString())
                            no.Checked = true;
                    }
                }
            }
            directoryTree.Nodes.Add(no);
        }

        public void checkNodeToExpand(TreeNode no) {
            int depth = no.Level;
            foreach(List<string> list in itemsToExpand) {
                ///MessageBox.Show(depth.ToString() + " " + list[depth] + " " + no.Text);
                if(depth < list.Count() - 1)
                    if (list[depth] == no.Text)
                        no.Expand();
            }
        }

        public void setTreeViewRoots() {
            foreach (string dir in Environment.GetLogicalDrives()) {
                DriveInfo drive = new DriveInfo(dir);
                newTreeViewRoot(dir, dir, drive.DriveType.ToString());
            }
        }

        public void SetSelectedItems(List<string> list) {
            itemsMarcados.AddRange(list);

            foreach (string str in itemsMarcados) {
                List<string> aux = new List<string>();
                aux.AddRange(str.Split('\\'));
                itemsToExpand.Add(aux);
            }

            for(int i = 0; i < itemsToExpand.Count; i++) {
                itemsToExpand[i][0] += '\\'; 
            }
        }

        public List<string> GetSelectedItems() {
            return itemsMarcados;
        }

        private void directoryTree_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            e.Node.ImageKey = "OpenFolder";
            if (e.Node.Nodes.Count > 0) {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null) {
                    e.Node.Nodes.Clear();
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                    foreach (string dir in dirs) {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 0);

                        bool diretorioAutorizado = true;
                        try {
                            node.Tag = di;
                            if (di.GetDirectories().Count() > 0) {
                                node.Nodes.Add(null, "...", 0, 0);
                            }
                        }
                        catch (UnauthorizedAccessException) {
                            diretorioAutorizado = false;
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message, "Erro ao listar diretório",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally {
                            //node.Checked = e.Node.Checked;
                            if (diretorioAutorizado == true) {
                                //checkNodeToExpand(e.Node);
                                foreach (string a in itemsMarcados)
                                    if (a == node.Tag.ToString()) {
                                        node.Checked = true;
                                        //node.Expand();
                                    }
                               
                                e.Node.Nodes.Add(node);
                                checkNodeToExpand(e.Node);
                                checkNodeToExpand(node);
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
        }

        private void buttonUpdateList_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void directoryTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e) {
            //e.Node.ImageKey = "OpenFolder";
            if (e.Node.ImageKey == "OpenFolder")
                e.Node.ImageKey = "Root";
        }
    }
}
