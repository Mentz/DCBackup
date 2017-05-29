using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupTool.SettingsApp {
    public partial class TreeSelect: Form {
        public TreeSelect() {
            selectedNodes = new List<TreeNode>();
            boldFont = new Font("Arial", 10, FontStyle.Bold);
            normalFont = new Font("Arial", 10, FontStyle.Regular);
            InitializeComponent();
        }

        Font boldFont;
        Font normalFont;
        List<TreeNode> selectedNodes;
        TreeNode previousNode;

        private void TreeSelect_Shown(object sender, EventArgs e) {
            string directory = Path.GetPathRoot(Environment.SystemDirectory);
            BuildTree(directory, null);
        }

        private void BuildTree(string directory, TreeNode node) {
            try {
                string[] subdirectories = Directory.GetDirectories(directory);
                foreach (string subdirectory in subdirectories) {
                    string name = Path.GetFileName(subdirectory);
                    TreeNode subnode = (node == null) ?
                        treeViewMultiSelect.Nodes.Add(name) : node.Nodes.Add(name);
                    subnode.NodeFont = boldFont;
                    subnode.Text = subnode.Text; // google: 94354 treenode
                    //BuildTree(subdirectory, subnode);
                }
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files) {
                    string name = Path.GetFileName(file);
                    TreeNode subnode = (node == null) ?
                        treeViewMultiSelect.Nodes.Add(name) : node.Nodes.Add(name);
                    subnode.NodeFont = normalFont;
                    subnode.Text = subnode.Text; // google: 94354 treenode
                }
            }
            catch (Exception) {
                // Ignore exception, e.g. when access to a folder denied
            }
        }

        private void treeViewMultiSelect_BeforeSelect(object sender, TreeViewCancelEventArgs e) {
            // cancel selection, the selection will be handled in MouseDown
            e.Cancel = true;
        }

        private void treeViewMultiSelect_MouseDown(object sender, MouseEventArgs e) {
            TreeNode currentNode = treeViewMultiSelect.GetNodeAt(e.Location);
            if (currentNode == null) return;
            currentNode.BackColor = treeViewMultiSelect.BackColor;
            currentNode.ForeColor = treeViewMultiSelect.ForeColor;

            bool control = (ModifierKeys == Keys.Control);
            bool shift = (ModifierKeys == Keys.Shift);

            if (control) {

                // the node clicked with control button pressed:
                // invert selection of the current node
                List<TreeNode> addedNodes = new List<TreeNode>();
                List<TreeNode> removedNodes = new List<TreeNode>();
                if (!selectedNodes.Contains(currentNode)) {
                    addedNodes.Add(currentNode);
                    previousNode = currentNode;
                }
                else {
                    removedNodes.Add(currentNode);
                }
                changeSelection(addedNodes, removedNodes);
            }
            else if (shift && previousNode != null) {
                if (currentNode.Parent == previousNode.Parent) {
                    // the node clicked with shift button pressed:
                    // if current node and previously selected node
                    // belongs to the same parent,
                    // select range of nodes between these two
                    List<TreeNode> addedNodes = new List<TreeNode>();
                    List<TreeNode> removedNodes = new List<TreeNode>();
                    bool selection = false;
                    bool selectionEnd = false;

                    TreeNodeCollection nodes = null;
                    if (previousNode.Parent == null) {
                        nodes = treeViewMultiSelect.Nodes;
                    }
                    else {
                        nodes = previousNode.Parent.Nodes;
                    }
                    foreach (TreeNode n in nodes) {
                        if (n == currentNode || n == previousNode) {
                            if (selection) {
                                selectionEnd = true;
                            }
                            if (!selection) {
                                selection = true;
                            }
                        }
                        if (selection && !selectedNodes.Contains(n)) {
                            addedNodes.Add(n);
                        }
                        if (selectionEnd) {
                            break;
                        }
                    }

                    if (addedNodes.Count > 0) {
                        changeSelection(addedNodes, removedNodes);
                    }
                }
            }
            else {
                if (!currentNode.NodeFont.Bold) {
                    // single click:
                    // remove all selected nodes
                    // and add current node
                    List<TreeNode> addedNodes = new List<TreeNode>();
                    List<TreeNode> removedNodes = new List<TreeNode>();
                    removedNodes.AddRange(selectedNodes);
                    if (removedNodes.Contains(currentNode)) {
                        removedNodes.Remove(currentNode);
                    }
                    else {
                        addedNodes.Add(currentNode);
                    }
                    changeSelection(addedNodes, removedNodes);
                    previousNode = currentNode;
                }
            }
        }

        protected void changeSelection(List<TreeNode> addedNodes, List<TreeNode> removedNodes) {
            foreach (TreeNode n in addedNodes) {
                if (!n.NodeFont.Bold) {
                    n.BackColor = SystemColors.Highlight;
                    n.ForeColor = SystemColors.HighlightText;
                    selectedNodes.Add(n);
                }
            }
            foreach (TreeNode n in removedNodes) {
                n.BackColor = treeViewMultiSelect.BackColor;
                n.ForeColor = treeViewMultiSelect.ForeColor;
                selectedNodes.Remove(n);
            }
        }
    }
}
