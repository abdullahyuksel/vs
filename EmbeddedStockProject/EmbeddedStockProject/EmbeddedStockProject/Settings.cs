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
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;

namespace EmbeddedStockProject
{
    public partial class Settings : Form
    {
        public static Settings instanceSettings;
        public Settings()
        {
            InitializeComponent();
            instanceSettings = this;
        }
        public static class genelDegiskenler  // program içinde heryerden erişebilmek için
        {
            public static SerialPort serialPort1;
        }
        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbox_com_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbox_baudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(cbox_data_bits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbox_stop_bits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbox_parity_bits.Text);

                serialPort1.Open();
         
            }
            catch
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbox_com_port.Items.AddRange(ports);

        }

        private void bt_disconnect_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
