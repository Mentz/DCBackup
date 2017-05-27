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
            MessageBox.Show("Ola :D");
            Tab1.Controls.Remove(tabPage2);
            Tab1.Controls.Add(tabPage1);
            Tab1.TabPages.
        }
    }
}
