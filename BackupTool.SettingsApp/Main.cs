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

        #region InitMethods

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

            try {
                if (!Directory.Exists(Path.GetDirectoryName(configFilePath)))
                    throw new DirectoryNotFoundException("Diretório 'C:\\ProgramData\\DCBackup' inexistente");
                if (!System.IO.File.Exists(configFilePath))
                    throw new FileNotFoundException("Arquivo " + Path.GetFileName(configFilePath) + "inexistente no diretório 'C:\\ProgramData\\DCBackup'");
            }
            catch (DirectoryNotFoundException ex) {
                Directory.CreateDirectory(Path.GetDirectoryName(configFilePath)); // cria diretório para guardar .ini
                CreateConfigFileFirstTime();
                var key = MessageBox.Show("Primeiro acesso ao programa.\nDeseja configurar um perfil agora?",
                    "Primeiro acesso",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                //MessageBox.Show(key.ToString());
            }
            catch (FileNotFoundException ex) {
                CreateConfigFileFirstTime();
                var key = MessageBox.Show("Primeiro acesso ao programa.\nDeseja configurar um perfil agora?",
                    "Primeiro acesso",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro genérico\nApresente os dados abaixo para o programador:\n" + ex.ToString()); // Nothing to do yet
            }

            

            //MessageBox.Show(backupProfiles.ToString());
            ReadProfilesFromIniFile(configFilePath);
        }

        #endregion

        #region GlobalVariables

        // Parser de arquivo usado para leitura e escrita no arquivo .ini de configuração
        private FileIniDataParser iniFileParser = new FileIniDataParser();

        // Local do arquivo .ini de configuração
        string configFilePath = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "ProgramData/DCBackup/config.ini");

        #endregion

        private void ReadProfilesFromIniFile(string filePath) {
            IniData configParameters = iniFileParser.ReadFile(filePath);

            List<string> profiles = new List<string>();
            if (configParameters["instance"]["backupprofiles"] != null)
                profiles.AddRange(configParameters["instance"]["backupprofiles"].Split('|'));

            List<backupProfile> backupProfiles = new List<backupProfile>();
            foreach (string profile in profiles) {
                if (configParameters.Sections.ContainsSection(profile))
                    backupProfiles.Add(new backupProfile(profile, configParameters[profile]["type"], configParameters[profile]["triggertime"]));
            }

            listBackupProfiles.DataSource = null;
            listBackupProfiles.DataSource = backupProfiles;
            listBackupProfiles.Refresh();
        }

        private void SaveProfilesToIniFile(string filePath) {

        }

        private void CreateConfigFileFirstTime() {
            string configFilePath = Path.GetFullPath(Path.Combine(Path.GetPathRoot(Environment.SystemDirectory),"ProgramData/DCBackup/config.ini"));
            IniData newFile = new IniData();
            newFile["instance"]["creation"] = DateTime.Now.ToString();
            newFile["instance"]["backupprofiles"] = "";
            iniFileParser.WriteFile(configFilePath, newFile);
        }

        #region ButtonEventHandlers

        private void buttonRemoveProfile_Click(object sender, EventArgs e) {
            foreach (var a in listBackupProfiles.SelectedRows) {
            }
        }

        private void buttonAddProfile_Click(object sender, EventArgs e) {
            BackupTool.SettingsApp.Backup backupSetupDialog = new BackupTool.SettingsApp.Backup();
            if (backupSetupDialog.ShowDialog() == DialogResult.OK) {

            }
            backupSetupDialog.Dispose();
        }

        #endregion

        private void buttonEditProfile_Click(object sender, EventArgs e) {

        }

        private void Main_Load(object sender, EventArgs e) {

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
