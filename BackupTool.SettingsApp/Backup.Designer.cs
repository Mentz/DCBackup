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
            this.BackupTabControl = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBackupType = new System.Windows.Forms.Label();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonFolders = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.listBoxSelectedItems = new System.Windows.Forms.ListBox();
            this.tabPageAgenda = new System.Windows.Forms.TabPage();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxDiferencial = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Mensal = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNextTab = new System.Windows.Forms.Button();
            this.buttonBackTab = new System.Windows.Forms.Button();
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BackupTabControl.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageAgenda.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BackupTabControl
            // 
            this.BackupTabControl.Controls.Add(this.tabPageConfig);
            this.BackupTabControl.Controls.Add(this.tabPageAgenda);
            this.BackupTabControl.Controls.Add(this.tabPage1);
            this.BackupTabControl.Location = new System.Drawing.Point(5, 5);
            this.BackupTabControl.Name = "BackupTabControl";
            this.BackupTabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BackupTabControl.SelectedIndex = 0;
            this.BackupTabControl.Size = new System.Drawing.Size(734, 367);
            this.BackupTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.BackupTabControl.TabIndex = 0;
            this.BackupTabControl.SelectedIndexChanged += new System.EventHandler(this.BackupTabControl_SelectedIndexChanged_1);
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
            this.textBoxProfileName.Size = new System.Drawing.Size(283, 20);
            this.textBoxProfileName.TabIndex = 4;
            this.textBoxProfileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProfileName_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxDiferencial);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.radioButtonFolders);
            this.panel1.Controls.Add(this.radioButtonFiles);
            this.panel1.Location = new System.Drawing.Point(5, 57);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(143, 66);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonFolders
            // 
            this.radioButtonFolders.AutoSize = true;
            this.radioButtonFolders.Location = new System.Drawing.Point(54, 23);
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
            this.radioButtonFiles.Location = new System.Drawing.Point(54, 7);
            this.radioButtonFiles.Name = "radioButtonFiles";
            this.radioButtonFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonFiles.Size = new System.Drawing.Size(66, 17);
            this.radioButtonFiles.TabIndex = 0;
            this.radioButtonFiles.TabStop = true;
            this.radioButtonFiles.Text = "Arquivos";
            this.radioButtonFiles.UseVisualStyleBackColor = true;
            this.radioButtonFiles.CheckedChanged += new System.EventHandler(this.radioButtonFiles_CheckedChanged);
            // 
            // listBoxSelectedItems
            // 
            this.listBoxSelectedItems.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSelectedItems.FormattingEnabled = true;
            this.listBoxSelectedItems.Location = new System.Drawing.Point(5, 128);
            this.listBoxSelectedItems.Name = "listBoxSelectedItems";
            this.listBoxSelectedItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxSelectedItems.ScrollAlwaysVisible = true;
            this.listBoxSelectedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelectedItems.Size = new System.Drawing.Size(714, 184);
            this.listBoxSelectedItems.TabIndex = 2;
            this.listBoxSelectedItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSelectedItems_MouseDoubleClick);
            // 
            // tabPageAgenda
            // 
            this.tabPageAgenda.Controls.Add(this.pictureBox5);
            this.tabPageAgenda.Controls.Add(this.panel2);
            this.tabPageAgenda.Controls.Add(this.radioButton2);
            this.tabPageAgenda.Controls.Add(this.pictureBox4);
            this.tabPageAgenda.Controls.Add(this.pictureBox3);
            this.tabPageAgenda.Controls.Add(this.checkedListBox2);
            this.tabPageAgenda.Controls.Add(this.radioButton1);
            this.tabPageAgenda.Controls.Add(this.checkedListBox1);
            this.tabPageAgenda.Controls.Add(this.Mensal);
            this.tabPageAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgenda.Name = "tabPageAgenda";
            this.tabPageAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgenda.Size = new System.Drawing.Size(726, 341);
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
            // checkBoxDiferencial
            // 
            this.checkBoxDiferencial.AutoSize = true;
            this.checkBoxDiferencial.Enabled = false;
            this.checkBoxDiferencial.Location = new System.Drawing.Point(54, 40);
            this.checkBoxDiferencial.Name = "checkBoxDiferencial";
            this.checkBoxDiferencial.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDiferencial.TabIndex = 4;
            this.checkBoxDiferencial.Text = "Diferencial";
            this.toolTips.SetToolTip(this.checkBoxDiferencial, "Irá atualizar o backup com o novos arquivos da pasta selecionada");
            this.checkBoxDiferencial.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Semanal";
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Mensal
            // 
            this.Mensal.AutoSize = true;
            this.Mensal.Location = new System.Drawing.Point(218, 12);
            this.Mensal.Name = "Mensal";
            this.Mensal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mensal.Size = new System.Drawing.Size(59, 17);
            this.Mensal.TabIndex = 1;
            this.Mensal.Text = "Mensal";
            this.Mensal.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 40;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.checkedListBox1.Location = new System.Drawing.Point(184, 35);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(166, 154);
            this.checkedListBox1.TabIndex = 3;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quita-feira",
            "Sexta-feira",
            "Sábado",
            "Domingo"});
            this.checkedListBox2.Location = new System.Drawing.Point(6, 35);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox2.Size = new System.Drawing.Size(172, 154);
            this.checkedListBox2.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(726, 341);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(392, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton2.Size = new System.Drawing.Size(128, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Intervalo customizado";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(356, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 154);
            this.panel2.TabIndex = 8;
            // 
            // buttonNextTab
            // 
            this.buttonNextTab.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Arrow_30;
            this.buttonNextTab.Location = new System.Drawing.Point(75, 374);
            this.buttonNextTab.Name = "buttonNextTab";
            this.buttonNextTab.Size = new System.Drawing.Size(64, 67);
            this.buttonNextTab.TabIndex = 3;
            this.toolTips.SetToolTip(this.buttonNextTab, "Prosseguir");
            this.buttonNextTab.UseVisualStyleBackColor = true;
            this.buttonNextTab.Click += new System.EventHandler(this.buttonNextTab_Click);
            // 
            // buttonBackTab
            // 
            this.buttonBackTab.Enabled = false;
            this.buttonBackTab.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Arrow_31;
            this.buttonBackTab.Location = new System.Drawing.Point(5, 374);
            this.buttonBackTab.Name = "buttonBackTab";
            this.buttonBackTab.Size = new System.Drawing.Size(64, 67);
            this.buttonBackTab.TabIndex = 2;
            this.toolTips.SetToolTip(this.buttonBackTab, "Recuar");
            this.buttonBackTab.UseVisualStyleBackColor = true;
            this.buttonBackTab.Click += new System.EventHandler(this.buttonBackTab_Click);
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
            // buttonAddFile
            // 
            this.buttonAddFile.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Add_File_40;
            this.buttonAddFile.Location = new System.Drawing.Point(154, 57);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Image = global::BackupTool.SettingsApp.Properties.Resources.Excluir_40__1_;
            this.buttonRemoveItem.Location = new System.Drawing.Point(655, 56);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(64, 67);
            this.buttonRemoveItem.TabIndex = 3;
            this.toolTips.SetToolTip(this.buttonRemoveItem, "Remover item");
            this.buttonRemoveItem.UseMnemonic = false;
            this.buttonRemoveItem.UseVisualStyleBackColor = false;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Enabled = false;
            this.buttonAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFolder.Image")));
            this.buttonAddFolder.Location = new System.Drawing.Point(224, 57);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(64, 66);
            this.buttonAddFolder.TabIndex = 1;
            this.toolTips.SetToolTip(this.buttonAddFolder, "Adicionar pasta");
            this.buttonAddFolder.UseCompatibleTextRendering = true;
            this.buttonAddFolder.UseVisualStyleBackColor = false;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Edit_Property_30;
            this.pictureBox5.InitialImage = global::BackupTool.SettingsApp.Properties.Resources.icons8_Edit_30;
            this.pictureBox5.Location = new System.Drawing.Point(356, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Calendar_31_30;
            this.pictureBox4.Location = new System.Drawing.Point(182, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Calendar_7_30;
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 446);
            this.Controls.Add(this.buttonNextTab);
            this.Controls.Add(this.buttonBackTab);
            this.Controls.Add(this.buttonSaveProfile);
            this.Controls.Add(this.BackupTabControl);
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.BackupTabControl.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageAgenda.ResumeLayout(false);
            this.tabPageAgenda.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BackupTabControl;
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
        private System.Windows.Forms.Button buttonBackTab;
        private System.Windows.Forms.Button buttonNextTab;
        private System.Windows.Forms.CheckBox checkBoxDiferencial;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Mensal;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}