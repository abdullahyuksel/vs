namespace EmbeddedSystemCommunication
{
    public partial class EmbeddedSystemCommunication : Form
    {
        public EmbeddedSystemCommunication()
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

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Main());
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new Settings());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new About());
        }
    }
}