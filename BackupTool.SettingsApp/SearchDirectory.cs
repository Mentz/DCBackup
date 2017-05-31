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
            TreeNode noAcessoRapido = new TreeNode();
            noAcessoRapido.Text = "Arquivos pessoais";
            noAcessoRapido.Tag = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            noAcessoRapido.SelectedImageIndex = 5; noAcessoRapido.ImageIndex = 5;
            string[] dirs = Directory.GetDirectories(noAcessoRapido.Tag.ToString());
            foreach(string dAtual in dirs) {
                DirectoryInfo dInfo = new DirectoryInfo(dAtual);
                TreeNode no = new TreeNode();
                no.Text = dInfo.Name;
                no.Tag = dInfo;
                no.ImageIndex = 0;
                try {
                    if (dInfo.GetDirectories().Count() > 0) {
                        no.Nodes.Add(null, "...", 0, 0);
                    }
                    noAcessoRapido.Nodes.Add(no);
                } catch(Exception ex) {
                    //
                }

                if (itemsMarcados != null) {
                    foreach (string a in itemsMarcados) {
                        if (a == no.Tag.ToString()) {
                            no.Checked = true;
                            MessageBox.Show("aaa");
                        }
                        if (a == noAcessoRapido.Tag.ToString())
                            noAcessoRapido.Checked = true;
                    }
                }
            }
            directoryTree.Nodes.Add(noAcessoRapido);

            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives){
                DriveInfo d = new DriveInfo(drive);
                int driveImage;

                switch (d.DriveType) {
                    case DriveType.CDRom:
                        driveImage = 2;
                        break;

                    case DriveType.Fixed:
                        driveImage = 1;
                        break;

                    case DriveType.Network:
                        driveImage = 3;
                        break;
                    
                    default:
                        driveImage = 1;
                        break;
                }
                TreeNode node = new TreeNode(drive, driveImage, driveImage);

                node.Tag = drive;
                if (d.IsReady == true) {
                    node.Nodes.Add("...");
                    node.Checked = false;
                }

                foreach (string a in itemsMarcados)
                    if (a == node.Tag.ToString())
                        node.Checked = true;
                directoryTree.Nodes.Add(node);
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
                                    if (a == node.Tag.ToString())
                                        node.Checked = true;
                                e.Node.Nodes.Add(node);
                            }
                        }
                    }
                }
            }
        }

        private void directoryTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Checked == true) {
                bool found = false;
                foreach (string t in itemsMarcados) {
                    MessageBox.Show(t + " " + e.Node.Tag.ToString());
                    if (t == e.Node.Tag.ToString()) {
                        found = true;
                    }
                }
                if (found == false)
                    itemsMarcados.Add(e.Node.Tag.ToString());
            }

            if(e.Node.Checked == false) {
                for(int i = 0; i < itemsMarcados.Count; i++) {
                    if (itemsMarcados[i] == e.Node.Tag.ToString())
                        itemsMarcados.RemoveAt(i);
                }
            }

            recursion(e.Node);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
