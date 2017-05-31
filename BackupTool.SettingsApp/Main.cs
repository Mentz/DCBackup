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

        /// <summary>
        /// Verificar componentes necessários na inicialização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Shown(object sender, EventArgs e) {
            string configFilePath = Path.GetPathRoot(Environment.SystemDirectory);
            configFilePath = Path.Combine(configFilePath, "ProgramData/DCBackup/config.ini");

            try {
                if (!Directory.Exists(Path.GetDirectoryName(configFilePath)))
                    throw new DirectoryNotFoundException("Diretório 'C:\\ProgramData\\DCBackup' inexistente");
                if (!System.IO.File.Exists(configFilePath))
                    throw new FileNotFoundException("Arquivo " + Path.GetFileName(configFilePath) + "inexistente no diretório 'C:\\ProgramData\\DCBackup'");
            }
            catch (DirectoryNotFoundException ex) {
                Directory.CreateDirectory(Path.GetDirectoryName(configFilePath));
                firstTime();
                var key = MessageBox.Show("Primeiro acesso ao programa.\nDeseja configurar um perfil agora?",
                    "Primeiro acesso",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                MessageBox.Show(key.ToString());
            }
            catch (FileNotFoundException ex) {
                firstTime();
                var key = MessageBox.Show("Primeiro acesso ao programa.\nDeseja configurar um perfil agora?",
                    "Primeiro acesso",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro genérico\nApresente os dados abaixo para o programador:\n" + ex.ToString()); // Nothing to do yet
            }

            IniData configParameters = IniParser.ReadFile(configFilePath);

            List<string> profiles = new List<string>();
            if (configParameters["instance"]["backupprofiles"] != null)
                profiles.AddRange(configParameters["instance"]["backupprofiles"].Split('|'));

            MessageBox.Show(profiles.ToString());
            List<backupProfile> backupProfiles = new List<backupProfile>();
            foreach (string profile in profiles) {
                //backupProfiles.Add(new backupProfile(profile, configParameters[profile]["type"], configParameters[profile]["triggertime"]));
            }

            MessageBox.Show(backupProfiles.ToString());
            listBackupProfiles.DataSource = null;
            listBackupProfiles.DataSource = backupProfiles;
            listBackupProfiles.Refresh();
        }

        private void firstTime() {
            string configFilePath = Path.GetFullPath(Path.Combine(Path.GetPathRoot(Environment.SystemDirectory),"ProgramData/DCBackup/config.ini"));
            IniData newFile = new IniData();
            newFile["instance"]["creation"] = DateTime.Now.ToString();
            newFile["instance"]["backupprofiles"] = "";
            FileIniDataParser parser = new FileIniDataParser();
            parser.WriteFile(configFilePath, newFile);
        }

        private void configurarBackupsToolStripMenuItem_Click(object sender, EventArgs e) {
            BackupTool.SettingsApp.Backup backupSetupDialog = new BackupTool.SettingsApp.Backup(null);
            backupSetupDialog.Show();
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
