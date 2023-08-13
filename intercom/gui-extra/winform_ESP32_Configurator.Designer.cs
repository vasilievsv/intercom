using System.Drawing;
using System.Drawing.Imaging;

namespace app
{
    partial class winform_ESP32_Configurator
    {
        object values = new object[]
        {
                        new { Text = "ENABLE", Value = "1" },
                        new { Text = "DISABLE", Value = "0" }
        };

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_ESP32_Configurator));
            this.btn_tab1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_tab2 = new System.Windows.Forms.Button();
            this.btn_tab3 = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_tab2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.var_esp_gpio_mode = new System.Windows.Forms.ComboBox();
            this.var_esp_gpio_intr_type = new System.Windows.Forms.ComboBox();
            this.var_esp_gpio_pull_up_en = new System.Windows.Forms.ComboBox();
            this.var_esp_gpio_pull_down_en = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.var_esp_gpio_pin_bit_mask = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel_tab3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.var_ota_path = new System.Windows.Forms.TextBox();
            this.var_ota_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.var_ota_host = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.var_ota_last_firmware = new System.Windows.Forms.Label();
            this.btn_ota_start = new System.Windows.Forms.Button();
            this.tab_render = new System.Windows.Forms.PictureBox();
            this.winformESP32ConfiguratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_tab2.SuspendLayout();
            this.panel_tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_render)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winformESP32ConfiguratorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tab1
            // 
            this.btn_tab1.FlatAppearance.BorderSize = 0;
            this.btn_tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tab1.ForeColor = System.Drawing.Color.Black;
            this.btn_tab1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tab1.Location = new System.Drawing.Point(438, 6);
            this.btn_tab1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tab1.Name = "btn_tab1";
            this.btn_tab1.Size = new System.Drawing.Size(103, 35);
            this.btn_tab1.TabIndex = 98;
            this.btn_tab1.Text = "INFO";
            this.btn_tab1.UseVisualStyleBackColor = true;
            this.btn_tab1.Click += new System.EventHandler(this.btn_pin_group_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 440);
            this.panel1.TabIndex = 109;
            // 
            // label39
            // 
            this.label39.AutoEllipsis = true;
            this.label39.BackColor = System.Drawing.Color.Salmon;
            this.label39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(296, 362);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(40, 16);
            this.label39.TabIndex = 153;
            this.label39.Text = "SD0";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label39.UseCompatibleTextRendering = true;
            this.label39.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label38
            // 
            this.label38.AutoEllipsis = true;
            this.label38.BackColor = System.Drawing.Color.Salmon;
            this.label38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(296, 345);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 16);
            this.label38.TabIndex = 152;
            this.label38.Text = "SD1";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label38.UseCompatibleTextRendering = true;
            this.label38.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label37
            // 
            this.label37.AutoEllipsis = true;
            this.label37.BackColor = System.Drawing.Color.Salmon;
            this.label37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(296, 328);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 16);
            this.label37.TabIndex = 151;
            this.label37.Text = "IO15";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label37.UseCompatibleTextRendering = true;
            this.label37.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label36
            // 
            this.label36.AutoEllipsis = true;
            this.label36.BackColor = System.Drawing.Color.Salmon;
            this.label36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(296, 311);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(40, 16);
            this.label36.TabIndex = 150;
            this.label36.Text = "IO2";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.UseCompatibleTextRendering = true;
            this.label36.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label35
            // 
            this.label35.AutoEllipsis = true;
            this.label35.BackColor = System.Drawing.Color.Salmon;
            this.label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(296, 293);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 16);
            this.label35.TabIndex = 149;
            this.label35.Text = "IO0";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.UseCompatibleTextRendering = true;
            this.label35.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label34
            // 
            this.label34.AutoEllipsis = true;
            this.label34.BackColor = System.Drawing.Color.Salmon;
            this.label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(84, 362);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 16);
            this.label34.TabIndex = 148;
            this.label34.Text = "SD3";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.UseCompatibleTextRendering = true;
            this.label34.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label33
            // 
            this.label33.AutoEllipsis = true;
            this.label33.BackColor = System.Drawing.Color.Salmon;
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(84, 345);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 16);
            this.label33.TabIndex = 147;
            this.label33.Text = "SD2";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label33.UseCompatibleTextRendering = true;
            this.label33.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label32
            // 
            this.label32.AutoEllipsis = true;
            this.label32.BackColor = System.Drawing.Color.Salmon;
            this.label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(84, 328);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 16);
            this.label32.TabIndex = 146;
            this.label32.Text = "IO13";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label32.UseCompatibleTextRendering = true;
            this.label32.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label30
            // 
            this.label30.AutoEllipsis = true;
            this.label30.BackColor = System.Drawing.Color.Salmon;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(296, 88);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(40, 16);
            this.label30.TabIndex = 145;
            this.label30.Text = "IO5";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label30.UseCompatibleTextRendering = true;
            this.label30.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label29
            // 
            this.label29.AutoEllipsis = true;
            this.label29.BackColor = System.Drawing.Color.Salmon;
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(296, 105);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 16);
            this.label29.TabIndex = 144;
            this.label29.Text = "IO22";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label29.UseCompatibleTextRendering = true;
            this.label29.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label28
            // 
            this.label28.AutoEllipsis = true;
            this.label28.BackColor = System.Drawing.Color.Salmon;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(296, 122);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 16);
            this.label28.TabIndex = 143;
            this.label28.Text = "TX0";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label28.UseCompatibleTextRendering = true;
            this.label28.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label27
            // 
            this.label27.AutoEllipsis = true;
            this.label27.BackColor = System.Drawing.Color.Salmon;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(296, 138);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 16);
            this.label27.TabIndex = 142;
            this.label27.Text = "RX0";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.UseCompatibleTextRendering = true;
            this.label27.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label26
            // 
            this.label26.AutoEllipsis = true;
            this.label26.BackColor = System.Drawing.Color.Salmon;
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(296, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 16);
            this.label26.TabIndex = 141;
            this.label26.Text = "IO21";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.UseCompatibleTextRendering = true;
            this.label26.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label25
            // 
            this.label25.AutoEllipsis = true;
            this.label25.BackColor = System.Drawing.Color.Salmon;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(296, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 16);
            this.label25.TabIndex = 140;
            this.label25.Text = "IO19";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.UseCompatibleTextRendering = true;
            this.label25.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.BackColor = System.Drawing.Color.Salmon;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(296, 209);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 16);
            this.label24.TabIndex = 139;
            this.label24.Text = "IO18";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label24.UseCompatibleTextRendering = true;
            this.label24.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.BackColor = System.Drawing.Color.Salmon;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(296, 226);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 16);
            this.label23.TabIndex = 138;
            this.label23.Text = "IO5";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.UseCompatibleTextRendering = true;
            this.label23.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label22
            // 
            this.label22.AutoEllipsis = true;
            this.label22.BackColor = System.Drawing.Color.Salmon;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(296, 243);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 16);
            this.label22.TabIndex = 137;
            this.label22.Text = "IO17";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.UseCompatibleTextRendering = true;
            this.label22.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label21
            // 
            this.label21.AutoEllipsis = true;
            this.label21.BackColor = System.Drawing.Color.Salmon;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(296, 259);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 16);
            this.label21.TabIndex = 136;
            this.label21.Text = "IO16";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.UseCompatibleTextRendering = true;
            this.label21.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label20
            // 
            this.label20.AutoEllipsis = true;
            this.label20.BackColor = System.Drawing.Color.Salmon;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(296, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 135;
            this.label20.Text = "IO4";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.UseCompatibleTextRendering = true;
            this.label20.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label19
            // 
            this.label19.AutoEllipsis = true;
            this.label19.BackColor = System.Drawing.Color.Salmon;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(84, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 16);
            this.label19.TabIndex = 134;
            this.label19.Text = "IO34";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.UseCompatibleTextRendering = true;
            this.label19.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label18
            // 
            this.label18.AutoEllipsis = true;
            this.label18.BackColor = System.Drawing.Color.Salmon;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(84, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 133;
            this.label18.Text = "IO35";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.UseCompatibleTextRendering = true;
            this.label18.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.label17.BackColor = System.Drawing.Color.Salmon;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(84, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 16);
            this.label17.TabIndex = 132;
            this.label17.Text = "IO33";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.UseCompatibleTextRendering = true;
            this.label17.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.BackColor = System.Drawing.Color.Salmon;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(84, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 131;
            this.label16.Text = "IO32";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.label15.BackColor = System.Drawing.Color.Salmon;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 130;
            this.label15.Text = "IO25";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.UseCompatibleTextRendering = true;
            this.label15.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.BackColor = System.Drawing.Color.Salmon;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(84, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 129;
            this.label14.Text = "IO26";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.UseCompatibleTextRendering = true;
            this.label14.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.BackColor = System.Drawing.Color.Salmon;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 128;
            this.label13.Text = "IO27";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.UseCompatibleTextRendering = true;
            this.label13.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.BackColor = System.Drawing.Color.Salmon;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 128;
            this.label12.Text = "IO14";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.UseCompatibleTextRendering = true;
            this.label12.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.BackColor = System.Drawing.Color.Salmon;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 127;
            this.label11.Text = "IO12";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.UseCompatibleTextRendering = true;
            this.label11.Click += new System.EventHandler(this.cmd_select_pin);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(31, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(360, 360);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btn_tab2
            // 
            this.btn_tab2.FlatAppearance.BorderSize = 0;
            this.btn_tab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab2.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tab2.ForeColor = System.Drawing.Color.Black;
            this.btn_tab2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tab2.Location = new System.Drawing.Point(560, 6);
            this.btn_tab2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tab2.Name = "btn_tab2";
            this.btn_tab2.Size = new System.Drawing.Size(103, 35);
            this.btn_tab2.TabIndex = 110;
            this.btn_tab2.Text = "GPIO";
            this.btn_tab2.UseVisualStyleBackColor = true;
            this.btn_tab2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tab3
            // 
            this.btn_tab3.FlatAppearance.BorderSize = 0;
            this.btn_tab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab3.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tab3.ForeColor = System.Drawing.Color.Black;
            this.btn_tab3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tab3.Location = new System.Drawing.Point(682, 6);
            this.btn_tab3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tab3.Name = "btn_tab3";
            this.btn_tab3.Size = new System.Drawing.Size(118, 35);
            this.btn_tab3.TabIndex = 111;
            this.btn_tab3.Text = "OTA";
            this.btn_tab3.UseVisualStyleBackColor = true;
            this.btn_tab3.Click += new System.EventHandler(this.button2_Click);
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
            this.panel_tab1.Controls.Add(this.label2);
            this.panel_tab1.Controls.Add(this.label4);
            this.panel_tab1.Location = new System.Drawing.Point(497, 142);
            this.panel_tab1.Name = "panel_tab1";
            this.panel_tab1.Size = new System.Drawing.Size(362, 392);
            this.panel_tab1.TabIndex = 110;
            // 
            // var_esp_date
            // 
            this.var_esp_date.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_date.Location = new System.Drawing.Point(168, 144);
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
            this.var_esp_time.Location = new System.Drawing.Point(168, 126);
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
            this.label10.Location = new System.Drawing.Point(16, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 17);
            this.label10.TabIndex = 122;
            this.label10.Text = "esp_date:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 126);
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
            this.var_esp_free_heap.Location = new System.Drawing.Point(168, 109);
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
            this.var_esp_cpu_freq.Location = new System.Drawing.Point(168, 91);
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
            this.label8.Location = new System.Drawing.Point(16, 109);
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
            this.label7.Location = new System.Drawing.Point(16, 91);
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
            this.var_esp_revision.Location = new System.Drawing.Point(168, 74);
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
            this.var_esp_cores.Location = new System.Drawing.Point(168, 57);
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
            this.var_esp_feature.Location = new System.Drawing.Point(168, 39);
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
            this.var_esp_mode.Location = new System.Drawing.Point(168, 18);
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
            this.label6.Location = new System.Drawing.Point(16, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "revision:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "cores:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 39);
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
            this.panel_tab2.Controls.Add(this.button1);
            this.panel_tab2.Controls.Add(this.var_esp_gpio_mode);
            this.panel_tab2.Controls.Add(this.var_esp_gpio_intr_type);
            this.panel_tab2.Controls.Add(this.var_esp_gpio_pull_up_en);
            this.panel_tab2.Controls.Add(this.var_esp_gpio_pull_down_en);
            this.panel_tab2.Controls.Add(this.label43);
            this.panel_tab2.Controls.Add(this.var_esp_gpio_pin_bit_mask);
            this.panel_tab2.Controls.Add(this.label42);
            this.panel_tab2.Controls.Add(this.label41);
            this.panel_tab2.Controls.Add(this.label40);
            this.panel_tab2.Controls.Add(this.label31);
            this.panel_tab2.Location = new System.Drawing.Point(477, 126);
            this.panel_tab2.Name = "panel_tab2";
            this.panel_tab2.Size = new System.Drawing.Size(362, 392);
            this.panel_tab2.TabIndex = 125;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(122, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 127;
            this.button1.Text = "APPLY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cmd_write_gpio);
            // 
            // var_esp_gpio_mode
            // 
            this.var_esp_gpio_mode.DisplayMember = "Key";
            this.var_esp_gpio_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.var_esp_gpio_mode.FormattingEnabled = true;
            this.var_esp_gpio_mode.Location = new System.Drawing.Point(159, 177);
            this.var_esp_gpio_mode.Name = "var_esp_gpio_mode";
            this.var_esp_gpio_mode.Size = new System.Drawing.Size(200, 21);
            this.var_esp_gpio_mode.TabIndex = 134;
            this.var_esp_gpio_mode.ValueMember = "Value";
            // 
            // var_esp_gpio_intr_type
            // 
            this.var_esp_gpio_intr_type.DisplayMember = "Key";
            this.var_esp_gpio_intr_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.var_esp_gpio_intr_type.FormattingEnabled = true;
            this.var_esp_gpio_intr_type.Location = new System.Drawing.Point(159, 141);
            this.var_esp_gpio_intr_type.Name = "var_esp_gpio_intr_type";
            this.var_esp_gpio_intr_type.Size = new System.Drawing.Size(200, 21);
            this.var_esp_gpio_intr_type.TabIndex = 133;
            this.var_esp_gpio_intr_type.ValueMember = "Value";
            // 
            // var_esp_gpio_pull_up_en
            // 
            this.var_esp_gpio_pull_up_en.DisplayMember = "Key";
            this.var_esp_gpio_pull_up_en.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.var_esp_gpio_pull_up_en.Items.AddRange(new object[] {
            "ENABLE",
            "DISABLE"});
            this.var_esp_gpio_pull_up_en.Location = new System.Drawing.Point(159, 83);
            this.var_esp_gpio_pull_up_en.Name = "var_esp_gpio_pull_up_en";
            this.var_esp_gpio_pull_up_en.Size = new System.Drawing.Size(200, 21);
            this.var_esp_gpio_pull_up_en.TabIndex = 132;
            this.var_esp_gpio_pull_up_en.ValueMember = "Key";
            // 
            // var_esp_gpio_pull_down_en
            // 
            this.var_esp_gpio_pull_down_en.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.var_esp_gpio_pull_down_en.DisplayMember = "Key";
            this.var_esp_gpio_pull_down_en.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.var_esp_gpio_pull_down_en.Items.AddRange(new object[] {
            "ENABLE",
            "DISABLE"});
            this.var_esp_gpio_pull_down_en.Location = new System.Drawing.Point(159, 109);
            this.var_esp_gpio_pull_down_en.Name = "var_esp_gpio_pull_down_en";
            this.var_esp_gpio_pull_down_en.Size = new System.Drawing.Size(200, 21);
            this.var_esp_gpio_pull_down_en.TabIndex = 131;
            this.var_esp_gpio_pull_down_en.ValueMember = "Value";
            // 
            // label43
            // 
            this.label43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label43.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(5, 111);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(148, 17);
            this.label43.TabIndex = 127;
            this.label43.Text = "pull_down_en:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // var_esp_gpio_pin_bit_mask
            // 
            this.var_esp_gpio_pin_bit_mask.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_esp_gpio_pin_bit_mask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.var_esp_gpio_pin_bit_mask.Location = new System.Drawing.Point(159, 35);
            this.var_esp_gpio_pin_bit_mask.Name = "var_esp_gpio_pin_bit_mask";
            this.var_esp_gpio_pin_bit_mask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_esp_gpio_pin_bit_mask.Size = new System.Drawing.Size(143, 17);
            this.var_esp_gpio_pin_bit_mask.TabIndex = 127;
            this.var_esp_gpio_pin_bit_mask.Text = "-";
            this.var_esp_gpio_pin_bit_mask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            this.label42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label42.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(5, 85);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(148, 17);
            this.label42.TabIndex = 126;
            this.label42.Text = "pull_up_en:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label41.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(5, 35);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(148, 17);
            this.label41.TabIndex = 125;
            this.label41.Text = "pin_bit_mask:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label40.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(5, 179);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(148, 17);
            this.label40.TabIndex = 125;
            this.label40.Text = "mode:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label31.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(5, 143);
            this.label31.Name = "label31";
            this.label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label31.Size = new System.Drawing.Size(148, 17);
            this.label31.TabIndex = 113;
            this.label31.Text = "intr_type:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_tab3
            // 
            this.panel_tab3.BackColor = System.Drawing.Color.White;
            this.panel_tab3.Controls.Add(this.button3);
            this.panel_tab3.Controls.Add(this.label44);
            this.panel_tab3.Controls.Add(this.var_ota_path);
            this.panel_tab3.Controls.Add(this.var_ota_port);
            this.panel_tab3.Controls.Add(this.label3);
            this.panel_tab3.Controls.Add(this.var_ota_host);
            this.panel_tab3.Controls.Add(this.button2);
            this.panel_tab3.Controls.Add(this.var_ota_last_firmware);
            this.panel_tab3.Controls.Add(this.btn_ota_start);
            this.panel_tab3.Location = new System.Drawing.Point(446, 92);
            this.panel_tab3.Name = "panel_tab3";
            this.panel_tab3.Size = new System.Drawing.Size(362, 383);
            this.panel_tab3.TabIndex = 126;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(14, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 35);
            this.button3.TabIndex = 135;
            this.button3.Text = "READ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_ota_struct_read);
            // 
            // label44
            // 
            this.label44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label44.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(6, 98);
            this.label44.Name = "label44";
            this.label44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label44.Size = new System.Drawing.Size(113, 17);
            this.label44.TabIndex = 133;
            this.label44.Text = "path";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // var_ota_path
            // 
            this.var_ota_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.var_ota_path.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.var_ota_path.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.var_ota_path.Location = new System.Drawing.Point(128, 96);
            this.var_ota_path.Name = "var_ota_path";
            this.var_ota_path.Size = new System.Drawing.Size(197, 24);
            this.var_ota_path.TabIndex = 132;
            this.var_ota_path.Text = "firmware.bin";
            // 
            // var_ota_port
            // 
            this.var_ota_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.var_ota_port.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.var_ota_port.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.var_ota_port.Location = new System.Drawing.Point(128, 65);
            this.var_ota_port.Name = "var_ota_port";
            this.var_ota_port.Size = new System.Drawing.Size(197, 24);
            this.var_ota_port.TabIndex = 131;
            this.var_ota_port.Text = "80";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 130;
            this.label3.Text = "port";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // var_ota_host
            // 
            this.var_ota_host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.var_ota_host.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.var_ota_host.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.var_ota_host.Location = new System.Drawing.Point(128, 36);
            this.var_ota_host.Name = "var_ota_host";
            this.var_ota_host.Size = new System.Drawing.Size(197, 24);
            this.var_ota_host.TabIndex = 129;
            this.var_ota_host.Text = "localhost";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(214, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 128;
            this.button2.Text = "WRITE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_ota_struct_write);
            // 
            // var_ota_last_firmware
            // 
            this.var_ota_last_firmware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.var_ota_last_firmware.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_ota_last_firmware.Location = new System.Drawing.Point(9, 40);
            this.var_ota_last_firmware.Name = "var_ota_last_firmware";
            this.var_ota_last_firmware.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.var_ota_last_firmware.Size = new System.Drawing.Size(110, 17);
            this.var_ota_last_firmware.TabIndex = 126;
            this.var_ota_last_firmware.Text = "host";
            this.var_ota_last_firmware.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ota_start
            // 
            this.btn_ota_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ota_start.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.btn_ota_start.ForeColor = System.Drawing.Color.Black;
            this.btn_ota_start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ota_start.Location = new System.Drawing.Point(214, 256);
            this.btn_ota_start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ota_start.Name = "btn_ota_start";
            this.btn_ota_start.Size = new System.Drawing.Size(139, 35);
            this.btn_ota_start.TabIndex = 113;
            this.btn_ota_start.Text = "DO_UPDATE";
            this.btn_ota_start.UseVisualStyleBackColor = true;
            this.btn_ota_start.Click += new System.EventHandler(this.btn_ota_do_update);
            // 
            // tab_render
            // 
            this.tab_render.BackColor = System.Drawing.Color.Chartreuse;
            this.tab_render.Location = new System.Drawing.Point(438, 46);
            this.tab_render.Name = "tab_render";
            this.tab_render.Size = new System.Drawing.Size(362, 8);
            this.tab_render.TabIndex = 127;
            this.tab_render.TabStop = false;
            // 
            // winformESP32ConfiguratorBindingSource
            // 
            this.winformESP32ConfiguratorBindingSource.DataSource = typeof(app.winform_ESP32_Configurator);
            // 
            // winform_ESP32_Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 451);
            this.Controls.Add(this.panel_tab3);
            this.Controls.Add(this.panel_tab1);
            this.Controls.Add(this.tab_render);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_tab3);
            this.Controls.Add(this.btn_tab2);
            this.Controls.Add(this.btn_tab1);
            this.Controls.Add(this.panel_tab2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "winform_ESP32_Configurator";
            this.Text = "ESP32 - Configurator";
            this.Load += new System.EventHandler(this.winform_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_tab2.ResumeLayout(false);
            this.panel_tab3.ResumeLayout(false);
            this.panel_tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_render)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winformESP32ConfiguratorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_tab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_tab3;
        private System.Windows.Forms.Button btn_tab2;
        private System.Windows.Forms.Panel panel_tab1;
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
        private System.Windows.Forms.Panel panel_tab3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label var_esp_gpio_pin_bit_mask;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox var_esp_gpio_pull_up_en;
        private System.Windows.Forms.ComboBox var_esp_gpio_pull_down_en;
        private System.Windows.Forms.ComboBox var_esp_gpio_intr_type;
        private System.Windows.Forms.ComboBox var_esp_gpio_mode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource winformESP32ConfiguratorBindingSource;
        private System.Windows.Forms.Button btn_ota_start;
        private System.Windows.Forms.Label var_ota_last_firmware;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox var_ota_path;
        private System.Windows.Forms.TextBox var_ota_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox var_ota_host;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox tab_render;
    }
}

