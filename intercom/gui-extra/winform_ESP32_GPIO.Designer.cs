using System.Drawing;
using System.Drawing.Imaging;

namespace app
{
    partial class winform_ESP32_GPIO
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_clock_load = new System.Windows.Forms.Button();
            this.tree_clock_schedule = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pin_4 = new System.Windows.Forms.Button();
            this.pin_3 = new System.Windows.Forms.Button();
            this.pin_2 = new System.Windows.Forms.Button();
            this.pin_7 = new System.Windows.Forms.Button();
            this.pin_1 = new System.Windows.Forms.Button();
            this.pin_9 = new System.Windows.Forms.Button();
            this.pin_8 = new System.Windows.Forms.Button();
            this.pin_5 = new System.Windows.Forms.Button();
            this.pin_6 = new System.Windows.Forms.Button();
            this.lbl_app_mode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.btn_clock_load);
            this.groupBox7.Controls.Add(this.tree_clock_schedule);
            this.groupBox7.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(20, 277);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(293, 153);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Demo";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.Location = new System.Drawing.Point(212, 116);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 26);
            this.button11.TabIndex = 86;
            this.button11.Text = "r";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(11, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 85;
            this.button1.Text = "download";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_clock_load
            // 
            this.btn_clock_load.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clock_load.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.btn_clock_load.ForeColor = System.Drawing.Color.Black;
            this.btn_clock_load.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clock_load.Location = new System.Drawing.Point(104, 116);
            this.btn_clock_load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clock_load.Name = "btn_clock_load";
            this.btn_clock_load.Size = new System.Drawing.Size(90, 26);
            this.btn_clock_load.TabIndex = 84;
            this.btn_clock_load.Text = "delete";
            this.btn_clock_load.UseVisualStyleBackColor = true;
            // 
            // tree_clock_schedule
            // 
            this.tree_clock_schedule.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.tree_clock_schedule.ForeColor = System.Drawing.Color.Blue;
            this.tree_clock_schedule.Location = new System.Drawing.Point(11, 17);
            this.tree_clock_schedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tree_clock_schedule.Name = "tree_clock_schedule";
            this.tree_clock_schedule.Size = new System.Drawing.Size(274, 96);
            this.tree_clock_schedule.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pin_4);
            this.groupBox1.Controls.Add(this.pin_3);
            this.groupBox1.Controls.Add(this.pin_2);
            this.groupBox1.Controls.Add(this.pin_7);
            this.groupBox1.Controls.Add(this.pin_1);
            this.groupBox1.Controls.Add(this.pin_9);
            this.groupBox1.Controls.Add(this.pin_8);
            this.groupBox1.Controls.Add(this.pin_5);
            this.groupBox1.Controls.Add(this.pin_6);
            this.groupBox1.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 114);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPIO";
            // 
            // pin_4
            // 
            this.pin_4.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_4.ForeColor = System.Drawing.Color.Black;
            this.pin_4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_4.Location = new System.Drawing.Point(89, 17);
            this.pin_4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_4.Name = "pin_4";
            this.pin_4.Size = new System.Drawing.Size(39, 39);
            this.pin_4.TabIndex = 99;
            this.pin_4.Text = "4";
            this.pin_4.UseVisualStyleBackColor = true;
            this.pin_4.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_3
            // 
            this.pin_3.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_3.ForeColor = System.Drawing.Color.Black;
            this.pin_3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_3.Location = new System.Drawing.Point(133, 17);
            this.pin_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_3.Name = "pin_3";
            this.pin_3.Size = new System.Drawing.Size(39, 39);
            this.pin_3.TabIndex = 98;
            this.pin_3.Text = "3";
            this.pin_3.UseVisualStyleBackColor = true;
            this.pin_3.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_2
            // 
            this.pin_2.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_2.ForeColor = System.Drawing.Color.Black;
            this.pin_2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_2.Location = new System.Drawing.Point(177, 17);
            this.pin_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_2.Name = "pin_2";
            this.pin_2.Size = new System.Drawing.Size(39, 39);
            this.pin_2.TabIndex = 97;
            this.pin_2.Text = "2";
            this.pin_2.UseVisualStyleBackColor = true;
            this.pin_2.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_7
            // 
            this.pin_7.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_7.ForeColor = System.Drawing.Color.Black;
            this.pin_7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_7.Location = new System.Drawing.Point(155, 61);
            this.pin_7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_7.Name = "pin_7";
            this.pin_7.Size = new System.Drawing.Size(39, 39);
            this.pin_7.TabIndex = 102;
            this.pin_7.Text = "7";
            this.pin_7.UseVisualStyleBackColor = true;
            this.pin_7.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_1
            // 
            this.pin_1.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_1.ForeColor = System.Drawing.Color.Black;
            this.pin_1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_1.Location = new System.Drawing.Point(220, 17);
            this.pin_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_1.Name = "pin_1";
            this.pin_1.Size = new System.Drawing.Size(39, 39);
            this.pin_1.TabIndex = 95;
            this.pin_1.Text = "1";
            this.pin_1.UseVisualStyleBackColor = true;
            this.pin_1.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_9
            // 
            this.pin_9.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_9.ForeColor = System.Drawing.Color.Black;
            this.pin_9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_9.Location = new System.Drawing.Point(67, 61);
            this.pin_9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_9.Name = "pin_9";
            this.pin_9.Size = new System.Drawing.Size(39, 39);
            this.pin_9.TabIndex = 95;
            this.pin_9.Text = "9";
            this.pin_9.UseVisualStyleBackColor = true;
            this.pin_9.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_8
            // 
            this.pin_8.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_8.ForeColor = System.Drawing.Color.Black;
            this.pin_8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_8.Location = new System.Drawing.Point(111, 61);
            this.pin_8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_8.Name = "pin_8";
            this.pin_8.Size = new System.Drawing.Size(39, 39);
            this.pin_8.TabIndex = 103;
            this.pin_8.Text = "8";
            this.pin_8.UseVisualStyleBackColor = true;
            this.pin_8.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_5
            // 
            this.pin_5.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_5.ForeColor = System.Drawing.Color.Black;
            this.pin_5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_5.Location = new System.Drawing.Point(46, 17);
            this.pin_5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_5.Name = "pin_5";
            this.pin_5.Size = new System.Drawing.Size(39, 39);
            this.pin_5.TabIndex = 100;
            this.pin_5.Text = "5";
            this.pin_5.UseVisualStyleBackColor = true;
            this.pin_5.Click += new System.EventHandler(this.pin_group);
            // 
            // pin_6
            // 
            this.pin_6.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_6.ForeColor = System.Drawing.Color.Black;
            this.pin_6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_6.Location = new System.Drawing.Point(199, 61);
            this.pin_6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pin_6.Name = "pin_6";
            this.pin_6.Size = new System.Drawing.Size(39, 39);
            this.pin_6.TabIndex = 101;
            this.pin_6.Text = "6";
            this.pin_6.UseVisualStyleBackColor = true;
            this.pin_6.Click += new System.EventHandler(this.pin_group);
            // 
            // lbl_app_mode
            // 
            this.lbl_app_mode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_app_mode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_app_mode.Location = new System.Drawing.Point(20, 11);
            this.lbl_app_mode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_app_mode.Name = "lbl_app_mode";
            this.lbl_app_mode.Size = new System.Drawing.Size(289, 31);
            this.lbl_app_mode.TabIndex = 87;
            this.lbl_app_mode.Text = "Режим: Ответ";
            this.lbl_app_mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(293, 72);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(186, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 39);
            this.button4.TabIndex = 106;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.app_state_group);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(133, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 105;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.app_state_group);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(81, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 39);
            this.button2.TabIndex = 104;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.app_state_group);
            // 
            // winform_ESP32_GPIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(326, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_app_mode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "winform_ESP32_GPIO";
            this.Text = "ЦИР Smart-Wire";
            this.Load += new System.EventHandler(this.winform_remote_backdoor_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TreeView tree_clock_schedule;
        private System.Windows.Forms.Button btn_clock_load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button pin_4;
        private System.Windows.Forms.Button pin_3;
        private System.Windows.Forms.Button pin_2;
        private System.Windows.Forms.Button pin_1;
        private System.Windows.Forms.Button pin_9;
        private System.Windows.Forms.Button pin_8;
        private System.Windows.Forms.Button pin_5;
        private System.Windows.Forms.Button pin_7;
        private System.Windows.Forms.Button pin_6;
        private System.Windows.Forms.Label lbl_app_mode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

