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
    public partial class InputMessageBox: Form {
        public InputMessageBox(string title, string message) {
            this.Text = title;
            this.labelText.Text = message;
            InitializeComponent();
        }

        public string getText() {
            return this.labelText.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
