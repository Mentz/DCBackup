using Microsoft.OneDrive.Sdk;
using IniParser;
using IniParser.Model;
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
        private FileIniDataParser IniParser = new FileIniDataParser();

        public Main() {
            InitializeComponent();
        }

        private void configurarBackupsToolStripMenuItem_Click(object sender, EventArgs e) {
            BackupTool.SettingsApp.Backup backupSetupDialog = new BackupTool.SettingsApp.Backup();
            backupSetupDialog.Show();
        }

        private void updateProfiles_Click(object sender, EventArgs e) {
            var a = openFileDialog1.ShowDialog();
            MessageBox.Show(a);
            IniData ini = IniParser.ReadFile("C:/Users/Lucas/Desktop/teste.ini");
            List<backupProfile> teste = new List<backupProfile>();
            teste.Add(new backupProfile(ini["Backup"]["Nome"],
                                        ini["Backup"]["Tipo"],
                                        ini["Backup"]["Agenda"]));
            listBackupProfiles.DataSource = teste;
            listBackupProfiles.Refresh();
        }
    }

    class backupProfile {
        public string ProfileName { get; set; }
        public int ProfileType { get; set; }
        public DateTime Agenda { get; set; }

        public backupProfile(string pfName, string type, string dataehora) {
            ProfileName = pfName;
            ProfileType = int.Parse(type);
            DateTime today = DateTime.Today;
            string[] splitdt = dataehora.Split(':');
            Agenda = new DateTime(today.Year, today.Month, today.Day, int.Parse(splitdt[0]), int.Parse(splitdt[1]), 0);
        }

        /*
        public override string ToString() {
            string ret = 
        }*/
    }
}
