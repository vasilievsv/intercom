using System.Drawing;
using System.Drawing.Imaging;

namespace app
{
    partial class winform_ESP32_AutoProgram
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
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_rts_1 = new System.Windows.Forms.CheckBox();
            this.check_dtr_1 = new System.Windows.Forms.CheckBox();
            this.pin_3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_rts_2 = new System.Windows.Forms.CheckBox();
            this.check_dtr_2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.check_rts_3 = new System.Windows.Forms.CheckBox();
            this.check_dtr_3 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.check_rts_4 = new System.Windows.Forms.CheckBox();
            this.check_dtr_4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.group_host = new System.Windows.Forms.GroupBox();
            this.group_target = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.group_host.SuspendLayout();
            this.group_target.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.check_rts_1);
            this.groupBox1.Controls.Add(this.check_dtr_1);
            this.groupBox1.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(97, 45);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // check_rts_1
            // 
            this.check_rts_1.AutoSize = true;
            this.check_rts_1.Checked = true;
            this.check_rts_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_rts_1.Location = new System.Drawing.Point(63, 19);
            this.check_rts_1.Name = "check_rts_1";
            this.check_rts_1.Size = new System.Drawing.Size(15, 14);
            this.check_rts_1.TabIndex = 100;
            this.check_rts_1.UseVisualStyleBackColor = true;
            this.check_rts_1.CheckedChanged += new System.EventHandler(this.cb_rts_Handler);
            // 
            // check_dtr_1
            // 
            this.check_dtr_1.AutoSize = true;
            this.check_dtr_1.Checked = true;
            this.check_dtr_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_dtr_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_dtr_1.Location = new System.Drawing.Point(16, 19);
            this.check_dtr_1.Name = "check_dtr_1";
            this.check_dtr_1.Size = new System.Drawing.Size(12, 11);
            this.check_dtr_1.TabIndex = 99;
            this.check_dtr_1.UseVisualStyleBackColor = true;
            this.check_dtr_1.CheckedChanged += new System.EventHandler(this.cb_dtr_Handler);
            // 
            // pin_3
            // 
            this.pin_3.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_3.ForeColor = System.Drawing.Color.Black;
            this.pin_3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_3.Location = new System.Drawing.Point(87, 437);
            this.pin_3.Margin = new System.Windows.Forms.Padding(2);
            this.pin_3.Name = "pin_3";
            this.pin_3.Size = new System.Drawing.Size(118, 27);
            this.pin_3.TabIndex = 98;
            this.pin_3.Text = "NEXT";
            this.pin_3.UseVisualStyleBackColor = true;
            this.pin_3.Click += new System.EventHandler(this.pin_group);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 102;
            this.label1.Text = "DTR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 103;
            this.label3.Text = "RTS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_rts_2);
            this.groupBox3.Controls.Add(this.check_dtr_2);
            this.groupBox3.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(97, 45);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            // 
            // check_rts_2
            // 
            this.check_rts_2.AutoSize = true;
            this.check_rts_2.Location = new System.Drawing.Point(63, 19);
            this.check_rts_2.Name = "check_rts_2";
            this.check_rts_2.Size = new System.Drawing.Size(15, 14);
            this.check_rts_2.TabIndex = 100;
            this.check_rts_2.UseVisualStyleBackColor = true;
            this.check_rts_2.CheckedChanged += new System.EventHandler(this.cb_rts_Handler);
            // 
            // check_dtr_2
            // 
            this.check_dtr_2.AutoSize = true;
            this.check_dtr_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_dtr_2.Location = new System.Drawing.Point(16, 19);
            this.check_dtr_2.Name = "check_dtr_2";
            this.check_dtr_2.Size = new System.Drawing.Size(12, 11);
            this.check_dtr_2.TabIndex = 99;
            this.check_dtr_2.UseVisualStyleBackColor = true;
            this.check_dtr_2.CheckedChanged += new System.EventHandler(this.cb_dtr_Handler);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.check_rts_3);
            this.groupBox4.Controls.Add(this.check_dtr_3);
            this.groupBox4.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 136);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(97, 45);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            // 
            // check_rts_3
            // 
            this.check_rts_3.AutoSize = true;
            this.check_rts_3.Location = new System.Drawing.Point(63, 19);
            this.check_rts_3.Name = "check_rts_3";
            this.check_rts_3.Size = new System.Drawing.Size(15, 14);
            this.check_rts_3.TabIndex = 100;
            this.check_rts_3.UseVisualStyleBackColor = true;
            this.check_rts_3.CheckedChanged += new System.EventHandler(this.cb_rts_Handler);
            // 
            // check_dtr_3
            // 
            this.check_dtr_3.AutoSize = true;
            this.check_dtr_3.Checked = true;
            this.check_dtr_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_dtr_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_dtr_3.Location = new System.Drawing.Point(16, 19);
            this.check_dtr_3.Name = "check_dtr_3";
            this.check_dtr_3.Size = new System.Drawing.Size(12, 11);
            this.check_dtr_3.TabIndex = 99;
            this.check_dtr_3.UseVisualStyleBackColor = true;
            this.check_dtr_3.CheckedChanged += new System.EventHandler(this.cb_dtr_Handler);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.check_rts_4);
            this.groupBox5.Controls.Add(this.check_dtr_4);
            this.groupBox5.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(10, 185);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(97, 45);
            this.groupBox5.TabIndex = 101;
            this.groupBox5.TabStop = false;
            // 
            // check_rts_4
            // 
            this.check_rts_4.AutoSize = true;
            this.check_rts_4.Checked = true;
            this.check_rts_4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_rts_4.Location = new System.Drawing.Point(63, 19);
            this.check_rts_4.Name = "check_rts_4";
            this.check_rts_4.Size = new System.Drawing.Size(15, 14);
            this.check_rts_4.TabIndex = 100;
            this.check_rts_4.UseVisualStyleBackColor = true;
            this.check_rts_4.CheckedChanged += new System.EventHandler(this.cb_rts_Handler);
            // 
            // check_dtr_4
            // 
            this.check_dtr_4.AutoSize = true;
            this.check_dtr_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_dtr_4.Location = new System.Drawing.Point(16, 19);
            this.check_dtr_4.Name = "check_dtr_4";
            this.check_dtr_4.Size = new System.Drawing.Size(12, 11);
            this.check_dtr_4.TabIndex = 99;
            this.check_dtr_4.UseVisualStyleBackColor = true;
            this.check_dtr_4.CheckedChanged += new System.EventHandler(this.cb_dtr_Handler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 104;
            this.label2.Text = "EN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 105;
            this.label4.Text = "BOOT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 9.857143F);
            this.label5.Location = new System.Drawing.Point(127, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 106;
            this.label5.Text = "AUTO PROGRAM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // group_host
            // 
            this.group_host.Controls.Add(this.groupBox1);
            this.group_host.Controls.Add(this.label3);
            this.group_host.Controls.Add(this.groupBox3);
            this.group_host.Controls.Add(this.label1);
            this.group_host.Controls.Add(this.groupBox4);
            this.group_host.Controls.Add(this.groupBox5);
            this.group_host.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_host.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_host.Location = new System.Drawing.Point(22, 47);
            this.group_host.Margin = new System.Windows.Forms.Padding(2);
            this.group_host.Name = "group_host";
            this.group_host.Padding = new System.Windows.Forms.Padding(2);
            this.group_host.Size = new System.Drawing.Size(118, 264);
            this.group_host.TabIndex = 103;
            this.group_host.TabStop = false;
            // 
            // group_target
            // 
            this.group_target.Controls.Add(this.groupBox6);
            this.group_target.Controls.Add(this.groupBox7);
            this.group_target.Controls.Add(this.label4);
            this.group_target.Controls.Add(this.groupBox8);
            this.group_target.Controls.Add(this.label2);
            this.group_target.Controls.Add(this.groupBox10);
            this.group_target.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_target.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_target.Location = new System.Drawing.Point(214, 47);
            this.group_target.Margin = new System.Windows.Forms.Padding(2);
            this.group_target.Name = "group_target";
            this.group_target.Padding = new System.Windows.Forms.Padding(2);
            this.group_target.Size = new System.Drawing.Size(118, 264);
            this.group_target.TabIndex = 104;
            this.group_target.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox9);
            this.groupBox6.Controls.Add(this.checkBox10);
            this.groupBox6.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(10, 38);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(97, 45);
            this.groupBox6.TabIndex = 86;
            this.groupBox6.TabStop = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(63, 19);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 100;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(16, 19);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 99;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox11);
            this.groupBox7.Controls.Add(this.checkBox12);
            this.groupBox7.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(10, 87);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(97, 45);
            this.groupBox7.TabIndex = 101;
            this.groupBox7.TabStop = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(63, 19);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(15, 14);
            this.checkBox11.TabIndex = 100;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(16, 19);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 99;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox13);
            this.groupBox8.Controls.Add(this.checkBox14);
            this.groupBox8.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(10, 136);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(97, 45);
            this.groupBox8.TabIndex = 101;
            this.groupBox8.TabStop = false;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Location = new System.Drawing.Point(63, 19);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 14);
            this.checkBox13.TabIndex = 100;
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(16, 19);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 14);
            this.checkBox14.TabIndex = 99;
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox15);
            this.groupBox10.Controls.Add(this.checkBox16);
            this.groupBox10.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(10, 185);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(97, 45);
            this.groupBox10.TabIndex = 101;
            this.groupBox10.TabStop = false;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(63, 19);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 14);
            this.checkBox15.TabIndex = 100;
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Checked = true;
            this.checkBox16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox16.Location = new System.Drawing.Point(16, 19);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 14);
            this.checkBox16.TabIndex = 99;
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // winform_ESP32_AutoProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(357, 374);
            this.Controls.Add(this.group_target);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pin_3);
            this.Controls.Add(this.group_host);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "winform_ESP32_AutoProgram";
            this.Text = "ESP32-TEST";
            this.Load += new System.EventHandler(this.winform_remote_backdoor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.group_host.ResumeLayout(false);
            this.group_host.PerformLayout();
            this.group_target.ResumeLayout(false);
            this.group_target.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pin_3;

        private System.Windows.Forms.CheckBox check_dtr_1;
        private System.Windows.Forms.CheckBox check_dtr_2;
        private System.Windows.Forms.CheckBox check_dtr_3;
        private System.Windows.Forms.CheckBox check_dtr_4;
        
        private System.Windows.Forms.CheckBox check_rts_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox check_rts_2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox check_rts_3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox check_rts_4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox group_host;
        private System.Windows.Forms.GroupBox group_target;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
    }
}

