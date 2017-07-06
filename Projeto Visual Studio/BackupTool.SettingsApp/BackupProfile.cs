using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupTool.SettingsApp {
    class BackupProfile {
        public int backupType { get; }
        public List<BackupFile> arquivos { get; set; }
        public List<Agenda> agenda { get; set; }

        public BackupProfile() {

        }
    }



    class BackupFile {
        public string filename { get; set; }
        public int type { get; set; }
        private List<FileDescription> arquivos;
        private List<FolderDescription> diretorios;
        private ZipConfig atributos;

        public BackupFile(string fn, int t) {
            this.filename = filename;
            this.type = type;
        }

        private bool findItem(string file) {
            bool ret = false;
            foreach (FileDescription i in this.arquivos) {
                if (i.path == file)
                    ret = true;
            }

            return ret;
        }

        public bool addFile(string file) {
            if (findItem(file))
                return false;
            this.arquivos.Add(file);
            return true;
        }

        public bool removeFile(string file)
    }



    class Agenda {
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



    class ZipConfig {
        public bool passwordProtected { get; set; }
        public string password { get; set; }
    }
}
