namespace MassMeter
{
    partial class massmeter_form
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
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label_portstatus = new System.Windows.Forms.Label();
            this.button_portupdate = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.label_mass = new System.Windows.Forms.Label();
            this.button_set_zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_disconnect
            // 
            this.button_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_disconnect.Location = new System.Drawing.Point(424, 29);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(196, 49);
            this.button_disconnect.TabIndex = 10;
            this.button_disconnect.Text = "disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // label_portstatus
            // 
            this.label_portstatus.AutoSize = true;
            this.label_portstatus.Location = new System.Drawing.Point(175, 100);
            this.label_portstatus.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_portstatus.Name = "label_portstatus";
            this.label_portstatus.Size = new System.Drawing.Size(53, 29);
            this.label_portstatus.TabIndex = 7;
            this.label_portstatus.Text = "-----";
            // 
            // button_portupdate
            // 
            this.button_portupdate.Location = new System.Drawing.Point(175, 27);
            this.button_portupdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button_portupdate.Name = "button_portupdate";
            this.button_portupdate.Size = new System.Drawing.Size(138, 47);
            this.button_portupdate.TabIndex = 9;
            this.button_portupdate.Text = "update";
            this.button_portupdate.UseVisualStyleBackColor = true;
            this.button_portupdate.Click += new System.EventHandler(this.button_portupdate_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(424, 90);
            this.button_connect.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(196, 49);
            this.button_connect.TabIndex = 6;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(23, 29);
            this.comboBox_ports.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(132, 37);
            this.comboBox_ports.TabIndex = 8;
            // 
            // label_mass
            // 
            this.label_mass.AutoSize = true;
            this.label_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mass.Location = new System.Drawing.Point(128, 159);
            this.label_mass.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_mass.MaximumSize = new System.Drawing.Size(700, 163);
            this.label_mass.Name = "label_mass";
            this.label_mass.Size = new System.Drawing.Size(309, 163);
            this.label_mass.TabIndex = 11;
            this.label_mass.Text = "-----";
            // 
            // button_set_zero
            // 
            this.button_set_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button_set_zero.Location = new System.Drawing.Point(156, 361);
            this.button_set_zero.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button_set_zero.Name = "button_set_zero";
            this.button_set_zero.Size = new System.Drawing.Size(127, 77);
            this.button_set_zero.TabIndex = 12;
            this.button_set_zero.Text = "Set zero";
            this.button_set_zero.UseVisualStyleBackColor = true;
            this.button_set_zero.Click += new System.EventHandler(this.button_set_zero_Click);
            // 
            // massmeter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 582);
            this.Controls.Add(this.button_set_zero);
            this.Controls.Add(this.label_mass);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.label_portstatus);
            this.Controls.Add(this.button_portupdate);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.comboBox_ports);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "massmeter_form";
            this.Text = "Mass meter";
            this.Load += new System.EventHandler(this.massmeter_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Label label_portstatus;
        private System.Windows.Forms.Button button_portupdate;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Label label_mass;
        private System.Windows.Forms.Button button_set_zero;
    }
}

