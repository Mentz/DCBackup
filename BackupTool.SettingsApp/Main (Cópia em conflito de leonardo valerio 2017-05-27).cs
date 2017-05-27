using Microsoft.OneDrive.Sdk;
using IniParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC_Backup_Tool___Settings {
    public partial class Main: Form {
        public Main() {
            InitializeComponent();
        }

        private void configurarBackupsToolStripMenuItem_Click(object sender, EventArgs e) {
            BackupTool.SettingsApp.Backup backupSetupDialog = new BackupTool.SettingsApp.Backup();
            backupSetupDialog.Show();
        }

        private void UploadButton_Click(object sender, EventArgs e) {
            FileIniDataParser teste = new FileIniDataParser();
            teste.ReadFile("C:/Users/Lucas/Desktop/teste.ini");
            MessageBox.Show("HAHAHA\n" + teste.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog s1 = new SaveFileDialog();
            s1.Filter = @"INI File | *.ini";

            if(s1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
