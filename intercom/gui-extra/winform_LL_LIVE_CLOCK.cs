using System;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using utils;
using micro.sdk;

using System.Collections;
using System.Globalization;

namespace app
{
    public partial class winform_LL_LIVE_CLOCK : Form
    {

        System.Windows.Forms.Timer _timer;
        public winform_LL_LIVE_CLOCK()
        {
            InitializeComponent();
            
            //intercom.eventDataEncoded += IRQ_PackEncoded;

            //_timer = new System.Windows.Forms.Timer();
            //_timer.Interval = 1100;
            //_timer.Tick += _timer_Tick;
            //_timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            Hashtable pack = new Hashtable();
            pack.Add("cmd", "clock.get_date");

            intercom._serial.Write(utils.json.Encode(pack));
        }

        public void IRQ_PackEncoded(byte opcode, byte[] data)
        {
            var raw_str = System.Text.Encoding.Default.GetString(data);
            log.print( raw_str );

            var json = utils.json.Decode(raw_str) as Hashtable;


            var day     = Convert.ToInt32( json["day"]);
            var month   = Convert.ToInt32( json["month"]);
            var year    = Convert.ToInt32( json["year"]);
            var hour    = Convert.ToInt32( json["hour"]);
            var minute  = Convert.ToInt32( json["minute"]);
            var second  = Convert.ToInt32( json["second"]);

            DateTime dt = new DateTime
                (
                year, month, day, hour, minute, second, 0
                );


            /// !!! cross thread update
            Invoke(new Action(() => { now_second.Text = dt.ToString("ss");}));
            Invoke(new Action(() => { now_time.Text = dt.ToString("hh:mm");}));
            Invoke(new Action(() => { now_tzd.Text = Convert.ToString(json["timezone"]);}));
            Invoke(new Action(() => 
            {
                now_fullweek.Text = dt.ToString("dddd dd MMMM yyyy",CultureInfo.CreateSpecificCulture("ru-RU"));
            }));

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void winform_R3C0NF1GUR4T0R_Load(object sender, EventArgs e)
        {

        }

        private void txt_SR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
