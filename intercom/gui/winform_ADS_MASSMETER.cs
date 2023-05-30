using micro.sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassMeter
{
    public partial class massmeter_form : Form
    {
        ads.ADS1x2U04 dev;
        Thread getdata;
        System.Windows.Forms.Timer update;

        public massmeter_form()
        {
            InitializeComponent();
            object s = new object();
            EventArgs e = new EventArgs();
            button_portupdate_Click(s, e);
        }

        private void button_portupdate_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(ports);
            comboBox_ports.SelectedIndex = 0;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if(dev == null)
            {
                dev = new ads.ADS1x2U04(comboBox_ports.SelectedItem.ToString(), 115200, 16);

                dev.Serial = intercom._serial;
                dev.init();
                dev.Referense = ads.ADS1x2U04.refinput.analog_supply;
                dev.mux = ads.ADS1x2U04.AIN.AINp_AIN0__AINn_AIN1;
                dev.Amplifier = ads.ADS1x2U04.Gain.pga128;
                //
                getdata = new Thread(delegate () { stream(dev); });
                getdata.IsBackground = true;
                getdata.Start();
                //
                update = new System.Windows.Forms.Timer();
                update.Interval = 100;
                update.Tick += Update_Tick;
                update.Start();
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {

        }

        int adc;
        double mass;
        double k = 0.01;
        double offset = 0;
        private void Update_Tick(object sender, EventArgs e)
        {
            // math
            mass = adc * k + offset;
            // labels
            label_mass.Text = mass.ToString();
        }


        void stream(ads.ADS1x2U04 dev)
        {
            while (true)
            {
                // get ADC data
                adc = dev.Oneshot;
                Thread.Sleep(100);
            }
        }

        private void massmeter_form_Load(object sender, EventArgs e)
        {

        }

        private void button_set_zero_Click(object sender, EventArgs e)
        {
            offset = -adc * k;

        }
    }
}
