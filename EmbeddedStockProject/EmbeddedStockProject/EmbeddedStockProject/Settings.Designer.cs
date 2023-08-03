namespace EmbeddedStockProject
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_com_port = new System.Windows.Forms.ComboBox();
            this.cbox_baudrate = new System.Windows.Forms.ComboBox();
            this.cbox_data_bits = new System.Windows.Forms.ComboBox();
            this.cbox_stop_bits = new System.Windows.Forms.ComboBox();
            this.cbox_parity_bits = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_disconnect = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(127, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(127, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(127, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(127, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(127, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity Bits:";
            // 
            // cbox_com_port
            // 
            this.cbox_com_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_com_port.FormattingEnabled = true;
            this.cbox_com_port.Location = new System.Drawing.Point(274, 88);
            this.cbox_com_port.Name = "cbox_com_port";
            this.cbox_com_port.Size = new System.Drawing.Size(121, 24);
            this.cbox_com_port.TabIndex = 5;
            // 
            // cbox_baudrate
            // 
            this.cbox_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_baudrate.FormattingEnabled = true;
            this.cbox_baudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbox_baudrate.Location = new System.Drawing.Point(274, 114);
            this.cbox_baudrate.Name = "cbox_baudrate";
            this.cbox_baudrate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbox_baudrate.Size = new System.Drawing.Size(121, 24);
            this.cbox_baudrate.TabIndex = 6;
            this.cbox_baudrate.Text = "9600";
            // 
            // cbox_data_bits
            // 
            this.cbox_data_bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_data_bits.FormattingEnabled = true;
            this.cbox_data_bits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbox_data_bits.Location = new System.Drawing.Point(274, 140);
            this.cbox_data_bits.Name = "cbox_data_bits";
            this.cbox_data_bits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbox_data_bits.Size = new System.Drawing.Size(121, 24);
            this.cbox_data_bits.TabIndex = 7;
            this.cbox_data_bits.Text = "8";
            // 
            // cbox_stop_bits
            // 
            this.cbox_stop_bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_stop_bits.FormattingEnabled = true;
            this.cbox_stop_bits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbox_stop_bits.Location = new System.Drawing.Point(274, 166);
            this.cbox_stop_bits.Name = "cbox_stop_bits";
            this.cbox_stop_bits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbox_stop_bits.Size = new System.Drawing.Size(121, 24);
            this.cbox_stop_bits.TabIndex = 8;
            this.cbox_stop_bits.Text = "One";
            // 
            // cbox_parity_bits
            // 
            this.cbox_parity_bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_parity_bits.FormattingEnabled = true;
            this.cbox_parity_bits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbox_parity_bits.Location = new System.Drawing.Point(274, 192);
            this.cbox_parity_bits.Name = "cbox_parity_bits";
            this.cbox_parity_bits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbox_parity_bits.Size = new System.Drawing.Size(121, 24);
            this.cbox_parity_bits.TabIndex = 9;
            this.cbox_parity_bits.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_disconnect);
            this.groupBox1.Controls.Add(this.bt_connect);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 291);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Panel";
            // 
            // bt_disconnect
            // 
            this.bt_disconnect.Location = new System.Drawing.Point(104, 232);
            this.bt_disconnect.Name = "bt_disconnect";
            this.bt_disconnect.Size = new System.Drawing.Size(262, 23);
            this.bt_disconnect.TabIndex = 1;
            this.bt_disconnect.Text = "DISCONNECT";
            this.bt_disconnect.UseVisualStyleBackColor = true;
            this.bt_disconnect.Click += new System.EventHandler(this.bt_disconnect_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(104, 203);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(262, 23);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "CONNECT";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbox_parity_bits);
            this.Controls.Add(this.cbox_stop_bits);
            this.Controls.Add(this.cbox_data_bits);
            this.Controls.Add(this.cbox_baudrate);
            this.Controls.Add(this.cbox_com_port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_com_port;
        private System.Windows.Forms.ComboBox cbox_baudrate;
        private System.Windows.Forms.ComboBox cbox_data_bits;
        private System.Windows.Forms.ComboBox cbox_stop_bits;
        private System.Windows.Forms.ComboBox cbox_parity_bits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_disconnect;
        private System.Windows.Forms.Button bt_connect;
        public System.IO.Ports.SerialPort serialPort1;
    }
}