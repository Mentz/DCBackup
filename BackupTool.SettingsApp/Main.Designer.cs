namespace DC_Backup_Tool___Settings {
    partial class Main {
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
            this.mainAppPanel = new System.Windows.Forms.Panel();
            this.listBackupProfiles = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainAppPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBackupProfiles)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainAppPanel
            // 
            this.mainAppPanel.Controls.Add(this.listBackupProfiles);
            this.mainAppPanel.Location = new System.Drawing.Point(5, 27);
            this.mainAppPanel.Name = "mainAppPanel";
            this.mainAppPanel.Size = new System.Drawing.Size(960, 578);
            this.mainAppPanel.TabIndex = 0;
            // 
            // listBackupProfiles
            // 
            this.listBackupProfiles.AllowUserToAddRows = false;
            this.listBackupProfiles.AllowUserToDeleteRows = false;
            this.listBackupProfiles.AllowUserToResizeColumns = false;
            this.listBackupProfiles.AllowUserToResizeRows = false;
            this.listBackupProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listBackupProfiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listBackupProfiles.CausesValidation = false;
            this.listBackupProfiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listBackupProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBackupProfiles.Location = new System.Drawing.Point(5, 5);
            this.listBackupProfiles.Name = "listBackupProfiles";
            this.listBackupProfiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listBackupProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listBackupProfiles.ShowCellErrors = false;
            this.listBackupProfiles.ShowCellToolTips = false;
            this.listBackupProfiles.ShowEditingIcon = false;
            this.listBackupProfiles.ShowRowErrors = false;
            this.listBackupProfiles.Size = new System.Drawing.Size(950, 242);
            this.listBackupProfiles.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarBackupsToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // configurarBackupsToolStripMenuItem
            // 
            this.configurarBackupsToolStripMenuItem.Name = "configurarBackupsToolStripMenuItem";
            this.configurarBackupsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.configurarBackupsToolStripMenuItem.Text = "Configurar backups";
            this.configurarBackupsToolStripMenuItem.Click += new System.EventHandler(this.configurarBackupsToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 610);
            this.Controls.Add(this.mainAppPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DC Backup Tool";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.mainAppPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBackupProfiles)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainAppPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarBackupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.DataGridView listBackupProfiles;
    }
}

