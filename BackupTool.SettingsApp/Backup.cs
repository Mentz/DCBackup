using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupTool.SettingsApp {
    public partial class Backup: Form {
        public Backup() {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
        }
    }
}
