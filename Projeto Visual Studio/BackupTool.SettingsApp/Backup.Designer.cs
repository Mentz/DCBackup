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
            this.checkBoxDiferencial = new System.Windows.Forms.CheckBox();
            this.radioButtonFolders = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.listBoxSelectedItems = new System.Windows.Forms.ListBox();
            this.tabPageAgenda = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMinutos = new System.Windows.Forms.ComboBox();
            this.comboBoxAmPm = new System.Windows.Forms.ComboBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.panelMensal = new System.Windows.Forms.Panel();
            this.comboBoxMensal = new System.Windows.Forms.ComboBox();
            this.checkedListBoxMensal = new System.Windows.Forms.CheckedListBox();
            this.panelCustomizado = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDiaSemana = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCustomizado = new System.Windows.Forms.ComboBox();
            this.radioButtonCustomizado = new System.Windows.Forms.RadioButton();
            this.checkedListBoxSemanal = new System.Windows.Forms.CheckedListBox();
            this.radioButtonSemanal = new System.Windows.Forms.RadioButton();
            this.RadiobuttonMensal = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.buttonNextTab = new System.Windows.Forms.Button();
            this.buttonBackTab = new System.Windows.Forms.Button();
            this.buttonSaveProfile = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSemanal = new System.Windows.Forms.Panel();
            this.BackupTabControl.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageAgenda.SuspendLayout();
            this.panelMensal.SuspendLayout();
            this.panelCustomizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSemanal.SuspendLayout();
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
            this.tabPageAgenda.Controls.Add(this.panelSemanal);
            this.tabPageAgenda.Controls.Add(this.panel2);
            this.tabPageAgenda.Controls.Add(this.panelMensal);
            this.tabPageAgenda.Controls.Add(this.pictureBox5);
            this.tabPageAgenda.Controls.Add(this.panelCustomizado);
            this.tabPageAgenda.Controls.Add(this.radioButtonCustomizado);
            this.tabPageAgenda.Controls.Add(this.pictureBox4);
            this.tabPageAgenda.Controls.Add(this.pictureBox3);
            this.tabPageAgenda.Controls.Add(this.radioButtonSemanal);
            this.tabPageAgenda.Controls.Add(this.RadiobuttonMensal);
            this.tabPageAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgenda.Name = "tabPageAgenda";
            this.tabPageAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgenda.Size = new System.Drawing.Size(726, 341);
            this.tabPageAgenda.TabIndex = 1;
            this.tabPageAgenda.Text = "Agendamento";
            this.tabPageAgenda.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = ":";
            // 
            // comboBoxMinutos
            // 
            this.comboBoxMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutos.FormattingEnabled = true;
            this.comboBoxMinutos.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxMinutos.Location = new System.Drawing.Point(349, 47);
            this.comboBoxMinutos.Name = "comboBoxMinutos";
            this.comboBoxMinutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxMinutos.Size = new System.Drawing.Size(47, 21);
            this.comboBoxMinutos.TabIndex = 17;
            this.comboBoxMinutos.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBoxAmPm
            // 
            this.comboBoxAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmPm.FormattingEnabled = true;
            this.comboBoxAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBoxAmPm.Location = new System.Drawing.Point(402, 47);
            this.comboBoxAmPm.Name = "comboBoxAmPm";
            this.comboBoxAmPm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxAmPm.Size = new System.Drawing.Size(41, 21);
            this.comboBoxAmPm.TabIndex = 16;
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
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
            "12"});
            this.comboBoxHora.Location = new System.Drawing.Point(293, 47);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxHora.Size = new System.Drawing.Size(47, 21);
            this.comboBoxHora.TabIndex = 15;
            // 
            // panelMensal
            // 
            this.panelMensal.Controls.Add(this.comboBoxMensal);
            this.panelMensal.Controls.Add(this.checkedListBoxMensal);
            this.panelMensal.Enabled = false;
            this.panelMensal.Location = new System.Drawing.Point(182, 47);
            this.panelMensal.Name = "panelMensal";
            this.panelMensal.Size = new System.Drawing.Size(168, 187);
            this.panelMensal.TabIndex = 15;
            // 
            // comboBoxMensal
            // 
            this.comboBoxMensal.AutoCompleteCustomSource.AddRange(new string[] {
            "Primeiro",
            "Segundo",
            "Terceiro",
            "Quarto",
            "Último"});
            this.comboBoxMensal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMensal.FormattingEnabled = true;
            this.comboBoxMensal.Items.AddRange(new object[] {
            "Todo mês",
            "A cada 2 meses",
            "A cada 3 meses",
            "A cada 6 meses"});
            this.comboBoxMensal.Location = new System.Drawing.Point(0, 160);
            this.comboBoxMensal.Name = "comboBoxMensal";
            this.comboBoxMensal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxMensal.Size = new System.Drawing.Size(168, 21);
            this.comboBoxMensal.TabIndex = 14;
            this.comboBoxMensal.TabStop = false;
            // 
            // checkedListBoxMensal
            // 
            this.checkedListBoxMensal.CheckOnClick = true;
            this.checkedListBoxMensal.ColumnWidth = 40;
            this.checkedListBoxMensal.FormattingEnabled = true;
            this.checkedListBoxMensal.Items.AddRange(new object[] {
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
            this.checkedListBoxMensal.Location = new System.Drawing.Point(2, 0);
            this.checkedListBoxMensal.MultiColumn = true;
            this.checkedListBoxMensal.Name = "checkedListBoxMensal";
            this.checkedListBoxMensal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBoxMensal.Size = new System.Drawing.Size(166, 154);
            this.checkedListBoxMensal.TabIndex = 3;
            // 
            // panelCustomizado
            // 
            this.panelCustomizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomizado.Controls.Add(this.label3);
            this.panelCustomizado.Controls.Add(this.comboBoxDiaSemana);
            this.panelCustomizado.Controls.Add(this.label2);
            this.panelCustomizado.Controls.Add(this.comboBoxCustomizado);
            this.panelCustomizado.Enabled = false;
            this.panelCustomizado.Location = new System.Drawing.Point(356, 47);
            this.panelCustomizado.Name = "panelCustomizado";
            this.panelCustomizado.Size = new System.Drawing.Size(364, 181);
            this.panelCustomizado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "do mês";
            // 
            // comboBoxDiaSemana
            // 
            this.comboBoxDiaSemana.AutoCompleteCustomSource.AddRange(new string[] {
            "Primeiro",
            "Segundo",
            "Terceiro",
            "Quarto",
            "Último"});
            this.comboBoxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiaSemana.FormattingEnabled = true;
            this.comboBoxDiaSemana.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quita-Feira",
            "Sexta-Feira",
            "Sábado",
            "Domingo"});
            this.comboBoxDiaSemana.Location = new System.Drawing.Point(163, 82);
            this.comboBoxDiaSemana.Name = "comboBoxDiaSemana";
            this.comboBoxDiaSemana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDiaSemana.Size = new System.Drawing.Size(122, 21);
            this.comboBoxDiaSemana.TabIndex = 12;
            this.comboBoxDiaSemana.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "A cada";
            // 
            // comboBoxCustomizado
            // 
            this.comboBoxCustomizado.AutoCompleteCustomSource.AddRange(new string[] {
            "Primeiro",
            "Segundo",
            "Terceiro",
            "Quarto",
            "Último"});
            this.comboBoxCustomizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomizado.FormattingEnabled = true;
            this.comboBoxCustomizado.Items.AddRange(new object[] {
            "Segundo",
            "Primeiro",
            "Terceiro",
            "Quarto",
            "Ultimo"});
            this.comboBoxCustomizado.Location = new System.Drawing.Point(35, 82);
            this.comboBoxCustomizado.Name = "comboBoxCustomizado";
            this.comboBoxCustomizado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCustomizado.Size = new System.Drawing.Size(122, 21);
            this.comboBoxCustomizado.TabIndex = 10;
            this.comboBoxCustomizado.TabStop = false;
            // 
            // radioButtonCustomizado
            // 
            this.radioButtonCustomizado.AutoSize = true;
            this.radioButtonCustomizado.Location = new System.Drawing.Point(392, 24);
            this.radioButtonCustomizado.Name = "radioButtonCustomizado";
            this.radioButtonCustomizado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonCustomizado.Size = new System.Drawing.Size(128, 17);
            this.radioButtonCustomizado.TabIndex = 7;
            this.radioButtonCustomizado.Text = "Intervalo customizado";
            this.radioButtonCustomizado.UseVisualStyleBackColor = true;
            this.radioButtonCustomizado.CheckedChanged += new System.EventHandler(this.radioButtonCustomizado_CheckedChanged);
            // 
            // checkedListBoxSemanal
            // 
            this.checkedListBoxSemanal.CheckOnClick = true;
            this.checkedListBoxSemanal.FormattingEnabled = true;
            this.checkedListBoxSemanal.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quita-feira",
            "Sexta-feira",
            "Sábado",
            "Domingo"});
            this.checkedListBoxSemanal.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxSemanal.Name = "checkedListBoxSemanal";
            this.checkedListBoxSemanal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBoxSemanal.Size = new System.Drawing.Size(172, 184);
            this.checkedListBoxSemanal.TabIndex = 4;
            // 
            // radioButtonSemanal
            // 
            this.radioButtonSemanal.AutoSize = true;
            this.radioButtonSemanal.Checked = true;
            this.radioButtonSemanal.Location = new System.Drawing.Point(42, 24);
            this.radioButtonSemanal.Name = "radioButtonSemanal";
            this.radioButtonSemanal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonSemanal.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSemanal.TabIndex = 0;
            this.radioButtonSemanal.TabStop = true;
            this.radioButtonSemanal.Text = "Semanal";
            this.radioButtonSemanal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonSemanal.UseVisualStyleBackColor = true;
            this.radioButtonSemanal.CheckedChanged += new System.EventHandler(this.radioButtonSemanal_CheckedChanged);
            // 
            // RadiobuttonMensal
            // 
            this.RadiobuttonMensal.AutoSize = true;
            this.RadiobuttonMensal.Location = new System.Drawing.Point(218, 24);
            this.RadiobuttonMensal.Name = "RadiobuttonMensal";
            this.RadiobuttonMensal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadiobuttonMensal.Size = new System.Drawing.Size(59, 17);
            this.RadiobuttonMensal.TabIndex = 1;
            this.RadiobuttonMensal.Text = "Mensal";
            this.RadiobuttonMensal.UseVisualStyleBackColor = true;
            this.RadiobuttonMensal.CheckedChanged += new System.EventHandler(this.RadiobuttonMensal_CheckedChanged);
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
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Clock_30;
            this.pictureBox6.Location = new System.Drawing.Point(249, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Edit_Property_30;
            this.pictureBox5.InitialImage = global::BackupTool.SettingsApp.Properties.Resources.icons8_Edit_30;
            this.pictureBox5.Location = new System.Drawing.Point(356, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Calendar_31_301;
            this.pictureBox4.Location = new System.Drawing.Point(184, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BackupTool.SettingsApp.Properties.Resources.icons8_Calendar_31_302;
            this.pictureBox3.Location = new System.Drawing.Point(6, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Horário de execução do Backup";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxHora);
            this.panel2.Controls.Add(this.comboBoxMinutos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.comboBoxAmPm);
            this.panel2.Location = new System.Drawing.Point(6, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 98);
            this.panel2.TabIndex = 22;
            // 
            // panelSemanal
            // 
            this.panelSemanal.Controls.Add(this.checkedListBoxSemanal);
            this.panelSemanal.Location = new System.Drawing.Point(6, 47);
            this.panelSemanal.Name = "panelSemanal";
            this.panelSemanal.Size = new System.Drawing.Size(174, 186);
            this.panelSemanal.TabIndex = 23;
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
            this.panelMensal.ResumeLayout(false);
            this.panelCustomizado.ResumeLayout(false);
            this.panelCustomizado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSemanal.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton radioButtonSemanal;
        private System.Windows.Forms.RadioButton RadiobuttonMensal;
        private System.Windows.Forms.CheckedListBox checkedListBoxMensal;
        private System.Windows.Forms.CheckedListBox checkedListBoxSemanal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButtonCustomizado;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panelCustomizado;
        private System.Windows.Forms.ComboBox comboBoxCustomizado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDiaSemana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMensal;
        private System.Windows.Forms.Panel panelMensal;
        private System.Windows.Forms.ComboBox comboBoxAmPm;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMinutos;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSemanal;
    }
}