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

using System.Timers;

using utils;
using micro.sdk;

namespace app
{
    public partial class winform_LL_EBD : Form
    {
        #region Serial
        private static SerialPort Serial = intercom._serial;
        const int ReadTimeout = 80;
        const int WriteTimeout = 40;
        #endregion Serial
        //EBD.Delivery port;
        EBD.Delivery port = new EBD.Delivery(Serial, 0x55);

        // Connection status and etc
        System.Windows.Forms.Timer update = new System.Windows.Forms.Timer();

        public winform_LL_EBD()
        {
            InitializeComponent();

            if (Serial.IsOpen) Serial.Close();


            // serial service
            //intercom.eventDataEncoded += IRQ_PackEncoded;
            string[] ports = SerialPort.GetPortNames();

            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(ports);
            comboBox_ports.SelectedIndex = 0;

            object[] bauds = { 115200, 230400, 921600 };
            comboBox_baudrate.Items.Clear();
            comboBox_baudrate.Items.AddRange(bauds);
            comboBox_baudrate.SelectedIndex = 0;

            // update timer
            update.Interval = 40;
            update.Tick += new EventHandler(UpdateTick);

            
        }

        // Update timer
        private void UpdateTick(object sender, EventArgs e)
        {

        }

        private void open_port_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen == false)
            {

  
                Serial.PortName = comboBox_ports.SelectedItem.ToString();
                Serial.BaudRate = (int)comboBox_baudrate.SelectedItem;
                Serial.ReadTimeout = ReadTimeout;
                Serial.WriteTimeout = WriteTimeout;
                Serial.Encoding = Encoding.GetEncoding("Windows-1251");

                //try
                //{
                Serial.Open();
                // }
                //catch { }
                //Serial.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                //port.PinChanged       += new SerialPinChangedEventHandler(port_pin_change);
                //EBD.Delivery port = new EBD.Delivery(Serial, 0x55);
                //numericUpDown_duration.Value = 50;
            }

        }

        private void close_port_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen == true)
            {
                Serial.Close();
            }
        }


        private enum gen_regs
{
            freq_set = 0,
            duration,
            scale,
        }
        



        private void button_reset_Click(object sender, EventArgs e)
        {
            port.set_int((int)gen_regs.freq_set, 0);
        }

        private void numericUpDown_freq_ValueChanged(object sender, EventArgs e)
        {
            port.set_int((int)gen_regs.freq_set, (int)numericUpDown_freq.Value);
        }

        private void numericUpDown_duration_ValueChanged(object sender, EventArgs e)
        {
            port.set_float((int)gen_regs.duration, (float)numericUpDown_duration.Value);
        }

        private void numericUpDown_scale_ValueChanged(object sender, EventArgs e)
        {
            port.set_int((int)gen_regs.scale, (int)numericUpDown_scale.Value);
        }
    }

}
