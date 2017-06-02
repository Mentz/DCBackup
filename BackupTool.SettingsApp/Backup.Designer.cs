namespace BackupTool.SettingsApp {
    partial class Backup {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelBackupType = new System.Windows.Forms.Label();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonFolders = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.listBoxSelectedItems = new System.Windows.Forms.ListBox();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.tabPageAgenda = new System.Windows.Forms.TabPage();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Controls.Add(this.tabPageAgenda);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 367);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.label1);
            this.tabPageConfig.Controls.Add(this.buttonAddFile);
            this.tabPageConfig.Controls.Add(this.pictureBox2);
            this.tabPageConfig.Controls.Add(this.labelBackupType);
            this.tabPageConfig.Controls.Add(this.labelProfileName);
            this.tabPageConfig.Controls.Add(this.textBoxProfileName);
            this.tabPageConfig.Controls.Add(this.panel1);
            this.tabPageConfig.Controls.Add(this.buttonRemoveItem);
            this.tabPageConfig.Controls.Add(this.listBoxSelectedItems);
            this.tabPageConfig.Controls.Add(this.buttonAddFolder);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(726, 341);
            this.tabPageConfig.TabIndex = 0;
            this.tabPageConfig.Text = "Configurações";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dois cliques em item selecionado abrirá local do arquivo";
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Add_File_40;
            this.buttonAddFile.Location = new System.Drawing.Point(206, 43);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(64, 66);
            this.buttonAddFile.TabIndex = 6;
            this.toolTips.SetToolTip(this.buttonAddFile, "Adicionar arquivo");
            this.buttonAddFile.UseCompatibleTextRendering = true;
            this.buttonAddFile.UseVisualStyleBackColor = false;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Light_On_16;
            this.pictureBox2.Location = new System.Drawing.Point(5, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 19);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelBackupType
            // 
            this.labelBackupType.AutoSize = true;
            this.labelBackupType.Location = new System.Drawing.Point(3, 42);
            this.labelBackupType.Name = "labelBackupType";
            this.labelBackupType.Size = new System.Drawing.Size(82, 13);
            this.labelBackupType.TabIndex = 2;
            this.labelBackupType.Text = "Tipo de backup";
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Location = new System.Drawing.Point(3, 3);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProfileName.Size = new System.Drawing.Size(75, 13);
            this.labelProfileName.TabIndex = 5;
            this.labelProfileName.Text = "Nome do perfil";
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.Location = new System.Drawing.Point(5, 19);
            this.textBoxProfileName.MaxLength = 20;
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxProfileName.Size = new System.Drawing.Size(265, 20);
            this.textBoxProfileName.TabIndex = 4;
            this.textBoxProfileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProfileName_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.radioButtonFolders);
            this.panel1.Controls.Add(this.radioButtonFiles);
            this.panel1.Location = new System.Drawing.Point(5, 56);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(125, 52);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonFolders
            // 
            this.radioButtonFolders.AutoSize = true;
            this.radioButtonFolders.Location = new System.Drawing.Point(54, 26);
            this.radioButtonFolders.Name = "radioButtonFolders";
            this.radioButtonFolders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonFolders.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFolders.TabIndex = 1;
            this.radioButtonFolders.Text = "Pastas";
            this.radioButtonFolders.UseVisualStyleBackColor = true;
            this.radioButtonFolders.CheckedChanged += new System.EventHandler(this.radioButtonFolders_CheckedChanged);
            // 
            // radioButtonFiles
            // 
            this.radioButtonFiles.AutoSize = true;
            this.radioButtonFiles.Checked = true;
            this.radioButtonFiles.Location = new System.Drawing.Point(54, 10);
            this.radioButtonFiles.Name = "radioButtonFiles";
            this.radioButtonFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonFiles.Size = new System.Drawing.Size(66, 17);
            this.radioButtonFiles.TabIndex = 0;
            this.radioButtonFiles.TabStop = true;
            this.radioButtonFiles.Text = "Arquivos";
            this.radioButtonFiles.UseVisualStyleBackColor = true;
            this.radioButtonFiles.CheckedChanged += new System.EventHandler(this.radioButtonFiles_CheckedChanged);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Image = global::BackupTool.SettingsApp.Properties.Resources.Excluir_40__1_;
            this.buttonRemoveItem.Location = new System.Drawing.Point(655, 41);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(64, 67);
            this.buttonRemoveItem.TabIndex = 3;
            this.toolTips.SetToolTip(this.buttonRemoveItem, "Remover item");
            this.buttonRemoveItem.UseMnemonic = false;
            this.buttonRemoveItem.UseVisualStyleBackColor = false;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // listBoxSelectedItems
            // 
            this.listBoxSelectedItems.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSelectedItems.FormattingEnabled = true;
            this.listBoxSelectedItems.Location = new System.Drawing.Point(5, 115);
            this.listBoxSelectedItems.Name = "listBoxSelectedItems";
            this.listBoxSelectedItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxSelectedItems.ScrollAlwaysVisible = true;
            this.listBoxSelectedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelectedItems.Size = new System.Drawing.Size(714, 197);
            this.listBoxSelectedItems.TabIndex = 2;
            this.listBoxSelectedItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSelectedItems_MouseDoubleClick);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Enabled = false;
            this.buttonAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFolder.Image")));
            this.buttonAddFolder.Location = new System.Drawing.Point(136, 43);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(64, 66);
            this.buttonAddFolder.TabIndex = 1;
            this.toolTips.SetToolTip(this.buttonAddFolder, "Adicionar pasta");
            this.buttonAddFolder.UseCompatibleTextRendering = true;
            this.buttonAddFolder.UseVisualStyleBackColor = false;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // tabPageAgenda
            // 
            this.tabPageAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgenda.Name = "tabPageAgenda";
            this.tabPageAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgenda.Size = new System.Drawing.Size(726, 351);
            this.tabPageAgenda.TabIndex = 1;
            this.tabPageAgenda.Text = "Agendamento";
            this.tabPageAgenda.UseVisualStyleBackColor = true;
            // 
            // FolderDialog
            // 
            this.FolderDialog.ShowNewFolderButton = false;
            // 
            // FileDialog
            // 
            this.FileDialog.Multiselect = true;
            // 
            // toolTips
            // 
            this.toolTips.AutoPopDelay = 10000;
            this.toolTips.InitialDelay = 500;
            this.toolTips.IsBalloon = true;
            this.toolTips.ReshowDelay = 100;
            // 
            // buttonSaveProfile
            // 
            this.buttonSaveProfile.Image = global::BackupTool.SettingsApp.Properties.Resources.Salvar_e_fechar_40;
            this.buttonSaveProfile.Location = new System.Drawing.Point(671, 374);
            this.buttonSaveProfile.Name = "buttonSaveProfile";
            this.buttonSaveProfile.Size = new System.Drawing.Size(64, 67);
            this.buttonSaveProfile.TabIndex = 1;
            this.toolTips.SetToolTip(this.buttonSaveProfile, "Salvar configuração e sair");
            this.buttonSaveProfile.UseVisualStyleBackColor = true;
            this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 446);
            this.Controls.Add(this.buttonSaveProfile);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageAgenda;
        private System.Windows.Forms.ListBox listBoxSelectedItems;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBackupType;
        private System.Windows.Forms.RadioButton radioButtonFolders;
        private System.Windows.Forms.RadioButton radioButtonFiles;
        private System.Windows.Forms.Button buttonSaveProfile;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}