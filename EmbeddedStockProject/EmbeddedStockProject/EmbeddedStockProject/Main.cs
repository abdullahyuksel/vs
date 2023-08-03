using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedStockProject
{
    public partial class Main : Form
    {
        public static Main instanceMain;
        public Main()
        {
            InitializeComponent();
            instanceMain = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox1.Text);
            labelEvent.Text = "send command A" + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox2.Text);
            labelEvent.Text = "send command B" + textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox3.Text);
            labelEvent.Text = "send command C" + textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox4.Text);
            labelEvent.Text = "send command D" + textBox4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox5.Text);
            labelEvent.Text = "send command E" + textBox5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox6.Text);
            labelEvent.Text = "send command F" + textBox6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox7.Text);
            labelEvent.Text = "send command G" + textBox7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox8.Text);
            labelEvent.Text = "send command H" + textBox8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(sendMessage.Text);
            labelEvent.Text = "send command box" + sendMessage.Text;
        }
    }
}
