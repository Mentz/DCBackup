using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupTool.SettingsApp {
    public class ProgramSettings {
        private ODSettings OneDriveSettings;
        private List<BackupProfile> bkpProfiles;

    }




    public class ODSettings {
        private string privateKey;

        public string getPrivateKey() {
            return privateKey;
        }
    }




    public class BackupProfile {
        public string Nome { get; }
        public List<BackupFile> Arquivos { get; set; }
        public List<Agenda> Agenda { get; set; }

        public BackupProfile(string name) {
            this.Nome = name;
            this.Arquivos = new List<BackupFile>();
            this.Agenda = new List<Agenda>();
        }
    }



    public class BackupFile {
        public string filename { get; set; }
        public int type { get; set; }
        private List<FileDescription> arquivos;
        private List<FolderDescription> diretorios;
        private ZipConfig atributos;

        public BackupFile(string fn, int t, bool protegido) {
            this.filename = filename;
            this.type = type;
            this.arquivos = new List<FileDescription>();
            this.diretorios = new List<FolderDescription>();
            if (protegido) {
                InputMessageBox pwQuery = new InputMessageBox("Proteger com senha", "Digite a senha desejada");
                pwQuery.Show();
                if (pwQuery.DialogResult == DialogResult.OK) {
                    this.atributos = new ZipConfig(true, pwQuery.getText());
                }
                else {
                    this.atributos = new ZipConfig();
                }
            }

        }

        private bool findFile(string file) {
            bool ret = false;
            foreach (FileDescription i in this.arquivos) {
                if (i.Path == file)
                    ret = true;
            }
            return ret;
        }

        public bool addFile(string file) {
            if (findFile(file))
                return false;
            this.arquivos.Add(new FileDescription(file));
            return true;
        }

        public bool removeFile(string file) {
            if (!findFile(file))
                return false;
            for (int i = 0; i < arquivos.Count; i++) {
                if (arquivos[i].Path == file) {
                    arquivos.RemoveAt(i);
                    i--;
                }
            }
            return true;
        }

        private bool findFolder(string folder) {
            bool ret = false;
            foreach (FolderDescription i in this.diretorios) {
                if (i.Path == folder)
                    ret = true;
            }
            return ret;
        }

        public bool addFolder(string folder, int maxAge, bool recursive) {
            if (findFolder(folder))
                return false;
            this.diretorios.Add(new FolderDescription(folder, maxAge, recursive));
            return true;
        }
    }



    public class Agenda {
        private bool[] semana;
        private int hora;
        private int minuto;

        private Agenda() {
            semana = new bool[7];
            hora = 0;
            minuto = 0;
        }

        public void setDias(bool dom, bool seg, bool ter, bool qua, bool qui, bool sex, bool sab) {
            semana[0] = dom;
            semana[1] = seg;
            semana[2] = ter;
            semana[3] = qua;
            semana[4] = qui;
            semana[5] = sex;
            semana[6] = sab;
        }

        public void setHorario(int h, int m) {
            hora = Math.Max(Math.Min(h, 0), 24);
            minuto = Math.Max(Math.Min(m, 0), 60);
        }

    }



    public class FileDescription {
        public string Path { get; }

        public FileDescription(string p) {
            this.Path = p;
        }
    }



    public class FolderDescription {
        public string Path { get; }
        public int MaxAge { get; set; }
        public bool Recursive { get; set; }

        public FolderDescription(string p, int ma, bool r) {
            this.Path = p;
            this.MaxAge = ma;
            this.Recursive = r;
        }
    }



    public class ZipConfig {
        public bool PasswordProtected { get; set; }
        public string Password { get; set; }

        public ZipConfig() {
            this.PasswordProtected = false;
            this.Password = "";
        }

        public ZipConfig(bool pp, string p) {
            this.PasswordProtected = pp;
            if (pp) {
                this.Password = p;
            }
            else {
                this.Password = "";
            }
        }
    }
}
