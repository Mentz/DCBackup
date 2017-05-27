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
using System.IO;

namespace DC_Backup_Tool___Settings {
    public partial class Main: Form {
        private FileIniDataParser IniParser = new FileIniDataParser();

        public Main() {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void configurarBackupsToolStripMenuItem_Click(object sender, EventArgs e) {
            BackupTool.SettingsApp.Backup backupSetupDialog = new BackupTool.SettingsApp.Backup();
            backupSetupDialog.Show();
        }

        private void updateProfiles_Click(object sender, EventArgs e) {
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            path = Path.GetFullPath(path);
            string newPath = Path.GetFullPath(path + "teste.ini");
            MessageBox.Show("path = " + path + "\nnewPath = " + newPath);
            IniData ini = IniParser.ReadFile(newPath);
            List<backupProfile> teste = new List<backupProfile>();
            teste.Add(new backupProfile(ini["Backup"]["Nome"],
                                        ini["Backup"]["Tipo"],
                                        ini["Backup"]["Agenda"]));
            listBackupProfiles.DataSource = teste;
            listBackupProfiles.Refresh();
        }
    }

    class backupProfile {
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public DateTime Agenda { get; set; }

        public backupProfile(string pfName, string type, string dataehora) {
            Nome = pfName;
            Tipo = int.Parse(type);
            DateTime today = DateTime.Today;
            string[] splitdt = dataehora.Split(':');
            Agenda = new DateTime(today.Year, today.Month, today.Day, int.Parse(splitdt[0]), int.Parse(splitdt[1]), 0);
        }
    }
}
