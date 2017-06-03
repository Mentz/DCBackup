namespace BackupTool.SettingsApp
{
    partial class SearchDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDirectory));
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directoryTree
            // 
            this.directoryTree.CheckBoxes = true;
            this.directoryTree.HideSelection = false;
            this.directoryTree.ImageIndex = 2;
            this.directoryTree.ImageList = this.IconList;
            this.directoryTree.ImeMode = System.Windows.Forms.ImeMode.On;
            this.directoryTree.ItemHeight = 20;
            this.directoryTree.Location = new System.Drawing.Point(12, 12);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(367, 397);
            this.directoryTree.TabIndex = 0;
            this.directoryTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterCheck);
            this.directoryTree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.directoryTree_BeforeCollapse);
            this.directoryTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.directoryTree_BeforeExpand);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "Root");
            this.IconList.Images.SetKeyName(1, "OpenFolder");
            this.IconList.Images.SetKeyName(2, "Fixed");
            this.IconList.Images.SetKeyName(3, "CDRom");
            this.IconList.Images.SetKeyName(4, "Network");
            this.IconList.Images.SetKeyName(5, "UnkownFolder");
            this.IconList.Images.SetKeyName(6, "estrela");
            this.IconList.Images.SetKeyName(7, "Personal");
            this.IconList.Images.SetKeyName(8, "Removable");
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Location = new System.Drawing.Point(289, 414);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(91, 23);
            this.buttonUpdateList.TabIndex = 1;
            this.buttonUpdateList.Text = "Atualizar lista";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(210, 414);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SearchDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(391, 448);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.directoryTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SearchDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchDirectory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.Button buttonUpdateList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ImageList IconList;
    }
}