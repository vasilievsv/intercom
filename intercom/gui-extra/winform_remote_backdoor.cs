/**
  ******************************************************************************
  * @date    
  * @version V0.0.0
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************

*/
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;
using micro.sdk;

using System.Text.RegularExpressions;
using System.Timers;

namespace app
{
    public partial class winform_remote_backdoor : Form
    {
        System.Windows.Forms.Timer _timer;

        public winform_remote_backdoor()
        {
            InitializeComponent();

            //intercom._resetPort();
            //intercom._serial.DataReceived += IRQ_DataIncoming;
            intercom.eventDataEncoded += IRQ_DataIncoming;
        }

        private void winform_remote_backdoor_Load(object sender, EventArgs e)
        {
            track_ac_dimming.ValueChanged += TrackBar1_ValueChanged;
            _timer = new System.Windows.Forms.Timer();

            _timer.Interval = 1000;
            _timer.Tick += Timer_Elapsed;
            _timer.Start();
        }
        ///
        private void Timer_Elapsed(object sender, EventArgs e)
        {
            var pack = new Hashtable();

            pack.Add("act", "dev.read");
            pack.Add("did", "root.ctrl.zero-cross");
            pack.Add("target", "table_var");
            intercom.socket_TX = utils.json.Encode(pack);

            pack.Clear();
            Thread.Sleep(95);

            pack.Add("act", "clock.datetime");
            intercom.socket_TX = utils.json.Encode(pack);

            pack.Clear();
            Thread.Sleep(95);

            pack.Add("act", "dev.read");
            pack.Add("did", "root.sys.memstat");
            pack.Add("target", "table_var");
            intercom.socket_TX = utils.json.Encode(pack);
        }

        unsafe private void IRQ_DataIncoming(object sender, string str)
        {
            var json_array  = utils.json.Decode(str) as Hashtable;
            var _act        = json_array["act"] as string;
            var _did        = json_array["did"] as string;
            var json_data   = json_array["data"] as Hashtable;

            if (_act == "dev.read" && json_data.Count>0 )
            {
                if (_did == "root.ctrl.zero-cross")
                {
                    var a1 = json_data["dimming"];
                    var a2 = json_data["pin_input"];
                    var a3 = json_data["pin_output"];
                    var a4 = json_data["impulse_width"];


                    lbl_ac_width_ms.Text = json_data["var_ac_width"].ToString();
                    lbl_zc_width_ms.Text = json_data["var_zc_width"].ToString();
                }

                if (_did == "root.sys.memstat")
                {
                    lbl_sram.Text = json_data["heap_free_size"].ToString();
                }
            }

            if (_act == "clock.datetime")
            {
                lbl_clock.Text = json_data["time"].ToString();
            }

            if (_act == "clock.enum")
            {
                tree_clock_schedule.Nodes.Clear();
                foreach (DictionaryEntry s in json_data)
                {
                    var _name = s.Key.ToString();
                    var _data = s.Value as Hashtable;
                    TreeNode newNode = new TreeNode(_name);

                    foreach (DictionaryEntry x in _data)
                    {
                        newNode.Nodes.Add(x.Key.ToString());
                    }

                    tree_clock_schedule.Nodes.Add(newNode);
                }

                tree_clock_schedule.Sort();
            }
        }

        private void button_uart_enum(object sender, EventArgs e)
        {
            ArrayList value = new ArrayList();
            Hashtable pack = new Hashtable();
            
            pack.Add("cmd" , "uart.enum");
            pack.Add("data", value);
            
            var T = utils.json.Encode(pack);
            intercom._serial.Write(T);
            log.print(T);
        }

        private void uart_apply(object sender, EventArgs e)
        {
            //ArrayList value = new ArrayList();
            //Hashtable pack = new Hashtable();

            //pack.Add("cmd", "uart.apply");
            //pack.Add("data", value);

            //var T = utils.json.Encode(pack);
            //log.print(T);

            var T = "{ \"cmd\":\"uart.apply\", \"data\":[ {\"port1\":{\"enabled\":false}} ] }";
            intercom._serial.Write( T );
        }


        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            var value = new Hashtable();
                value.Add("dimming", ((TrackBar)sender).Value * 1000);

            var pack = new Hashtable();
                pack.Add("act"      , "dev.write");
                pack.Add("did"      , "root.ctrl.zero-cross");
                pack.Add("target"   , "table_var");
                pack.Add("data"     ,  value );

            intercom.socket_TX = utils.json.Encode(pack);
        }

        private void btn_clock_save_Click(object sender, EventArgs e)
        {
            var pack = new Hashtable();
            pack.Add("act", "clock.save");

            intercom.socket_TX = utils.json.Encode(pack);
        }

        private void btn_ota_update_Click(object sender, EventArgs e)
        {
            var pack = new Hashtable();
            pack.Add("act", "dev.run");
            pack.Add("did", "root.ctrl.ota");

            intercom.socket_TX = utils.json.Encode(pack);
        }

        private void btn_ota_apply_Click(object sender, EventArgs e)
        {
            var value = new Hashtable();
            value.Add("host"        , input_ota_ip.Text);
            value.Add("host_port"   , input_ota_port.Text);
            value.Add("host_file"   , input_ota_firmware_file.Text);

            var pack = new Hashtable();
            pack.Add("act"      , "dev.write");
            pack.Add("did"      , "root.ctrl.ota");
            pack.Add("target"   , "table_var");
            pack.Add("data"     , value);

            intercom.socket_TX = utils.json.Encode(pack);


            pack = new Hashtable();
            pack.Clear();
            pack.Add("act", "dev.save");
            pack.Add("did", "root.ctrl.ota");

            intercom.socket_TX = utils.json.Encode(pack);


        }

        private void track_ac_dimming_Scroll(object sender, EventArgs e)
        {

        }

        private void btn_clock_load_Click(object sender, EventArgs e)
        {
            var pack = new Hashtable();
            pack.Add("act", "clock.enum");

            intercom.socket_TX = utils.json.Encode(pack);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pack = new Hashtable();
            pack.Add("act", "clock.load");

            intercom.socket_TX = utils.json.Encode(pack);
        }

        private void lbl_zc_width_ms_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
