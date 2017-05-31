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
            this.directoryTree.ItemHeight = 20;
            this.directoryTree.Location = new System.Drawing.Point(5, 5);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(381, 405);
            this.directoryTree.TabIndex = 0;
            this.directoryTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterCheck);
            this.directoryTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.directoryTree_BeforeExpand);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "pasta1.ico");
            this.IconList.Images.SetKeyName(1, "drive.ico");
            this.IconList.Images.SetKeyName(2, "1.ico");
            this.IconList.Images.SetKeyName(3, "rede.ico");
            this.IconList.Images.SetKeyName(4, "nao.ico");
            this.IconList.Images.SetKeyName(5, "user1.ico");
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Location = new System.Drawing.Point(295, 414);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(91, 23);
            this.buttonUpdateList.TabIndex = 1;
            this.buttonUpdateList.Text = "Atualizar lista";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(216, 414);
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
            this.ClientSize = new System.Drawing.Size(391, 443);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.directoryTree);
            this.Name = "SearchDirectory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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