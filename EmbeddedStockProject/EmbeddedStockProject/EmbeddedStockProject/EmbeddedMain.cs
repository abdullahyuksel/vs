using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;

namespace EmbeddedStockProject
{
    public partial class EmbeddedMain : Form
    {
        public EmbeddedMain()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void EmbeddedMain_Load(object sender, EventArgs e)
        {
         
        }

        private void mainToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loadform(new Main());
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loadform(new Settings());
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            loadform(new About());
        }
    }
}
