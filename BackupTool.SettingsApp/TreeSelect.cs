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
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
            selectedNodes = new List<TreeNode>();
            normalFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
            treeViewMultiSelect.ImageList = IconList;
        }

        Font normalFont;
        public List<TreeNode> selectedNodes;

        private void TreeSelect_Shown(object sender, EventArgs e) {
            string directory = Path.GetPathRoot(Environment.SystemDirectory);
            fillTree();
        }

        private void fillTree() {
            string[] drives = Environment.GetLogicalDrives();
            foreach (string dr in drives) {
                TreeNode node = new TreeNode(dr);
                node.ImageIndex = 0; // drive icon
                node.Tag = dr;
                treeViewMultiSelect.Nodes.Add(node);
                node.Nodes.Add(new TreeNode("?"));
            }
        }

        void treeViewMultiSelect_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            if ((e.Node.Nodes.Count == 1) && (e.Node.Nodes[0].Text == "?")) {
                RecursiveDirWalk(e.Node);
            }
        }

        private TreeNode RecursiveDirWalk(TreeNode node) {
            string path = (string)node.Tag;
            node.Nodes.Clear();
            string[] dirs = System.IO.Directory.GetDirectories(path);
            for (int t = 0; t < dirs.Length; t++) {
                TreeNode n = new TreeNode(dirs[t].Substring(dirs[t].LastIndexOf('\\') + 1));
                n.ImageIndex = 0;
                n.Tag = dirs[t];
                node.Nodes.Add(n);
                n.Nodes.Add(new TreeNode("?"));
            }

            return node;
        }

        private void treeViewMultiSelect_AfterCheck(object sender, TreeViewEventArgs e) {
            if (e.Node.Checked == true)
                selectedNodes.Add(e.Node);
            else
                selectedNodes.Remove(e.Node);
        }

        private List<string> SelectedNodesToString() {
            List<string> ret = new List<string>();
            foreach (TreeNode x in selectedNodes) {
                ret.Add(x.FullPath);
            }
            return ret;
        }

        private void buttonTreeViewCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonTreeViewConfirm_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
