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
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using micro.sdk;


using Microsoft.Win32.SafeHandles;
using utils;

namespace app
{
    public partial class winform_ComPort : Form
    {
        Button _prev_pin = null;
        Button _prev_gnd = null;

        string frw_mode = "";

        public winform_ComPort()
        {
            InitializeComponent();
            
            //intercom._resetPort();
        }

        private void winform_remote_backdoor_Load(object sender, EventArgs e)
        {
            intercom.eventDataEncoded += IRQ_DataIncoming;
            act_wire_info(null,null);
        }

        unsafe private void IRQ_DataIncoming(object sender, string str)
        {
            var json_array = utils.json.Decode(str) as Hashtable;
            // Только валидный json
            if (json_array == null)
                return;

            var _act        = json_array["act"] as string;
            var _did        = json_array["did"] as string;
            var _data       = json_array["data"] as Hashtable;

            if (_act == "pin.toggle" && _did != "0")
            {
                var pin_ctrl = ((Button)this.Controls.Find("pin_"+_did, true)[0]);

                // Сброс пред-щего пина
                if(_prev_pin != null && _prev_pin.BackColor == Color.Red)
                    _prev_pin.BackColor = Color.LightGray;

                pin_ctrl.BackColor = Color.Red;
                
                _prev_pin = pin_ctrl;
            }

            if (_act == "pin.gnd" && _did != "0")
            {
                var pin = ((Button)this.Controls.Find("pin_" + _did, true)[0]);
                
                if (_prev_gnd != null)
                    _prev_gnd.ForeColor = Color.Black;

                pin.ForeColor = Color.Magenta;
                _prev_gnd = pin;

                /// !!! cross thread update
                //Invoke(new Action(() => { lbl_app_mode.Text = frw_mode+" gnd:"+pin.Text; }));
            }

            if (_act == "gpio.info")
            {
                var a = _data["app_mode"] as string;
                var b = _data["pin_ground"];

                var pin_ctrl = ((Button)this.Controls.Find("pin_" + b, true)[0]);
                if (pin_ctrl.ForeColor == Color.Magenta)
                    pin_ctrl.ForeColor = Color.White;
                else
                    pin_ctrl.ForeColor = Color.Magenta;

                _prev_gnd = pin_ctrl;
                /// !!! cross thread update
                frw_mode = a;
                //Invoke(new Action(() => { lbl_app_mode.Text = frw_mode + " gnd:" + pin_ctrl.Text; }));
            }
        }

        private void act_wire_info(object sender, EventArgs e)
        {
            Hashtable pack = new Hashtable();
            pack.Add("act", "gpio.info");
            var T = utils.json.Encode(pack);
            intercom._serial.Write( T );
        }


  
        private void pin_group(object sender, EventArgs e)
        {
            win32_serial.SetCommFlag(intercom._serial,win32_serial.SETRTS);
            Thread.Sleep( 150 );
            win32_serial.SetCommFlag(intercom._serial, win32_serial.CLRRTS);

            //intercom._serial.RtsEnable = true;
            //intercom._serial.DtrEnable = true;
            //Button btn = (Button)sender;
            //int pin_num = Int32.Parse( btn.Text );

            //Hashtable pack = new Hashtable();
            //pack.Add("act", "gpio.touch");
            //pack.Add("did", pin_num.ToString());

            //var T = utils.json.Encode(pack);
            //intercom._serial.Write( T );
        }

        private void app_state_group(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int pin_num = Int32.Parse(btn.Text);

            Hashtable pack = new Hashtable();
            pack.Add("act", "gpio.set_od");
            pack.Add("did", pin_num.ToString());

            intercom._serial.Write(utils.json.Encode(pack));
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}
