namespace EmbeddedSystemCommunication
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
            label1 = new Label();
            label2 = new Label();
            ComPortBox = new ComboBox();
            BautrateBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            DataBitsBox = new ComboBox();
            StopBitsBox = new ComboBox();
            PrityBitsBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 78);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Baudrate:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "COM Port:";
            label2.Click += label2_Click;
            // 
            // ComPortBox
            // 
            ComPortBox.FormattingEnabled = true;
            ComPortBox.Location = new Point(244, 51);
            ComPortBox.Name = "ComPortBox";
            ComPortBox.Size = new Size(121, 23);
            ComPortBox.TabIndex = 2;
            // 
            // BautrateBox
            // 
            BautrateBox.FormattingEnabled = true;
            BautrateBox.Location = new Point(244, 80);
            BautrateBox.Name = "BautrateBox";
            BautrateBox.Size = new Size(121, 23);
            BautrateBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(150, 215);
            button1.Name = "button1";
            button1.Size = new Size(215, 23);
            button1.TabIndex = 4;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(150, 255);
            button2.Name = "button2";
            button2.Size = new Size(215, 23);
            button2.TabIndex = 5;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PrityBitsBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(StopBitsBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(DataBitsBox);
            groupBox1.Controls.Add(ComPortBox);
            groupBox1.Controls.Add(BautrateBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 326);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "COM Port Pnael";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // DataBitsBox
            // 
            DataBitsBox.FormattingEnabled = true;
            DataBitsBox.Location = new Point(244, 109);
            DataBitsBox.Name = "DataBitsBox";
            DataBitsBox.Size = new Size(121, 23);
            DataBitsBox.TabIndex = 4;
            // 
            // StopBitsBox
            // 
            StopBitsBox.FormattingEnabled = true;
            StopBitsBox.Location = new Point(244, 138);
            StopBitsBox.Name = "StopBitsBox";
            StopBitsBox.Size = new Size(121, 23);
            StopBitsBox.TabIndex = 5;
            // 
            // PrityBitsBox
            // 
            PrityBitsBox.FormattingEnabled = true;
            PrityBitsBox.Location = new Point(244, 167);
            PrityBitsBox.Name = "PrityBitsBox";
            PrityBitsBox.Size = new Size(121, 23);
            PrityBitsBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 107);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 7;
            label3.Text = "Data Bits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 136);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 8;
            label4.Text = "Stop Bits:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 165);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 9;
            label5.Text = "Parity Bits:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox ComPortBox;
        private ComboBox BautrateBox;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private ComboBox PrityBitsBox;
        private ComboBox StopBitsBox;
        private ComboBox DataBitsBox;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}