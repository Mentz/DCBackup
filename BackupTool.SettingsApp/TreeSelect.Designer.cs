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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeSelect));
            this.treeViewMultiSelect = new System.Windows.Forms.TreeView();
            this.buttonTreeViewConfirm = new System.Windows.Forms.Button();
            this.buttonTreeViewCancel = new System.Windows.Forms.Button();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeViewMultiSelect
            // 
            this.treeViewMultiSelect.CheckBoxes = true;
            this.treeViewMultiSelect.Location = new System.Drawing.Point(5, 5);
            this.treeViewMultiSelect.Name = "treeViewMultiSelect";
            this.treeViewMultiSelect.Size = new System.Drawing.Size(389, 384);
            this.treeViewMultiSelect.TabIndex = 0;
            this.treeViewMultiSelect.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewMultiSelect_BeforeCheck);
            this.treeViewMultiSelect.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewMultiSelect_BeforeExpand);
            // 
            // buttonTreeViewConfirm
            // 
            this.buttonTreeViewConfirm.Location = new System.Drawing.Point(246, 394);
            this.buttonTreeViewConfirm.Name = "buttonTreeViewConfirm";
            this.buttonTreeViewConfirm.Size = new System.Drawing.Size(148, 23);
            this.buttonTreeViewConfirm.TabIndex = 1;
            this.buttonTreeViewConfirm.Text = "Adicionar selecionados";
            this.buttonTreeViewConfirm.UseVisualStyleBackColor = true;
            this.buttonTreeViewConfirm.Click += new System.EventHandler(this.buttonTreeViewConfirm_Click);
            // 
            // buttonTreeViewCancel
            // 
            this.buttonTreeViewCancel.Location = new System.Drawing.Point(167, 394);
            this.buttonTreeViewCancel.Name = "buttonTreeViewCancel";
            this.buttonTreeViewCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonTreeViewCancel.TabIndex = 2;
            this.buttonTreeViewCancel.Text = "Cancelar";
            this.buttonTreeViewCancel.UseVisualStyleBackColor = true;
            this.buttonTreeViewCancel.Click += new System.EventHandler(this.buttonTreeViewCancel_Click);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "folder1.png");
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
        private System.Windows.Forms.ImageList IconList;
    }
}