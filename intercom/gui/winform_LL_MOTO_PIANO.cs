using System;
using System.Threading;
using System.Windows.Forms;
using utils;
using micro.sdk;
using System.IO.Ports;


namespace app
{

    public partial class winform_LL_MOTO_PIANO : Form
    {
        private enum gen_regs
        {
            freq_set = 0,
            duration,
            scale,
        }

        private SerialPort Serial;
        EBD.Delivery port;


        public winform_LL_MOTO_PIANO()
        {
            InitializeComponent();

            object[] bauds = { 115200, 230400, 921600 };
            Serial  = intercom._serial;




            if (Serial.IsOpen == true)
            {
                Serial.Close();
            }


            Thread.Sleep(20);

            Serial.BaudRate         = (int)bauds[2];
            Serial.ReadTimeout      = 80;//ReadTimeout;
            Serial.WriteTimeout     = 40; //WriteTimeout;
            Serial.Encoding         = System.Text.Encoding.GetEncoding("Windows-1251");

            Serial.Open();


            port = new EBD.Delivery(Serial, 0x55);

            port.set_int((int)gen_regs.freq_set, 0);
            port.set_float((int)gen_regs.duration, 50.0f);


        }

        void playTone(string name)
        {
            int x = 0;
            switch (name)
            {
                case "+":
                    port.set_int((int)gen_regs.scale, _scale += 10);
                    break;
                case "-":
                    port.set_int((int)gen_regs.scale, _scale -= 10);
                    break;

                // frequencies
                case "c": x = 261; break;
                case "d": x = 294; break;
                case "e": x = 329; break;
                case "f": x = 349; break;
                case "g": x = 391; break;
                case "gS": x = 415; break;
                case "a": x = 440; break;
                case "aS": x = 455; break;
                case "b": x = 466; break;
                case "cH": x = 523; break;
                case "cSH": x = 554; break;
                case "dH": x = 587; break;
                case "dSH": x = 622; break;
                case "eH": x = 659; break;
                case "fH": x = 698; break;
                case "fSH": x = 740; break;
                case "gH": x = 784; break;
                case "gSH": x = 830; break;
                case "aH": x = 880; break;


                default: x = 0; break;
            }
            port.set_int((int)gen_regs.freq_set, x);
            _scale = port.get_int((int)gen_regs.scale);
            label1.Text = _scale.ToString();

        }
        public int _scale = 1;

        private void OnButtonClick(object sender, System.Windows.Forms.MouseEventArgs base_event)
        {
            playTone(((Button)sender).Text);
        }

        private void Button1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            playTone("mute");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            takeonme();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            playTone(((Button)sender).Text);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //port.set_int((int)gen_regs.scale, tone);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            playTone(((Button)sender).Text);
        }
        private void beep(int tone, int time)
        {
            port.set_int((int)gen_regs.freq_set, tone);
            delay(time);
            port.set_int((int)gen_regs.freq_set, 0);
        }
        private void delay(int time)
        {
            Thread.Sleep(time);
        }
        private void takeonme()
        {
            beep(740, 88);
            delay(198 - 88);
            beep(740, 88);
            delay(198 - 88);
            beep(740, 88);
            delay(198 - 88);
            beep(587, 88);
            delay(198 - 88);
            delay(188);

            beep(494, 88);
            delay(198 - 88);
            delay(188);

            beep(659, 88);
            delay(198 - 88);
            delay(188);

            beep(659, 88);
            delay(198 - 88);
            delay(188);

            beep(659, 88);
            delay(198 - 88);
            beep(831, 88);
            delay(198 - 88);
            beep(831, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(988, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
            delay(188);

            beep(587, 88);
            delay(198 - 88);
            delay(188);

            beep(740, 88);
            delay(198 - 88);
            delay(188);

            beep(740, 88);
            delay(198 - 88);
            delay(188);

            beep(740, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
            beep(740, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
            beep(740, 88);
            delay(198 - 88);
            beep(740, 88);
            delay(198 - 88);
            beep(740, 88);
            delay(198 - 88);
            beep(587, 88);
            delay(198 - 88);
            delay(188);

            beep(494, 88);
            delay(198 - 88);
            delay(188);

            beep(659, 88);
            delay(198 - 88);
            delay(188);

            beep(659, 88);
            delay(198 - 88);
            delay(188);

            beep(659, 88);
            delay(198 - 88);
            beep(831, 88);
            delay(198 - 88);
            beep(831, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(988, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(880, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
            delay(188);

            beep(587, 88);
            delay(198 - 88);
            delay(188);

            beep(740, 88);
            delay(198 - 88);
            delay(188);

            beep(740, 88);
            delay(198 - 88);
            delay(188);

            beep(740, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
            beep(740, 88);
            delay(198 - 88);
            beep(659, 88);
            delay(198 - 88);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            takeonme();
        }
    }
}
