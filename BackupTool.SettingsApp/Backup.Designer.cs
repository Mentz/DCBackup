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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBackupType = new System.Windows.Forms.Label();
            this.radioButtonFolders = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.listBoxSelectedItems = new System.Windows.Forms.ListBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.tabPageAgenda = new System.Windows.Forms.TabPage();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(693, 392);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.labelProfileName);
            this.tabPageConfig.Controls.Add(this.textBoxProfileName);
            this.tabPageConfig.Controls.Add(this.panel1);
            this.tabPageConfig.Controls.Add(this.buttonRemoveItem);
            this.tabPageConfig.Controls.Add(this.listBoxSelectedItems);
            this.tabPageConfig.Controls.Add(this.buttonAddItem);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(685, 366);
            this.tabPageConfig.TabIndex = 0;
            this.tabPageConfig.Text = "Configurações";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Location = new System.Drawing.Point(12, 10);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProfileName.Size = new System.Drawing.Size(104, 13);
            this.labelProfileName.TabIndex = 5;
            this.labelProfileName.Text = "Nome do perfil atual:";
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.Location = new System.Drawing.Point(118, 7);
            this.textBoxProfileName.MaxLength = 20;
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxProfileName.Size = new System.Drawing.Size(155, 20);
            this.textBoxProfileName.TabIndex = 4;
            this.textBoxProfileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProfileName_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBackupType);
            this.panel1.Controls.Add(this.radioButtonFolders);
            this.panel1.Controls.Add(this.radioButtonFiles);
            this.panel1.Location = new System.Drawing.Point(7, 96);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(137, 68);
            this.panel1.TabIndex = 0;
            // 
            // labelBackupType
            // 
            this.labelBackupType.AutoSize = true;
            this.labelBackupType.Location = new System.Drawing.Point(4, 4);
            this.labelBackupType.Name = "labelBackupType";
            this.labelBackupType.Size = new System.Drawing.Size(82, 13);
            this.labelBackupType.TabIndex = 2;
            this.labelBackupType.Text = "Tipo de backup";
            // 
            // radioButtonFolders
            // 
            this.radioButtonFolders.AutoSize = true;
            this.radioButtonFolders.Location = new System.Drawing.Point(4, 46);
            this.radioButtonFolders.Name = "radioButtonFolders";
            this.radioButtonFolders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonFolders.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFolders.TabIndex = 1;
            this.radioButtonFolders.Text = "Por pastas";
            this.radioButtonFolders.UseVisualStyleBackColor = true;
            this.radioButtonFolders.CheckedChanged += new System.EventHandler(this.radioButtonFolders_CheckedChanged);
            // 
            // radioButtonFiles
            // 
            this.radioButtonFiles.AutoSize = true;
            this.radioButtonFiles.Checked = true;
            this.radioButtonFiles.Location = new System.Drawing.Point(4, 23);
            this.radioButtonFiles.Name = "radioButtonFiles";
            this.radioButtonFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonFiles.Size = new System.Drawing.Size(84, 17);
            this.radioButtonFiles.TabIndex = 0;
            this.radioButtonFiles.TabStop = true;
            this.radioButtonFiles.Text = "Por arquivos";
            this.radioButtonFiles.UseVisualStyleBackColor = true;
            this.radioButtonFiles.CheckedChanged += new System.EventHandler(this.radioButtonFiles_CheckedChanged);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(604, 170);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveItem.TabIndex = 3;
            this.buttonRemoveItem.Text = "Remover";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // listBoxSelectedItems
            // 
            this.listBoxSelectedItems.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSelectedItems.FormattingEnabled = true;
            this.listBoxSelectedItems.Location = new System.Drawing.Point(6, 199);
            this.listBoxSelectedItems.Name = "listBoxSelectedItems";
            this.listBoxSelectedItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxSelectedItems.ScrollAlwaysVisible = true;
            this.listBoxSelectedItems.Size = new System.Drawing.Size(673, 158);
            this.listBoxSelectedItems.TabIndex = 2;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(6, 170);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(138, 23);
            this.buttonAddItem.TabIndex = 1;
            this.buttonAddItem.Text = "Adicionar itens";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // tabPageAgenda
            // 
            this.tabPageAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgenda.Name = "tabPageAgenda";
            this.tabPageAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgenda.Size = new System.Drawing.Size(685, 366);
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
            // buttonSaveProfile
            // 
            this.buttonSaveProfile.Location = new System.Drawing.Point(620, 398);
            this.buttonSaveProfile.Name = "buttonSaveProfile";
            this.buttonSaveProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveProfile.TabIndex = 1;
            this.buttonSaveProfile.Text = "Salvar";
            this.buttonSaveProfile.UseVisualStyleBackColor = true;
            this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(541, 398);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // toolTips
            // 
            this.toolTips.AutoPopDelay = 10000;
            this.toolTips.InitialDelay = 500;
            this.toolTips.IsBalloon = true;
            this.toolTips.ReshowDelay = 100;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 426);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveProfile);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar perfis de backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageAgenda;
        private System.Windows.Forms.ListBox listBoxSelectedItems;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBackupType;
        private System.Windows.Forms.RadioButton radioButtonFolders;
        private System.Windows.Forms.RadioButton radioButtonFiles;
        private System.Windows.Forms.Button buttonSaveProfile;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.TextBox textBoxProfileName;
    }
}