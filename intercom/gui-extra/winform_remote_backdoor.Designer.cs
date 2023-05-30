using System.Drawing;
using System.Drawing.Imaging;

namespace app
{
    partial class winform_remote_backdoor
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.track_ac_dimming = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ac_width_ms = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_zc_width_ms = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_sram = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_clock_load = new System.Windows.Forms.Button();
            this.btn_clock_save = new System.Windows.Forms.Button();
            this.tree_clock_schedule = new System.Windows.Forms.TreeView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ota_apply = new System.Windows.Forms.Button();
            this.btn_ota_update = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.input_ota_firmware_file = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.input_ota_port = new System.Windows.Forms.TextBox();
            this.input_ota_ip = new System.Windows.Forms.TextBox();
            this.lbl_clock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_ac_dimming)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.track_ac_dimming);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(494, 137);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AC";
            // 
            // track_ac_dimming
            // 
            this.track_ac_dimming.Location = new System.Drawing.Point(13, 83);
            this.track_ac_dimming.Maximum = 7;
            this.track_ac_dimming.Name = "track_ac_dimming";
            this.track_ac_dimming.Size = new System.Drawing.Size(352, 45);
            this.track_ac_dimming.TabIndex = 0;
            this.track_ac_dimming.Scroll += new System.EventHandler(this.track_ac_dimming_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ac_width_ms);
            this.groupBox2.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.groupBox2.Location = new System.Drawing.Point(13, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(111, 46);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ac_widtg_ms";
            // 
            // lbl_ac_width_ms
            // 
            this.lbl_ac_width_ms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_ac_width_ms.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ac_width_ms.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ac_width_ms.Location = new System.Drawing.Point(8, 15);
            this.lbl_ac_width_ms.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.lbl_ac_width_ms.Multiline = true;
            this.lbl_ac_width_ms.Name = "lbl_ac_width_ms";
            this.lbl_ac_width_ms.Size = new System.Drawing.Size(98, 18);
            this.lbl_ac_width_ms.TabIndex = 56;
            this.lbl_ac_width_ms.Text = "0";
            this.lbl_ac_width_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbl_ac_width_ms.WordWrap = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_zc_width_ms);
            this.groupBox5.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.groupBox5.Location = new System.Drawing.Point(128, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(122, 46);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "zc_width_ms";
            // 
            // lbl_zc_width_ms
            // 
            this.lbl_zc_width_ms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_zc_width_ms.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zc_width_ms.ForeColor = System.Drawing.Color.Blue;
            this.lbl_zc_width_ms.Location = new System.Drawing.Point(8, 15);
            this.lbl_zc_width_ms.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.lbl_zc_width_ms.Multiline = true;
            this.lbl_zc_width_ms.Name = "lbl_zc_width_ms";
            this.lbl_zc_width_ms.Size = new System.Drawing.Size(100, 18);
            this.lbl_zc_width_ms.TabIndex = 56;
            this.lbl_zc_width_ms.Text = "0";
            this.lbl_zc_width_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbl_zc_width_ms.WordWrap = false;
            this.lbl_zc_width_ms.TextChanged += new System.EventHandler(this.lbl_zc_width_ms_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_sram);
            this.groupBox6.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.groupBox6.Location = new System.Drawing.Point(254, 15);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(111, 46);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "sram";
            // 
            // lbl_sram
            // 
            this.lbl_sram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_sram.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sram.ForeColor = System.Drawing.Color.Blue;
            this.lbl_sram.Location = new System.Drawing.Point(3, 15);
            this.lbl_sram.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.lbl_sram.Multiline = true;
            this.lbl_sram.Name = "lbl_sram";
            this.lbl_sram.Size = new System.Drawing.Size(104, 18);
            this.lbl_sram.TabIndex = 57;
            this.lbl_sram.Text = "270/532";
            this.lbl_sram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbl_sram.WordWrap = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.lbl_clock);
            this.groupBox7.Controls.Add(this.btn_clock_load);
            this.groupBox7.Controls.Add(this.btn_clock_save);
            this.groupBox7.Controls.Add(this.tree_clock_schedule);
            this.groupBox7.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.groupBox7.Location = new System.Drawing.Point(22, 327);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(494, 249);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "clock";
            // 
            // btn_clock_load
            // 
            this.btn_clock_load.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clock_load.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.btn_clock_load.ForeColor = System.Drawing.Color.Black;
            this.btn_clock_load.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clock_load.Location = new System.Drawing.Point(217, 145);
            this.btn_clock_load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clock_load.Name = "btn_clock_load";
            this.btn_clock_load.Size = new System.Drawing.Size(103, 26);
            this.btn_clock_load.TabIndex = 84;
            this.btn_clock_load.Text = "enum";
            this.btn_clock_load.UseVisualStyleBackColor = true;
            this.btn_clock_load.Click += new System.EventHandler(this.btn_clock_load_Click);
            // 
            // btn_clock_save
            // 
            this.btn_clock_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clock_save.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.btn_clock_save.ForeColor = System.Drawing.Color.Black;
            this.btn_clock_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clock_save.Location = new System.Drawing.Point(217, 175);
            this.btn_clock_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clock_save.Name = "btn_clock_save";
            this.btn_clock_save.Size = new System.Drawing.Size(103, 26);
            this.btn_clock_save.TabIndex = 84;
            this.btn_clock_save.Text = "save";
            this.btn_clock_save.UseVisualStyleBackColor = true;
            this.btn_clock_save.Click += new System.EventHandler(this.btn_clock_save_Click);
            // 
            // tree_clock_schedule
            // 
            this.tree_clock_schedule.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.tree_clock_schedule.ForeColor = System.Drawing.Color.Blue;
            this.tree_clock_schedule.Location = new System.Drawing.Point(4, 15);
            this.tree_clock_schedule.Margin = new System.Windows.Forms.Padding(2);
            this.tree_clock_schedule.Name = "tree_clock_schedule";
            this.tree_clock_schedule.Size = new System.Drawing.Size(186, 223);
            this.tree_clock_schedule.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ota_apply);
            this.groupBox4.Controls.Add(this.btn_ota_update);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.input_ota_firmware_file);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.input_ota_port);
            this.groupBox4.Controls.Add(this.input_ota_ip);
            this.groupBox4.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.groupBox4.Location = new System.Drawing.Point(22, 179);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(494, 113);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Over-The-Air";
            // 
            // btn_ota_apply
            // 
            this.btn_ota_apply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ota_apply.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ota_apply.ForeColor = System.Drawing.Color.Black;
            this.btn_ota_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ota_apply.Location = new System.Drawing.Point(387, 46);
            this.btn_ota_apply.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ota_apply.Name = "btn_ota_apply";
            this.btn_ota_apply.Size = new System.Drawing.Size(103, 26);
            this.btn_ota_apply.TabIndex = 84;
            this.btn_ota_apply.Text = "apply";
            this.btn_ota_apply.UseVisualStyleBackColor = true;
            this.btn_ota_apply.Click += new System.EventHandler(this.btn_ota_apply_Click);
            // 
            // btn_ota_update
            // 
            this.btn_ota_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ota_update.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ota_update.ForeColor = System.Drawing.Color.Black;
            this.btn_ota_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ota_update.Location = new System.Drawing.Point(387, 78);
            this.btn_ota_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ota_update.Name = "btn_ota_update";
            this.btn_ota_update.Size = new System.Drawing.Size(103, 26);
            this.btn_ota_update.TabIndex = 83;
            this.btn_ota_update.Text = "start";
            this.btn_ota_update.UseVisualStyleBackColor = true;
            this.btn_ota_update.Click += new System.EventHandler(this.btn_ota_update_Click);
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(13, 78);
            this.textBox10.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 11);
            this.textBox10.TabIndex = 64;
            this.textBox10.Text = "file";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox10.WordWrap = false;
            // 
            // input_ota_firmware_file
            // 
            this.input_ota_firmware_file.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_ota_firmware_file.ForeColor = System.Drawing.Color.Blue;
            this.input_ota_firmware_file.Location = new System.Drawing.Point(100, 76);
            this.input_ota_firmware_file.Margin = new System.Windows.Forms.Padding(2);
            this.input_ota_firmware_file.Multiline = true;
            this.input_ota_firmware_file.Name = "input_ota_firmware_file";
            this.input_ota_firmware_file.Size = new System.Drawing.Size(220, 23);
            this.input_ota_firmware_file.TabIndex = 82;
            this.input_ota_firmware_file.Text = "firmware.bin";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(13, 51);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 11);
            this.textBox9.TabIndex = 63;
            this.textBox9.Text = "host_port";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox9.WordWrap = false;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("OCR A Extended", 7.8F);
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(13, 24);
            this.textBox8.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 11);
            this.textBox8.TabIndex = 57;
            this.textBox8.Text = "host";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox8.WordWrap = false;
            // 
            // input_ota_port
            // 
            this.input_ota_port.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_ota_port.ForeColor = System.Drawing.Color.Blue;
            this.input_ota_port.Location = new System.Drawing.Point(100, 49);
            this.input_ota_port.Margin = new System.Windows.Forms.Padding(2);
            this.input_ota_port.Multiline = true;
            this.input_ota_port.Name = "input_ota_port";
            this.input_ota_port.Size = new System.Drawing.Size(192, 23);
            this.input_ota_port.TabIndex = 81;
            this.input_ota_port.Text = "8070";
            // 
            // input_ota_ip
            // 
            this.input_ota_ip.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_ota_ip.ForeColor = System.Drawing.Color.Blue;
            this.input_ota_ip.Location = new System.Drawing.Point(100, 22);
            this.input_ota_ip.Margin = new System.Windows.Forms.Padding(2);
            this.input_ota_ip.Multiline = true;
            this.input_ota_ip.Name = "input_ota_ip";
            this.input_ota_ip.Size = new System.Drawing.Size(160, 23);
            this.input_ota_ip.TabIndex = 0;
            this.input_ota_ip.Text = "10.10.0.1";
            // 
            // lbl_clock
            // 
            this.lbl_clock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_clock.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.ForeColor = System.Drawing.Color.Blue;
            this.lbl_clock.Location = new System.Drawing.Point(213, 15);
            this.lbl_clock.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.lbl_clock.Multiline = true;
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(107, 43);
            this.lbl_clock.TabIndex = 58;
            this.lbl_clock.Text = "25.10.2021\r\n06:40";
            this.lbl_clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbl_clock.WordWrap = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(217, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 85;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(387, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 26);
            this.button2.TabIndex = 85;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(387, 72);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 26);
            this.button3.TabIndex = 86;
            this.button3.Text = "read";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // winform_remote_backdoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(540, 596);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "winform_remote_backdoor";
            this.Text = "ac-розетка";
            this.Load += new System.EventHandler(this.winform_remote_backdoor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_ac_dimming)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar track_ac_dimming;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lbl_ac_width_ms;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox lbl_zc_width_ms;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox input_ota_ip;
        private System.Windows.Forms.TextBox lbl_sram;
        private System.Windows.Forms.TextBox lbl_clock;
        private System.Windows.Forms.TextBox input_ota_port;
        private System.Windows.Forms.TextBox input_ota_firmware_file;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btn_ota_update;
        private System.Windows.Forms.TreeView tree_clock_schedule;
        private System.Windows.Forms.Button btn_clock_load;
        private System.Windows.Forms.Button btn_clock_save;
        private System.Windows.Forms.Button btn_ota_apply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

