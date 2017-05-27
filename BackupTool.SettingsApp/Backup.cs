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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
            foreach(string temp in FileDialog.FileNames)
            {
                listBox1.Items.Add(temp);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderDialog.ShowDialog();
            listBox1.Items.Add(FolderDialog.SelectedPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                MessageBox.Show("Selecione um item para remover!");
        }
    }
    public class Item
    {
        public
            string type;
        string dir;
    }
}
