using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackupTool.SettingsApp {
    public partial class TreeSelect: Form {
        public TreeSelect() {
            selectedNodes = new List<TreeNode>();
            normalFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
            InitializeComponent();
            treeViewMultiSelect.ImageList = IconList;
        }

        Font normalFont;
        List<TreeNode> selectedNodes;
        //TreeNode previousNode;

        private void TreeSelect_Shown(object sender, EventArgs e) {
            string directory = Path.GetPathRoot(Environment.SystemDirectory);
            treeViewMultiSelect.Nodes.Add(directory.Remove(directory.Length - 1));
            BuildTree(directory, treeViewMultiSelect.Nodes[0], 2);
        }

        private void treeViewMultiSelect_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            string directory = Path.GetPathRoot(Environment.SystemDirectory);
            directory = Path.Combine(directory, e.Node.FullPath);
            BuildTree(directory, e.Node, 1);
        }

        private void BuildTree(string directory, TreeNode node, int depth) {
            if (depth == 0) {
                return;
            }
            try {
                string[] subdirectories = Directory.GetDirectories(directory);
                foreach (string subdirectory in subdirectories) {
                    if (directory != "C:")
                        MessageBox.Show(subdirectory);
                    string name = Path.GetFileName(subdirectory);
                    TreeNode subnode = (node == null) ?
                        treeViewMultiSelect.Nodes.Add(name) : node.Nodes.Add(name);
                    subnode.NodeFont = normalFont;
                    subnode.Text = subnode.Text;
                    subnode.ImageIndex = 0;
                    BuildTree(subdirectory, subnode, depth - 1);
                }
            }
            catch (Exception) {
                // Ignore exception, e.g. when access to a folder denied
            }
        }

        private void treeViewMultiSelect_BeforeCheck(object sender, TreeViewCancelEventArgs e) {
            selectedNodes.Add(e.Node);
        }

        private void buttonTreeViewCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private List<string> SelectedNodesToString() {
            List<string> ret = new List<string>();
            foreach (TreeNode x in selectedNodes) {
                ret.Add(x.FullPath);
            }
            return ret;
        }

        private void buttonTreeViewConfirm_Click(object sender, EventArgs e) {
            Backup singleton = new Backup(null);
            singleton.AddToItemList(SelectedNodesToString());
        }
    }
}
