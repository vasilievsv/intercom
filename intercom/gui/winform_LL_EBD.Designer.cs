namespace app
{
    partial class winform_LL_EBD
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label_RX = new System.Windows.Forms.Label();
            this.label_TX = new System.Windows.Forms.Label();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.open_port = new System.Windows.Forms.Button();
            this.label_port_status = new System.Windows.Forms.Label();
            this.close_port = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.numericUpDown_freq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_duration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_scale = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_baudrate);
            this.groupBox1.Controls.Add(this.label_RX);
            this.groupBox1.Controls.Add(this.label_TX);
            this.groupBox1.Controls.Add(this.comboBox_ports);
            this.groupBox1.Controls.Add(this.open_port);
            this.groupBox1.Controls.Add(this.label_port_status);
            this.groupBox1.Controls.Add(this.close_port);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Location = new System.Drawing.Point(95, 19);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(74, 21);
            this.comboBox_baudrate.TabIndex = 8;
            // 
            // label_RX
            // 
            this.label_RX.AutoSize = true;
            this.label_RX.Location = new System.Drawing.Point(188, 51);
            this.label_RX.Name = "label_RX";
            this.label_RX.Size = new System.Drawing.Size(22, 13);
            this.label_RX.TabIndex = 7;
            this.label_RX.Text = "RX";
            // 
            // label_TX
            // 
            this.label_TX.AutoSize = true;
            this.label_TX.Location = new System.Drawing.Point(216, 51);
            this.label_TX.Name = "label_TX";
            this.label_TX.Size = new System.Drawing.Size(21, 13);
            this.label_TX.TabIndex = 6;
            this.label_TX.Text = "TX";
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(6, 19);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(75, 21);
            this.comboBox_ports.TabIndex = 4;
            // 
            // open_port
            // 
            this.open_port.Location = new System.Drawing.Point(6, 46);
            this.open_port.Name = "open_port";
            this.open_port.Size = new System.Drawing.Size(75, 23);
            this.open_port.TabIndex = 0;
            this.open_port.Text = "Open";
            this.open_port.UseVisualStyleBackColor = true;
            this.open_port.Click += new System.EventHandler(this.open_port_Click);
            // 
            // label_port_status
            // 
            this.label_port_status.AutoSize = true;
            this.label_port_status.Location = new System.Drawing.Point(188, 22);
            this.label_port_status.Name = "label_port_status";
            this.label_port_status.Size = new System.Drawing.Size(60, 13);
            this.label_port_status.TabIndex = 3;
            this.label_port_status.Text = "don`t panic";
            // 
            // close_port
            // 
            this.close_port.Location = new System.Drawing.Point(94, 46);
            this.close_port.Name = "close_port";
            this.close_port.Size = new System.Drawing.Size(75, 23);
            this.close_port.TabIndex = 1;
            this.close_port.Text = "Close";
            this.close_port.UseVisualStyleBackColor = true;
            this.close_port.Click += new System.EventHandler(this.close_port_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(195, 117);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 9;
            this.button_reset.Text = "Set 0";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // numericUpDown_freq
            // 
            this.numericUpDown_freq.Location = new System.Drawing.Point(106, 119);
            this.numericUpDown_freq.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_freq.Name = "numericUpDown_freq";
            this.numericUpDown_freq.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_freq.TabIndex = 10;
            this.numericUpDown_freq.ValueChanged += new System.EventHandler(this.numericUpDown_freq_ValueChanged);
            // 
            // numericUpDown_duration
            // 
            this.numericUpDown_duration.Location = new System.Drawing.Point(106, 179);
            this.numericUpDown_duration.Name = "numericUpDown_duration";
            this.numericUpDown_duration.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_duration.TabIndex = 11;
            this.numericUpDown_duration.ValueChanged += new System.EventHandler(this.numericUpDown_duration_ValueChanged);
            // 
            // numericUpDown_scale
            // 
            this.numericUpDown_scale.Location = new System.Drawing.Point(106, 149);
            this.numericUpDown_scale.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_scale.Name = "numericUpDown_scale";
            this.numericUpDown_scale.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_scale.TabIndex = 12;
            this.numericUpDown_scale.ValueChanged += new System.EventHandler(this.numericUpDown_scale_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Duration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_scale);
            this.Controls.Add(this.numericUpDown_duration);
            this.Controls.Add(this.numericUpDown_freq);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label_RX;
        private System.Windows.Forms.Label label_TX;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Button open_port;
        private System.Windows.Forms.Label label_port_status;
        private System.Windows.Forms.Button close_port;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.NumericUpDown numericUpDown_freq;
        private System.Windows.Forms.NumericUpDown numericUpDown_duration;
        private System.Windows.Forms.NumericUpDown numericUpDown_scale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

