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
    public partial class winform_patifon_R3C0NF1GUR4T0R : Form
    {

        System.Windows.Forms.Timer _timer;
        public winform_patifon_R3C0NF1GUR4T0R()
        {
            InitializeComponent();
            
            intercom.eventDataEncoded += IRQ_PackEncoded;

        }

        public void IRQ_PackEncoded(byte opcode, byte[] data)
        {


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
