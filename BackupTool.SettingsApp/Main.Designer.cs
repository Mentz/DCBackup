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
            this.labelBackupsConfigurados = new System.Windows.Forms.Label();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonAddProfile = new System.Windows.Forms.Button();
            this.buttonRemoveProfile = new System.Windows.Forms.Button();
            this.mainAppPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBackupProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // mainAppPanel
            // 
            this.mainAppPanel.Controls.Add(this.buttonRemoveProfile);
            this.mainAppPanel.Controls.Add(this.buttonAddProfile);
            this.mainAppPanel.Controls.Add(this.buttonEditProfile);
            this.mainAppPanel.Controls.Add(this.labelBackupsConfigurados);
            this.mainAppPanel.Controls.Add(this.listBackupProfiles);
            this.mainAppPanel.Location = new System.Drawing.Point(5, 5);
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
            this.listBackupProfiles.Location = new System.Drawing.Point(5, 21);
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
            // labelBackupsConfigurados
            // 
            this.labelBackupsConfigurados.AutoSize = true;
            this.labelBackupsConfigurados.Location = new System.Drawing.Point(8, 4);
            this.labelBackupsConfigurados.Name = "labelBackupsConfigurados";
            this.labelBackupsConfigurados.Size = new System.Drawing.Size(113, 13);
            this.labelBackupsConfigurados.TabIndex = 1;
            this.labelBackupsConfigurados.Text = "Backups configurados";
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Location = new System.Drawing.Point(863, 270);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(91, 23);
            this.buttonEditProfile.TabIndex = 2;
            this.buttonEditProfile.Text = "Editar backup";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            // 
            // buttonAddProfile
            // 
            this.buttonAddProfile.Location = new System.Drawing.Point(762, 270);
            this.buttonAddProfile.Name = "buttonAddProfile";
            this.buttonAddProfile.Size = new System.Drawing.Size(95, 23);
            this.buttonAddProfile.TabIndex = 3;
            this.buttonAddProfile.Text = "Novo backup";
            this.buttonAddProfile.UseVisualStyleBackColor = true;
            this.buttonAddProfile.Click += new System.EventHandler(this.buttonAddProfile_Click);
            // 
            // buttonRemoveProfile
            // 
            this.buttonRemoveProfile.Location = new System.Drawing.Point(5, 270);
            this.buttonRemoveProfile.Name = "buttonRemoveProfile";
            this.buttonRemoveProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveProfile.TabIndex = 4;
            this.buttonRemoveProfile.Text = "Remover";
            this.buttonRemoveProfile.UseVisualStyleBackColor = true;
            this.buttonRemoveProfile.Click += new System.EventHandler(this.buttonRemoveProfile_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 610);
            this.Controls.Add(this.mainAppPanel);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DC Backup Tool";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.mainAppPanel.ResumeLayout(false);
            this.mainAppPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBackupProfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainAppPanel;
        private System.Windows.Forms.DataGridView listBackupProfiles;
        private System.Windows.Forms.Label labelBackupsConfigurados;
        private System.Windows.Forms.Button buttonRemoveProfile;
        private System.Windows.Forms.Button buttonAddProfile;
        private System.Windows.Forms.Button buttonEditProfile;
    }
}

