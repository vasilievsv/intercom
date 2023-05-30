using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Voltmeter
{
    public partial class voltmeter : Form
    {
        SerialPort port = micro.sdk.intercom._serial;
        Timer update = new Timer();
        Timer slowupdate = new Timer();

        bool start_messure_flag = false;

        int[] samples = new int[5] { 0, 0, 0, 0, 0 };
        int samples_cnt = 0;

        private void voltmeter_Load(object sender, EventArgs e)
        {
            ads112u04.connect._serial = micro.sdk.intercom._serial;
        }

        public voltmeter()
        {
            InitializeComponent();
            update.Interval = 100;
            update.Tick += new EventHandler(UpdateTick);
            //update.Start();

            slowupdate.Interval = 1000;
            slowupdate.Tick += new EventHandler(slowUpdateTick);
            slowupdate.Start();

            label_overload.Visible = false;
            label_overload.ForeColor = Color.OrangeRed;

            string[] ports = SerialPort.GetPortNames();
            //comboBox_ports.Items.Clear();
            //comboBox_ports.Items.AddRange(ports);
            //comboBox_ports.SelectedIndex = 0;

            comboBox_gain.Items.AddRange(ads112u04.amplifier.GAIN);comboBox_gain.SelectedIndex = 0;
            comboBox_reference.Items.AddRange(ads112u04.referense.REFERENCE);comboBox_reference.SelectedIndex = 0;
            comboBox_input.Items.AddRange(ads112u04.mux.MUX);comboBox_input.SelectedIndex = 0;
            comboBox_current.Items.AddRange(ads112u04.idac.IDAC);comboBox_current.SelectedIndex = 0;
            comboBox_I1MUX.Items.AddRange(ads112u04.idac.IMUX1);comboBox_I1MUX.SelectedIndex = 0;
            comboBox_I2MUX.Items.AddRange(ads112u04.idac.IMUX2);comboBox_I2MUX.SelectedIndex = 0;
            comboBox_PGA_bypass.Items.AddRange(ads112u04.amplifier.PGA_BYPASS);comboBox_PGA_bypass.SelectedIndex = 0;
        }

        private void UpdateTick(object sender, EventArgs e)
        {
            int temp = ads112u04.get.sample();
            samples[samples_cnt++] = temp;
            if (samples_cnt == 5) { samples_cnt = 0; }

            this.label_sample.Text = temp.ToString();
            var raw_data = ads112u04.math.average(samples);
            var voltage = raw_data * ads112u04.voltage.sample_cost;
            this.label_voltage.Text = (voltage).ToString();
            //pt100
            double Rref = 1000.0;
            double Idac = 0.0005; // two sources
            double Vref = Rref * Idac * 2;
            double pt100_cost = Vref / Math.Pow(2, 16);
            double gain = 8;
            double pt100_volt = raw_data * pt100_cost;
            //double pt100_res = (voltage / Idac / 2) - 2;
            double pt100_res = ((pt100_volt / Idac ) / gain *2) -0.06;
            double pt100_temp = (3383.8098 - 8658.0088 * Math.Sqrt(0.1758481 - 0.000231 * pt100_res));
            //0,0152587890625
            this.label_pt100.Text = pt100_temp.ToString(); // some error in calculate, but resistanse good
            this.label_pt100_ohm.Text = pt100_res.ToString();
            // overload indicator
            if (temp > 0)
            {
                if (temp > 32760 ) { label_overload.Visible = true; }
                else { label_overload.Visible = false; }
            }
            else
            {
                if (temp < -32760) { label_overload.Visible = true; }
                else { label_overload.Visible = false; }
            }
        }

        private void slowUpdateTick(object sender, EventArgs e)
        {
            if (ads112u04.connect.check())
            {
                this.label_portstatus.Text = "connect";
                this.label_portstatus.ForeColor = Color.Green;
                this.groupBox_messure.Enabled = true;
                this.groupBox_settings.Enabled = true;
                this.groupBox_service.Enabled = true;
            }
            else
            {
                this.label_portstatus.Text = "no connect";
                this.label_portstatus.ForeColor = Color.Red;
                this.groupBox_messure.Enabled = false;
                this.groupBox_settings.Enabled = false;
                this.groupBox_service.Enabled = false;
            }

            this.label_error_cnt.Text = ads112u04.get.error_cnt.ToString();
            if (ads112u04.get.error_cnt > 42)
            {
                ads112u04.get.error_cnt = 0;
                update.Stop();
                port.Dispose();
                port.Close();
            }

            if (start_messure_flag == false)
            {
                //groupBox_service.Enabled = true;
                label_temperature.Enabled = true;
                label_temperature.Text = ads112u04.Service.temperature_.ToString();

                label_battery_voltage.Enabled = true;
                label_battery_voltage.Text = ads112u04.Service.avdd_.ToString();

                label_ext_ref.Enabled = true;
                label_ext_ref.Text = ads112u04.Service.ext_ref_.ToString(); 
            }
            else
            {
                //groupBox_service.Enabled = false;
                label_temperature.Enabled = false;
                label_battery_voltage.Enabled = false;
                label_ext_ref.Enabled = false;

            }
        }

        /*private int average(int[] buff)
        {
            int result = 0;
            for (int n = 0; n != buff.Length; n++)
            {
                result += buff[n];
            }
            result = result/buff.Length;
            return result;
        }*/

        private void button_connect_Click(object sender, EventArgs e)
        {
            ads112u04.connect.open(comboBox_ports.SelectedItem.ToString(), 115200);
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            ads112u04.thread_control.stop_all();
            port.Close();
            port.Dispose();
        }
        private void button_portupdate_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(ports);
            comboBox_ports.SelectedIndex = 0;
        }

        private void button_push_Click(object sender, EventArgs e)
        {
            ads112u04.get.init();
        }

        
        private void button_startstop_Click(object sender, EventArgs e)
        {
            if (!start_messure_flag)
            {
                ads112u04.Service.DoStop();
                ads112u04.get.init();
                comboBox_gain_SelectedIndexChanged(0, EventArgs.Empty);
                comboBox_reference_SelectedIndexChanged(0, EventArgs.Empty);
                comboBox_input_SelectedIndexChanged(0, EventArgs.Empty);
                comboBox_comboBox_current_SelectedIndexChanged(0, EventArgs.Empty);
                comboBox_PGA_bypass_SelectedIndexChanged(0, EventArgs.Empty);
                comboBox_I2MUX_SelectedIndexChanged(0, EventArgs.Empty);
                comboBox_I1MUX_SelectedIndexChanged(0, EventArgs.Empty);
                update.Start();
                button_startstop.Text = "stop";
                start_messure_flag = true;
                //groupBox_settings.Visible = false;
            }
            else
            {
                ads112u04.Service.DoStart();
                update.Stop();
                button_startstop.Text = "start";
                start_messure_flag = false;
                //groupBox_settings.Visible = true;
            }
        }

        private void comboBox_gain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ads112u04.amplifier.set((ads112u04.amplifier.gain)comboBox_gain.SelectedIndex);
            ads112u04.voltage.sample_cost = ads112u04.voltage.cost[comboBox_gain.SelectedIndex];
        }

        private void comboBox_reference_SelectedIndexChanged(object sender, EventArgs e)
        {
            ads112u04.referense.use((ads112u04.referense.refinput)comboBox_reference.SelectedIndex);
        }

        private void comboBox_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            ads112u04.mux.use((ads112u04.mux.inputs)comboBox_input.SelectedIndex);
            if (
                (comboBox_input.SelectedIndex == 14) |
                (comboBox_input.SelectedIndex == 13) | 
                (comboBox_input.SelectedIndex == 12))
            {
                comboBox_gain.SelectedIndex = 0;
                groupBox_gain.Enabled = false;
            }
            else
            {
                groupBox_gain.Enabled = true;
            }
            if (comboBox_input.SelectedIndex >= 8)
            {
                label_gain_alert.Enabled = true;
            }
            else
            {
                label_gain_alert.Enabled = false;
            }
        }

        private void comboBox_comboBox_current_SelectedIndexChanged(object sender, EventArgs e)
        {
            ads112u04.idac.idac_set((ads112u04.idac.idac_current)comboBox_current.SelectedIndex);
        }

        private void comboBox_I1MUX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ads112u04.idac.i1mix((ads112u04.idac.imux)comboBox_I1MUX.SelectedIndex);
        }

        private void comboBox_I2MUX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ads112u04.idac.i2mix((ads112u04.idac.imux)comboBox_I2MUX.SelectedIndex);
        }

        private void comboBox_PGA_bypass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ads112u04.amplifier.pga_bypass_mode((ads112u04.amplifier.pga_bypass)comboBox_PGA_bypass.SelectedIndex);
        }

        private void comboBox_ports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_portstatus_Click(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void label_pt100_Click(object sender, EventArgs e)
        {
            comboBox_gain.SelectedIndex = 3;
            comboBox_reference.SelectedIndex = 1;
            comboBox_input.SelectedIndex = 0;
            comboBox_current.SelectedIndex = 5;
            comboBox_I1MUX.SelectedIndex = 3;
            comboBox_I2MUX.SelectedIndex = 4;
            comboBox_PGA_bypass.SelectedIndex = 1;
        }
    }
}
