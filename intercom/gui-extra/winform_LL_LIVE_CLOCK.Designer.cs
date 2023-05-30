namespace app
{
    partial class winform_LL_LIVE_CLOCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_LL_LIVE_CLOCK));
            this.now_fullweek = new System.Windows.Forms.Label();
            this.now_tzd = new System.Windows.Forms.Label();
            this.now_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.now_second = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // now_fullweek
            // 
            this.now_fullweek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.now_fullweek.Font = new System.Drawing.Font("Consolas", 12F);
            this.now_fullweek.ForeColor = System.Drawing.Color.White;
            this.now_fullweek.Location = new System.Drawing.Point(8, 92);
            this.now_fullweek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.now_fullweek.Name = "now_fullweek";
            this.now_fullweek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.now_fullweek.Size = new System.Drawing.Size(224, 22);
            this.now_fullweek.TabIndex = 4;
            this.now_fullweek.Text = "четверг 22 август 2019 г";
            this.now_fullweek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.now_fullweek.Click += new System.EventHandler(this.label1_Click);
            // 
            // now_tzd
            // 
            this.now_tzd.Font = new System.Drawing.Font("Consolas", 18F);
            this.now_tzd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.now_tzd.Location = new System.Drawing.Point(229, 83);
            this.now_tzd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.now_tzd.Name = "now_tzd";
            this.now_tzd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.now_tzd.Size = new System.Drawing.Size(101, 31);
            this.now_tzd.TabIndex = 11;
            this.now_tzd.Text = "UTC";
            this.now_tzd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // now_time
            // 
            this.now_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.now_time.Font = new System.Drawing.Font("Consolas", 42F);
            this.now_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.now_time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.now_time.Location = new System.Drawing.Point(14, 28);
            this.now_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.now_time.Name = "now_time";
            this.now_time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.now_time.Size = new System.Drawing.Size(221, 58);
            this.now_time.TabIndex = 12;
            this.now_time.Text = "20:57";
            this.now_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.now_time.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label4.Font = new System.Drawing.Font("Consolas", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(234, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Timezone";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // now_second
            // 
            this.now_second.Font = new System.Drawing.Font("Consolas", 22F);
            this.now_second.ForeColor = System.Drawing.Color.White;
            this.now_second.Location = new System.Drawing.Point(228, 28);
            this.now_second.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.now_second.Name = "now_second";
            this.now_second.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.now_second.Size = new System.Drawing.Size(62, 36);
            this.now_second.TabIndex = 14;
            this.now_second.Text = "32";
            this.now_second.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.now_second.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(393, 94);
            this.label1.TabIndex = 15;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.now_time);
            this.groupBox1.Controls.Add(this.now_tzd);
            this.groupBox1.Controls.Add(this.now_fullweek);
            this.groupBox1.Controls.Add(this.now_second);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 137);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // winform_LL_LIVE_CLOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 384);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "winform_LL_LIVE_CLOCK";
            this.Text = "Converter485: Configure and Control";
            this.Load += new System.EventHandler(this.winform_R3C0NF1GUR4T0R_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label now_fullweek;
        private System.Windows.Forms.Label now_tzd;
        private System.Windows.Forms.Label now_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label now_second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}