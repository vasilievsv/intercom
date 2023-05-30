namespace Voltmeter
{
    partial class voltmeter
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
            //ads112u04.connect._serial = micro.sdk.intercom._serial;

            this.button_connect = new System.Windows.Forms.Button();
            this.label_portstatus = new System.Windows.Forms.Label();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.button_portupdate = new System.Windows.Forms.Button();
            this.label_sample = new System.Windows.Forms.Label();
            this.button_startstop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volt = new System.Windows.Forms.GroupBox();
            this.label_voltage = new System.Windows.Forms.Label();
            this.groupBox_messure = new System.Windows.Forms.GroupBox();
            this.label_overload = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label_error_cnt = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBox_PGA_bypass = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBox_I2MUX = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox_I1MUX = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox_current = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox_input = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_reference = new System.Windows.Forms.ComboBox();
            this.groupBox_gain = new System.Windows.Forms.GroupBox();
            this.label_gain_alert = new System.Windows.Forms.Label();
            this.comboBox_gain = new System.Windows.Forms.ComboBox();
            this.groupBox_service = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label_pt100 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label_ext_ref = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_temperature = new System.Windows.Forms.Label();
            this.groupBox_battery = new System.Windows.Forms.GroupBox();
            this.label_battery_voltage = new System.Windows.Forms.Label();
            this.label_pt100_ohm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.volt.SuspendLayout();
            this.groupBox_messure.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_gain.SuspendLayout();
            this.groupBox_service.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_battery.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(5, 46);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(61, 22);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_portstatus
            // 
            this.label_portstatus.AutoSize = true;
            this.label_portstatus.Location = new System.Drawing.Point(71, 51);
            this.label_portstatus.Name = "label_portstatus";
            this.label_portstatus.Size = new System.Drawing.Size(22, 13);
            this.label_portstatus.TabIndex = 1;
            this.label_portstatus.Text = "-----";
            this.label_portstatus.Click += new System.EventHandler(this.label_portstatus_Click);
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(6, 19);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(59, 21);
            this.comboBox_ports.TabIndex = 3;
            this.comboBox_ports.SelectedIndexChanged += new System.EventHandler(this.comboBox_ports_SelectedIndexChanged);
            // 
            // button_portupdate
            // 
            this.button_portupdate.Location = new System.Drawing.Point(71, 18);
            this.button_portupdate.Name = "button_portupdate";
            this.button_portupdate.Size = new System.Drawing.Size(59, 21);
            this.button_portupdate.TabIndex = 4;
            this.button_portupdate.Text = "update";
            this.button_portupdate.UseVisualStyleBackColor = true;
            this.button_portupdate.Click += new System.EventHandler(this.button_portupdate_Click);
            // 
            // label_sample
            // 
            this.label_sample.AutoSize = true;
            this.label_sample.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sample.Location = new System.Drawing.Point(2, 20);
            this.label_sample.Name = "label_sample";
            this.label_sample.Size = new System.Drawing.Size(47, 26);
            this.label_sample.TabIndex = 5;
            this.label_sample.Text = "-----";
            // 
            // button_startstop
            // 
            this.button_startstop.Location = new System.Drawing.Point(6, 85);
            this.button_startstop.Name = "button_startstop";
            this.button_startstop.Size = new System.Drawing.Size(59, 22);
            this.button_startstop.TabIndex = 7;
            this.button_startstop.Text = "start";
            this.button_startstop.UseVisualStyleBackColor = true;
            this.button_startstop.Click += new System.EventHandler(this.button_startstop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_sample);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "raw data";
            // 
            // volt
            // 
            this.volt.Controls.Add(this.label_voltage);
            this.volt.Location = new System.Drawing.Point(89, 19);
            this.volt.Name = "volt";
            this.volt.Size = new System.Drawing.Size(180, 60);
            this.volt.TabIndex = 9;
            this.volt.TabStop = false;
            this.volt.Text = "voltage";
            // 
            // label_voltage
            // 
            this.label_voltage.AutoSize = true;
            this.label_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_voltage.Location = new System.Drawing.Point(4, 20);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(47, 26);
            this.label_voltage.TabIndex = 5;
            this.label_voltage.Text = "-----";
            // 
            // groupBox_messure
            // 
            this.groupBox_messure.Controls.Add(this.label_overload);
            this.groupBox_messure.Controls.Add(this.groupBox1);
            this.groupBox_messure.Controls.Add(this.button_startstop);
            this.groupBox_messure.Controls.Add(this.volt);
            this.groupBox_messure.Location = new System.Drawing.Point(12, 94);
            this.groupBox_messure.Name = "groupBox_messure";
            this.groupBox_messure.Size = new System.Drawing.Size(274, 123);
            this.groupBox_messure.TabIndex = 10;
            this.groupBox_messure.TabStop = false;
            this.groupBox_messure.Text = "Messure";
            // 
            // label_overload
            // 
            this.label_overload.AutoSize = true;
            this.label_overload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_overload.ForeColor = System.Drawing.Color.Red;
            this.label_overload.Location = new System.Drawing.Point(139, 85);
            this.label_overload.Name = "label_overload";
            this.label_overload.Size = new System.Drawing.Size(100, 26);
            this.label_overload.TabIndex = 10;
            this.label_overload.Text = "Overload";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.button_disconnect);
            this.groupBox3.Controls.Add(this.label_portstatus);
            this.groupBox3.Controls.Add(this.button_portupdate);
            this.groupBox3.Controls.Add(this.button_connect);
            this.groupBox3.Controls.Add(this.comboBox_ports);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 79);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label_error_cnt);
            this.groupBox11.Location = new System.Drawing.Point(136, 18);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(81, 27);
            this.groupBox11.TabIndex = 13;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "errors";
            // 
            // label_error_cnt
            // 
            this.label_error_cnt.AutoSize = true;
            this.label_error_cnt.Location = new System.Drawing.Point(39, 9);
            this.label_error_cnt.Name = "label_error_cnt";
            this.label_error_cnt.Size = new System.Drawing.Size(10, 13);
            this.label_error_cnt.TabIndex = 6;
            this.label_error_cnt.Text = "-";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_disconnect.Location = new System.Drawing.Point(133, 46);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(84, 22);
            this.button_disconnect.TabIndex = 5;
            this.button_disconnect.Text = "disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.label_pt100_ohm);
            this.groupBox_settings.Controls.Add(this.groupBox10);
            this.groupBox_settings.Controls.Add(this.groupBox6);
            this.groupBox_settings.Controls.Add(this.groupBox5);
            this.groupBox_settings.Controls.Add(this.groupBox4);
            this.groupBox_settings.Controls.Add(this.groupBox_gain);
            this.groupBox_settings.Location = new System.Drawing.Point(292, 12);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(274, 325);
            this.groupBox_settings.TabIndex = 12;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBox_PGA_bypass);
            this.groupBox10.Location = new System.Drawing.Point(178, 69);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(88, 44);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "bypass";
            // 
            // comboBox_PGA_bypass
            // 
            this.comboBox_PGA_bypass.FormattingEnabled = true;
            this.comboBox_PGA_bypass.Location = new System.Drawing.Point(9, 14);
            this.comboBox_PGA_bypass.Name = "comboBox_PGA_bypass";
            this.comboBox_PGA_bypass.Size = new System.Drawing.Size(75, 21);
            this.comboBox_PGA_bypass.TabIndex = 3;
            this.comboBox_PGA_bypass.SelectedIndexChanged += new System.EventHandler(this.comboBox_PGA_bypass_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(9, 123);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 172);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "current sources";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBox_I2MUX);
            this.groupBox9.Location = new System.Drawing.Point(5, 71);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(248, 46);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "i2mux";
            // 
            // comboBox_I2MUX
            // 
            this.comboBox_I2MUX.FormattingEnabled = true;
            this.comboBox_I2MUX.Location = new System.Drawing.Point(5, 19);
            this.comboBox_I2MUX.Name = "comboBox_I2MUX";
            this.comboBox_I2MUX.Size = new System.Drawing.Size(238, 21);
            this.comboBox_I2MUX.TabIndex = 0;
            this.comboBox_I2MUX.SelectedIndexChanged += new System.EventHandler(this.comboBox_I2MUX_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox_I1MUX);
            this.groupBox8.Location = new System.Drawing.Point(5, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(249, 46);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "i1mux";
            // 
            // comboBox_I1MUX
            // 
            this.comboBox_I1MUX.FormattingEnabled = true;
            this.comboBox_I1MUX.Location = new System.Drawing.Point(5, 19);
            this.comboBox_I1MUX.Name = "comboBox_I1MUX";
            this.comboBox_I1MUX.Size = new System.Drawing.Size(238, 21);
            this.comboBox_I1MUX.TabIndex = 0;
            this.comboBox_I1MUX.SelectedIndexChanged += new System.EventHandler(this.comboBox_I1MUX_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox_current);
            this.groupBox7.Location = new System.Drawing.Point(5, 117);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(92, 46);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "current";
            // 
            // comboBox_current
            // 
            this.comboBox_current.FormattingEnabled = true;
            this.comboBox_current.Location = new System.Drawing.Point(5, 19);
            this.comboBox_current.Name = "comboBox_current";
            this.comboBox_current.Size = new System.Drawing.Size(81, 21);
            this.comboBox_current.TabIndex = 0;
            this.comboBox_current.SelectedIndexChanged += new System.EventHandler(this.comboBox_comboBox_current_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox_input);
            this.groupBox5.Location = new System.Drawing.Point(8, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 44);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Input";
            // 
            // comboBox_input
            // 
            this.comboBox_input.FormattingEnabled = true;
            this.comboBox_input.Location = new System.Drawing.Point(8, 15);
            this.comboBox_input.Name = "comboBox_input";
            this.comboBox_input.Size = new System.Drawing.Size(246, 21);
            this.comboBox_input.TabIndex = 4;
            this.comboBox_input.SelectedIndexChanged += new System.EventHandler(this.comboBox_input_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_reference);
            this.groupBox4.Location = new System.Drawing.Point(8, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 44);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reference";
            // 
            // comboBox_reference
            // 
            this.comboBox_reference.FormattingEnabled = true;
            this.comboBox_reference.Location = new System.Drawing.Point(8, 15);
            this.comboBox_reference.Name = "comboBox_reference";
            this.comboBox_reference.Size = new System.Drawing.Size(89, 21);
            this.comboBox_reference.TabIndex = 4;
            this.comboBox_reference.SelectedIndexChanged += new System.EventHandler(this.comboBox_reference_SelectedIndexChanged);
            // 
            // groupBox_gain
            // 
            this.groupBox_gain.Controls.Add(this.label_gain_alert);
            this.groupBox_gain.Controls.Add(this.comboBox_gain);
            this.groupBox_gain.Location = new System.Drawing.Point(114, 69);
            this.groupBox_gain.Name = "groupBox_gain";
            this.groupBox_gain.Size = new System.Drawing.Size(58, 44);
            this.groupBox_gain.TabIndex = 4;
            this.groupBox_gain.TabStop = false;
            this.groupBox_gain.Text = "Gain";
            // 
            // label_gain_alert
            // 
            this.label_gain_alert.AutoSize = true;
            this.label_gain_alert.Enabled = false;
            this.label_gain_alert.ForeColor = System.Drawing.Color.Red;
            this.label_gain_alert.Location = new System.Drawing.Point(51, 18);
            this.label_gain_alert.Name = "label_gain_alert";
            this.label_gain_alert.Size = new System.Drawing.Size(10, 13);
            this.label_gain_alert.TabIndex = 4;
            this.label_gain_alert.Text = "!";
            // 
            // comboBox_gain
            // 
            this.comboBox_gain.FormattingEnabled = true;
            this.comboBox_gain.Location = new System.Drawing.Point(3, 14);
            this.comboBox_gain.Name = "comboBox_gain";
            this.comboBox_gain.Size = new System.Drawing.Size(46, 21);
            this.comboBox_gain.TabIndex = 3;
            this.comboBox_gain.SelectedIndexChanged += new System.EventHandler(this.comboBox_gain_SelectedIndexChanged);
            // 
            // groupBox_service
            // 
            this.groupBox_service.Controls.Add(this.groupBox13);
            this.groupBox_service.Controls.Add(this.groupBox12);
            this.groupBox_service.Controls.Add(this.groupBox2);
            this.groupBox_service.Controls.Add(this.groupBox_battery);
            this.groupBox_service.Location = new System.Drawing.Point(12, 219);
            this.groupBox_service.Name = "groupBox_service";
            this.groupBox_service.Size = new System.Drawing.Size(274, 118);
            this.groupBox_service.TabIndex = 13;
            this.groupBox_service.TabStop = false;
            this.groupBox_service.Text = "Service";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label_pt100);
            this.groupBox13.Location = new System.Drawing.Point(115, 64);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(153, 39);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Temperature PT100";
            this.groupBox13.Enter += new System.EventHandler(this.groupBox13_Enter);
            // 
            // label_pt100
            // 
            this.label_pt100.AutoSize = true;
            this.label_pt100.Location = new System.Drawing.Point(6, 18);
            this.label_pt100.Name = "label_pt100";
            this.label_pt100.Size = new System.Drawing.Size(19, 13);
            this.label_pt100.TabIndex = 1;
            this.label_pt100.Text = "----";
            this.label_pt100.Click += new System.EventHandler(this.label_pt100_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label_ext_ref);
            this.groupBox12.Location = new System.Drawing.Point(6, 64);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(103, 39);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "ext ref voltage";
            // 
            // label_ext_ref
            // 
            this.label_ext_ref.AutoSize = true;
            this.label_ext_ref.Location = new System.Drawing.Point(6, 18);
            this.label_ext_ref.Name = "label_ext_ref";
            this.label_ext_ref.Size = new System.Drawing.Size(19, 13);
            this.label_ext_ref.TabIndex = 1;
            this.label_ext_ref.Text = "----";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_temperature);
            this.groupBox2.Location = new System.Drawing.Point(115, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 39);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature";
            // 
            // label_temperature
            // 
            this.label_temperature.AutoSize = true;
            this.label_temperature.Location = new System.Drawing.Point(6, 18);
            this.label_temperature.Name = "label_temperature";
            this.label_temperature.Size = new System.Drawing.Size(19, 13);
            this.label_temperature.TabIndex = 1;
            this.label_temperature.Text = "----";
            // 
            // groupBox_battery
            // 
            this.groupBox_battery.Controls.Add(this.label_battery_voltage);
            this.groupBox_battery.Location = new System.Drawing.Point(6, 19);
            this.groupBox_battery.Name = "groupBox_battery";
            this.groupBox_battery.Size = new System.Drawing.Size(103, 39);
            this.groupBox_battery.TabIndex = 0;
            this.groupBox_battery.TabStop = false;
            this.groupBox_battery.Text = "AVDD voltage";
            // 
            // label_battery_voltage
            // 
            this.label_battery_voltage.AutoSize = true;
            this.label_battery_voltage.Location = new System.Drawing.Point(6, 18);
            this.label_battery_voltage.Name = "label_battery_voltage";
            this.label_battery_voltage.Size = new System.Drawing.Size(19, 13);
            this.label_battery_voltage.TabIndex = 1;
            this.label_battery_voltage.Text = "----";
            // 
            // label_pt100_ohm
            // 
            this.label_pt100_ohm.AutoSize = true;
            this.label_pt100_ohm.Location = new System.Drawing.Point(11, 309);
            this.label_pt100_ohm.Name = "label_pt100_ohm";
            this.label_pt100_ohm.Size = new System.Drawing.Size(19, 13);
            this.label_pt100_ohm.TabIndex = 2;
            this.label_pt100_ohm.Text = "----";
            // 
            // voltmeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 347);
            this.Controls.Add(this.groupBox_service);
            this.Controls.Add(this.groupBox_settings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_messure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "voltmeter";
            this.Text = "Voltmeter";
            this.Load += new System.EventHandler(this.voltmeter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.volt.ResumeLayout(false);
            this.volt.PerformLayout();
            this.groupBox_messure.ResumeLayout(false);
            this.groupBox_messure.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox_gain.ResumeLayout(false);
            this.groupBox_gain.PerformLayout();
            this.groupBox_service.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_battery.ResumeLayout(false);
            this.groupBox_battery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_portstatus;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Button button_portupdate;
        private System.Windows.Forms.Label label_sample;
        private System.Windows.Forms.Button button_startstop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox volt;
        private System.Windows.Forms.Label label_voltage;
        private System.Windows.Forms.GroupBox groupBox_messure;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.ComboBox comboBox_gain;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_reference;
        private System.Windows.Forms.GroupBox groupBox_gain;
        private System.Windows.Forms.Label label_overload;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox_input;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox_current;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox_I1MUX;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox comboBox_I2MUX;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboBox_PGA_bypass;
        private System.Windows.Forms.Label label_error_cnt;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox_service;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_temperature;
        private System.Windows.Forms.GroupBox groupBox_battery;
        private System.Windows.Forms.Label label_battery_voltage;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label_ext_ref;
        private System.Windows.Forms.Label label_gain_alert;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label_pt100;
        private System.Windows.Forms.Label label_pt100_ohm;
    }
}

