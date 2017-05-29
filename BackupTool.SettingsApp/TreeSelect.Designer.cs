namespace BackupTool.SettingsApp {
    partial class TreeSelect {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.treeViewMultiSelect = new System.Windows.Forms.TreeView();
            this.buttonTreeViewConfirm = new System.Windows.Forms.Button();
            this.buttonTreeViewCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewMultiSelect
            // 
            this.treeViewMultiSelect.Location = new System.Drawing.Point(5, 5);
            this.treeViewMultiSelect.Name = "treeViewMultiSelect";
            this.treeViewMultiSelect.Size = new System.Drawing.Size(389, 384);
            this.treeViewMultiSelect.TabIndex = 0;
            this.treeViewMultiSelect.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewMultiSelect_BeforeExpand);
            this.treeViewMultiSelect.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewMultiSelect_BeforeSelect);
            this.treeViewMultiSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewMultiSelect_MouseDown);
            // 
            // buttonTreeViewConfirm
            // 
            this.buttonTreeViewConfirm.Location = new System.Drawing.Point(320, 394);
            this.buttonTreeViewConfirm.Name = "buttonTreeViewConfirm";
            this.buttonTreeViewConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonTreeViewConfirm.TabIndex = 1;
            this.buttonTreeViewConfirm.Text = "Confirmar";
            this.buttonTreeViewConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonTreeViewCancel
            // 
            this.buttonTreeViewCancel.Location = new System.Drawing.Point(239, 394);
            this.buttonTreeViewCancel.Name = "buttonTreeViewCancel";
            this.buttonTreeViewCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonTreeViewCancel.TabIndex = 2;
            this.buttonTreeViewCancel.Text = "Cancelar";
            this.buttonTreeViewCancel.UseVisualStyleBackColor = true;
            this.buttonTreeViewCancel.Click += new System.EventHandler(this.buttonTreeViewCancel_Click);
            // 
            // TreeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 422);
            this.Controls.Add(this.buttonTreeViewCancel);
            this.Controls.Add(this.buttonTreeViewConfirm);
            this.Controls.Add(this.treeViewMultiSelect);
            this.Name = "TreeSelect";
            this.Text = "TreeSelect";
            this.Shown += new System.EventHandler(this.TreeSelect_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMultiSelect;
        private System.Windows.Forms.Button buttonTreeViewConfirm;
        private System.Windows.Forms.Button buttonTreeViewCancel;
    }
}