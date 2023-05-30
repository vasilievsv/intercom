using System.Drawing;
using System.Drawing.Imaging;

namespace app
{
    partial class winform_ComPort
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pin_3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pin_3);
            this.groupBox1.Font = new System.Drawing.Font("OCR A Extended", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(442, 252);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPIO";
            // 
            // pin_3
            // 
            this.pin_3.Font = new System.Drawing.Font("OCR A Extended", 10.2F);
            this.pin_3.ForeColor = System.Drawing.Color.Black;
            this.pin_3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pin_3.Location = new System.Drawing.Point(273, 58);
            this.pin_3.Margin = new System.Windows.Forms.Padding(2);
            this.pin_3.Name = "pin_3";
            this.pin_3.Size = new System.Drawing.Size(119, 39);
            this.pin_3.TabIndex = 98;
            this.pin_3.Text = "HIGH";
            this.pin_3.UseVisualStyleBackColor = true;
            this.pin_3.Click += new System.EventHandler(this.pin_group);
            // 
            // winform_ComPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(473, 273);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "winform_ComPort";
            this.Text = "ComPort-Check";
            this.Load += new System.EventHandler(this.winform_remote_backdoor_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pin_3;
    }
}

