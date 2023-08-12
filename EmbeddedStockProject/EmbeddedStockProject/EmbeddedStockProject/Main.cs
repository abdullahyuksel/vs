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
using static EmbeddedStockProject.Settings;

namespace EmbeddedStockProject
{
    
    public partial class Main : Form
    {
        private string dataRead;
        public static Main instanceMain;
        public Main()
        {
            InitializeComponent();
            instanceMain = this;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //string[] ports = Settings.DataReceived += new SerialDataReceivedEventHandler()

        }

        private void SerialDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            dataRead = Settings.instanceSettings.serialPort1.ReadLine();
            this.Invoke(new EventHandler(eventReader));
        }

        private void eventReader(object sender, EventArgs e)
        {
            receiveMessage.Text = dataRead + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox1.Text + "\r\n");

            labelEvent.Text = "send command A" + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox2.Text + "\r\n");
            labelEvent.Text = "send command B" + textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox3.Text + "\r\n");
            labelEvent.Text = "send command C" + textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox4.Text + "\r\n");
            labelEvent.Text = "send command D" + textBox4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox5.Text + "\r\n");
            labelEvent.Text = "send command E" + textBox5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox6.Text + "\r\n");
            labelEvent.Text = "send command F" + textBox6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox7.Text + "\r\n");
            labelEvent.Text = "send command G" + textBox7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(textBox8.Text + "\r\n");
            labelEvent.Text = "send command H" + textBox8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Settings.instanceSettings.serialPort1.Write(sendMessage.Text + "\r\n");
            labelEvent.Text = "send command box" + sendMessage.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Settings.instanceSettings.serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceive);
            }
        }
    }
}
