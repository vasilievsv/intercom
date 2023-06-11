using System.Drawing;
using System.Drawing.Imaging;

namespace app
{
    partial class winform_ESP32_Configurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_ESP32_Configurator));
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
            this.group_host = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_tab1 = new System.Windows.Forms.Panel();
            this.var_esp_date = new System.Windows.Forms.Label();
            this.var_esp_time = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.var_esp_free_heap = new System.Windows.Forms.Label();
            this.var_esp_cpu_freq = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.var_esp_revision = new System.Windows.Forms.Label();
            this.var_esp_cores = new System.Windows.Forms.Label();
            this.var_esp_feature = new System.Windows.Forms.Label();
            this.var_esp_mode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_tab1_read = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_tab2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.group_host.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_tab2.SuspendLayout();
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
            this.pin_3.FlatAppearance.BorderSize = 0;
            this.pin_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pin_3.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_3.ForeColor = System.Drawing.Color.Black;
            this.pin_3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_3.Location = new System.Drawing.Point(438, 6);
            this.pin_3.Margin = new System.Windows.Forms.Padding(2);
            this.pin_3.Name = "pin_3";
            this.pin_3.Size = new System.Drawing.Size(103, 35);
            this.pin_3.TabIndex = 98;
            this.pin_3.Text = "TAB";
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
            this.group_host.Location = new System.Drawing.Point(202, 559);
            this.group_host.Margin = new System.Windows.Forms.Padding(2);
            this.group_host.Name = "group_host";
            this.group_host.Padding = new System.Windows.Forms.Padding(2);
            this.group_host.Size = new System.Drawing.Size(118, 264);
            this.group_host.TabIndex = 103;
            this.group_host.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 440);
            this.panel1.TabIndex = 109;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(82, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(256, 256);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(560, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 110;
            this.button1.Text = "TAB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(682, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 111;
            this.button2.Text = "TAB";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel_tab1
            // 
            this.panel_tab1.BackColor = System.Drawing.Color.White;
            this.panel_tab1.Controls.Add(this.var_esp_date);
            this.panel_tab1.Controls.Add(this.var_esp_time);
            this.panel_tab1.Controls.Add(this.label10);
            this.panel_tab1.Controls.Add(this.label9);
            this.panel_tab1.Controls.Add(this.var_esp_free_heap);
            this.panel_tab1.Controls.Add(this.var_esp_cpu_freq);
            this.panel_tab1.Controls.Add(this.label8);
            this.panel_tab1.Controls.Add(this.label7);
            this.panel_tab1.Controls.Add(this.var_esp_revision);
            this.panel_tab1.Controls.Add(this.var_esp_cores);
            this.panel_tab1.Controls.Add(this.var_esp_feature);
            this.panel_tab1.Controls.Add(this.var_esp_mode);
            this.panel_tab1.Controls.Add(this.label6);
            this.panel_tab1.Controls.Add(this.label5);
            this.panel_tab1.Controls.Add(this.btn_tab1_read);
            this.panel_tab1.Controls.Add(this.label2);
            this.panel_tab1.Controls.Add(this.label4);
            this.panel_tab1.Location = new System.Drawing.Point(438, 52);
            this.panel_tab1.Name = "panel_tab1";
            this.panel_tab1.Size = new System.Drawing.Size(362, 392);
            this.panel_tab1.TabIndex = 110;
            // 
            // var_esp_date
            // 
            this.var_esp_date.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_date.Location = new System.Drawing.Point(200, 242);
            this.var_esp_date.Name = "var_esp_date";
            this.var_esp_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_date.Size = new System.Drawing.Size(143, 17);
            this.var_esp_date.TabIndex = 124;
            this.var_esp_date.Text = "-";
            this.var_esp_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_esp_time
            // 
            this.var_esp_time.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_time.Location = new System.Drawing.Point(200, 210);
            this.var_esp_time.Name = "var_esp_time";
            this.var_esp_time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_time.Size = new System.Drawing.Size(143, 17);
            this.var_esp_time.TabIndex = 123;
            this.var_esp_time.Text = "-";
            this.var_esp_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 17);
            this.label10.TabIndex = 122;
            this.label10.Text = "esp_date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 121;
            this.label9.Text = "esp_time:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // var_esp_free_heap
            // 
            this.var_esp_free_heap.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_free_heap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_free_heap.Location = new System.Drawing.Point(200, 178);
            this.var_esp_free_heap.Name = "var_esp_free_heap";
            this.var_esp_free_heap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_free_heap.Size = new System.Drawing.Size(143, 17);
            this.var_esp_free_heap.TabIndex = 120;
            this.var_esp_free_heap.Text = "-";
            this.var_esp_free_heap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_esp_cpu_freq
            // 
            this.var_esp_cpu_freq.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_cpu_freq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_cpu_freq.Location = new System.Drawing.Point(200, 146);
            this.var_esp_cpu_freq.Name = "var_esp_cpu_freq";
            this.var_esp_cpu_freq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_cpu_freq.Size = new System.Drawing.Size(143, 17);
            this.var_esp_cpu_freq.TabIndex = 119;
            this.var_esp_cpu_freq.Text = "-";
            this.var_esp_cpu_freq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 118;
            this.label8.Text = "free_heap:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 117;
            this.label7.Text = "cpu_freq:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // var_esp_revision
            // 
            this.var_esp_revision.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_revision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_revision.Location = new System.Drawing.Point(200, 114);
            this.var_esp_revision.Name = "var_esp_revision";
            this.var_esp_revision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_revision.Size = new System.Drawing.Size(143, 17);
            this.var_esp_revision.TabIndex = 116;
            this.var_esp_revision.Text = "-";
            this.var_esp_revision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_esp_cores
            // 
            this.var_esp_cores.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_cores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_cores.Location = new System.Drawing.Point(200, 82);
            this.var_esp_cores.Name = "var_esp_cores";
            this.var_esp_cores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_cores.Size = new System.Drawing.Size(143, 17);
            this.var_esp_cores.TabIndex = 115;
            this.var_esp_cores.Text = "-";
            this.var_esp_cores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_esp_feature
            // 
            this.var_esp_feature.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_feature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_feature.Location = new System.Drawing.Point(200, 50);
            this.var_esp_feature.Name = "var_esp_feature";
            this.var_esp_feature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_feature.Size = new System.Drawing.Size(143, 17);
            this.var_esp_feature.TabIndex = 114;
            this.var_esp_feature.Text = "-";
            this.var_esp_feature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_esp_mode
            // 
            this.var_esp_mode.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_mode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_mode.Location = new System.Drawing.Point(200, 18);
            this.var_esp_mode.Name = "var_esp_mode";
            this.var_esp_mode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_mode.Size = new System.Drawing.Size(143, 17);
            this.var_esp_mode.TabIndex = 113;
            this.var_esp_mode.Text = "-";
            this.var_esp_mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "revision:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "cores:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_tab1_read
            // 
            this.btn_tab1_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab1_read.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.btn_tab1_read.ForeColor = System.Drawing.Color.Black;
            this.btn_tab1_read.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tab1_read.Location = new System.Drawing.Point(122, 343);
            this.btn_tab1_read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tab1_read.Name = "btn_tab1_read";
            this.btn_tab1_read.Size = new System.Drawing.Size(118, 35);
            this.btn_tab1_read.TabIndex = 112;
            this.btn_tab1_read.Text = "READ";
            this.btn_tab1_read.UseVisualStyleBackColor = true;
            this.btn_tab1_read.Click += new System.EventHandler(this.btn_tab1_read_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "features:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "model:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(668, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 35);
            this.pictureBox3.TabIndex = 116;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(546, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 35);
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(431, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 440);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // panel_tab2
            // 
            this.panel_tab2.BackColor = System.Drawing.Color.White;
            this.panel_tab2.Controls.Add(this.button3);
            this.panel_tab2.Location = new System.Drawing.Point(811, 54);
            this.panel_tab2.Name = "panel_tab2";
            this.panel_tab2.Size = new System.Drawing.Size(362, 392);
            this.panel_tab2.TabIndex = 125;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(122, 343);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 35);
            this.button3.TabIndex = 112;
            this.button3.Text = "APPLY";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // winform_ESP32_Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 458);
            this.Controls.Add(this.panel_tab2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_tab1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.group_host);
            this.Controls.Add(this.pin_3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "winform_ESP32_Configurator";
            this.Text = "ESP32 - Configurator";
            this.Load += new System.EventHandler(this.winform_remote_backdoor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.group_host.ResumeLayout(false);
            this.group_host.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_tab2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox group_host;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_tab1;
        private System.Windows.Forms.Button btn_tab1_read;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label var_esp_revision;
        private System.Windows.Forms.Label var_esp_cores;
        private System.Windows.Forms.Label var_esp_feature;
        private System.Windows.Forms.Label var_esp_mode;
        private System.Windows.Forms.Label var_esp_free_heap;
        private System.Windows.Forms.Label var_esp_cpu_freq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label var_esp_date;
        private System.Windows.Forms.Label var_esp_time;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_tab2;
        private System.Windows.Forms.Button button3;
    }
}

