namespace app
{
    partial class winform_USART
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_SR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_DR = new System.Windows.Forms.TextBox();
            this.txt_BRR = new System.Windows.Forms.TextBox();
            this.txt_CR1 = new System.Windows.Forms.TextBox();
            this.txt_CR2 = new System.Windows.Forms.TextBox();
            this.txt_CR3 = new System.Windows.Forms.TextBox();
            this.txt_GTPR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_SR
            // 
            this.txt_SR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SR.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SR.ForeColor = System.Drawing.Color.Blue;
            this.txt_SR.Location = new System.Drawing.Point(376, 123);
            this.txt_SR.Name = "txt_SR";
            this.txt_SR.Size = new System.Drawing.Size(445, 59);
            this.txt_SR.TabIndex = 5;
            this.txt_SR.Text = "0-0-0-0-0-0-0-0";
            this.txt_SR.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 123);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(181, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "SR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(547, 661);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 120);
            this.button2.TabIndex = 7;
            this.button2.Text = "READ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(193, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 120);
            this.button1.TabIndex = 6;
            this.button1.Text = "WRITE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(163, 186);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(181, 63);
            this.label11.TabIndex = 17;
            this.label11.Text = "DR";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(163, 241);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(181, 63);
            this.label12.TabIndex = 18;
            this.label12.Text = "BRR";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(163, 304);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(181, 63);
            this.label13.TabIndex = 19;
            this.label13.Text = "CR1";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(163, 361);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(181, 63);
            this.label14.TabIndex = 20;
            this.label14.Text = "CR2";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(163, 424);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(181, 63);
            this.label15.TabIndex = 21;
            this.label15.Text = "CR3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(163, 482);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(181, 63);
            this.label16.TabIndex = 22;
            this.label16.Text = "GTPR";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_DR
            // 
            this.txt_DR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DR.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DR.ForeColor = System.Drawing.Color.Blue;
            this.txt_DR.Location = new System.Drawing.Point(376, 186);
            this.txt_DR.Name = "txt_DR";
            this.txt_DR.Size = new System.Drawing.Size(445, 59);
            this.txt_DR.TabIndex = 23;
            this.txt_DR.Text = "0-0-0-0-0-0-0-0";
            this.txt_DR.WordWrap = false;
            // 
            // txt_BRR
            // 
            this.txt_BRR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BRR.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BRR.ForeColor = System.Drawing.Color.Blue;
            this.txt_BRR.Location = new System.Drawing.Point(376, 241);
            this.txt_BRR.Name = "txt_BRR";
            this.txt_BRR.Size = new System.Drawing.Size(445, 59);
            this.txt_BRR.TabIndex = 24;
            this.txt_BRR.Text = "0-0-0-0-0-0-0-0";
            this.txt_BRR.WordWrap = false;
            // 
            // txt_CR1
            // 
            this.txt_CR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CR1.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CR1.ForeColor = System.Drawing.Color.Blue;
            this.txt_CR1.Location = new System.Drawing.Point(376, 304);
            this.txt_CR1.Name = "txt_CR1";
            this.txt_CR1.Size = new System.Drawing.Size(445, 59);
            this.txt_CR1.TabIndex = 25;
            this.txt_CR1.Text = "0-0-0-0-0-0-0-0";
            this.txt_CR1.WordWrap = false;
            // 
            // txt_CR2
            // 
            this.txt_CR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CR2.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CR2.ForeColor = System.Drawing.Color.Blue;
            this.txt_CR2.Location = new System.Drawing.Point(376, 365);
            this.txt_CR2.Name = "txt_CR2";
            this.txt_CR2.Size = new System.Drawing.Size(445, 59);
            this.txt_CR2.TabIndex = 26;
            this.txt_CR2.Text = "0-0-0-0-0-0-0-0";
            this.txt_CR2.WordWrap = false;
            // 
            // txt_CR3
            // 
            this.txt_CR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CR3.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CR3.ForeColor = System.Drawing.Color.Blue;
            this.txt_CR3.Location = new System.Drawing.Point(376, 428);
            this.txt_CR3.Name = "txt_CR3";
            this.txt_CR3.Size = new System.Drawing.Size(445, 59);
            this.txt_CR3.TabIndex = 27;
            this.txt_CR3.Text = "0-0-0-0-0-0-0-0";
            this.txt_CR3.WordWrap = false;
            // 
            // txt_GTPR
            // 
            this.txt_GTPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GTPR.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GTPR.ForeColor = System.Drawing.Color.Blue;
            this.txt_GTPR.Location = new System.Drawing.Point(376, 482);
            this.txt_GTPR.Name = "txt_GTPR";
            this.txt_GTPR.Size = new System.Drawing.Size(445, 59);
            this.txt_GTPR.TabIndex = 28;
            this.txt_GTPR.Text = "0-0-0-0-0-0-0-0";
            this.txt_GTPR.WordWrap = false;
            // 
            // winform_USART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 861);
            this.Controls.Add(this.txt_GTPR);
            this.Controls.Add(this.txt_CR3);
            this.Controls.Add(this.txt_CR2);
            this.Controls.Add(this.txt_CR1);
            this.Controls.Add(this.txt_BRR);
            this.Controls.Add(this.txt_DR);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_SR);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "winform_USART";
            this.Text = "USART: Configure and Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_DR;
        private System.Windows.Forms.TextBox txt_BRR;
        private System.Windows.Forms.TextBox txt_CR1;
        private System.Windows.Forms.TextBox txt_CR2;
        private System.Windows.Forms.TextBox txt_CR3;
        private System.Windows.Forms.TextBox txt_GTPR;
    }
}