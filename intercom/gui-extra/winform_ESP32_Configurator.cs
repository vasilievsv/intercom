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
using System.Windows.Forms;
using micro.sdk;
using utils;

namespace app
{
    public partial class winform_ESP32_Configurator : Form
    {
        Button _prev_pin = null;
        Button _prev_gnd = null;

        string frw_mode = "";
        System.Windows.Forms.Timer _timer;

        #region INITIALIZE
        public winform_ESP32_Configurator()
        {
            InitializeComponent();
            
            //intercom._resetPort();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1100;
            _timer.Tick += _timer_Tick;
            //_timer.Start();

            Hashtable pack = new Hashtable();
            pack.Add("act", "api.gpio_struct_meta");
            pack.Add("did", "");
            intercom._serial.Write(utils.json.Encode(pack));

        }
   
        private void winform_remote_backdoor_Load(object sender, EventArgs e)
        {
            intercom.eventDataEncoded += IRQ_DataIncoming;
            //act_wire_info(null,null);
            //btn_pin_Click(null, null);
        }
        #endregion

        #region PACKAGE_ROUTINE
        private void _timer_Tick(object sender, EventArgs e)
        {
            Hashtable pack = new Hashtable();
                pack.Add("act", "api.get_chip_info");
                pack.Add("did", "");
            intercom._serial.Write(utils.json.Encode(pack));
        }
        unsafe private void IRQ_DataIncoming(object sender, string str)
        {
            var json_array = utils.json.Decode(str) as Hashtable;
            // Только валидный json
            if (json_array == null)
                return;

            var _act = json_array["act"] as string;
            var _did = json_array["did"] as string;
            var _data= json_array["data"] as Hashtable;

            if (_act == "api.get_mcu_info" && _data.Count > 0)
            {
                var a1 = _data["cores"].ToString();
                var a2 = _data["features"].ToString();
                var a3 = _data["model"].ToString();
                var a4 = _data["revision"].ToString();
                var a5 = _data["cpu_freq"].ToString();
                var a6 = _data["free_heap"].ToString();
                var a7 = _data["time"].ToString();
                var a8 = _data["date"].ToString();

                Invoke(new Action(() => { var_esp_mode.Text = a3; }));
                Invoke(new Action(() => { var_esp_time.Text = a7; }));
                Invoke(new Action(() => { var_esp_date.Text = a8; }));
                Invoke(new Action(() => { var_esp_cores.Text = a1; }));
                Invoke(new Action(() => { var_esp_feature.Text = a2; }));
                Invoke(new Action(() => { var_esp_revision.Text = a4; }));
                Invoke(new Action(() => { var_esp_cpu_freq.Text = a5; }));
                Invoke(new Action(() => { var_esp_free_heap.Text = a6; }));
            }

            if (_act == "api.gpio_struct_read")
            {
                var a1 = _data["intr_type"].ToString();
                var a2 = _data["mode"].ToString();
                var a3 = _data["pin_bit_mask"].ToString();
                var a4 = _data["pull_up_en"].ToString();
                var a5 = _data["pull_down_en"].ToString();

                Invoke(new Action(() => { var_esp_gpio_mode.SelectedIndex =int.Parse( a2); }));
                Invoke(new Action(() => { var_esp_gpio_intr_type.SelectedIndex = int.Parse(a1); }));
                Invoke(new Action(() => { var_esp_gpio_pull_up_en.SelectedIndex = int.Parse(a4); }));
                Invoke(new Action(() => { var_esp_gpio_pull_down_en.SelectedIndex = int.Parse(a5); }));
                Invoke(new Action(() => { var_esp_gpio_pin_bit_mask.Text = a3; }));
            }

            if (_act == "api.gpio_struct_meta")
            {
                var a1 = _data["gpio_meta"] as Hashtable;
                var b1 = a1["intr_type"] as Hashtable;
                var b2 = a1["mode"] as Hashtable;
                var b3 = a1["pull"] as Hashtable;

                Invoke(new Action(() =>{
                    var_esp_gpio_mode.DisplayMember = "Key";
                    var_esp_gpio_mode.ValueMember = "Value";
                    var_esp_gpio_mode.DataSource = new BindingSource(b2, null);

                    var_esp_gpio_intr_type.DisplayMember = "Key";
                    var_esp_gpio_intr_type.ValueMember = "Value";
                    var_esp_gpio_intr_type.DataSource = new BindingSource(b1, null);


                    var_esp_gpio_pull_down_en.DisplayMember = "Key";
                    var_esp_gpio_pull_down_en.ValueMember = "Value";
                    var_esp_gpio_pull_down_en.DataSource = new BindingSource(b3, null);


                    var_esp_gpio_pull_up_en.DisplayMember = "Key";
                    var_esp_gpio_pull_up_en.ValueMember = "Value";
                    var_esp_gpio_pull_up_en.DataSource = new BindingSource(b3, null);
                }));


            }

            if (_act == "pin.toggle" && _did != "0")
            {
                var pin_ctrl = ((Button)this.Controls.Find("pin_" + _did, true)[0]);

                // Сброс пред-щего пина
                if (_prev_pin != null && _prev_pin.BackColor == Color.Red)
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
        }// Func

        #endregion

        #region BASE_ACTION
        private void btn_pin_Click(object sender, EventArgs e)
        {
            var _pin_name = (Label)sender;

            panel_tab1.Visible = false;
            panel_tab3.Visible = false;
            panel_tab2.Visible = true;
            panel_tab2.Location = panel_tab1.Location;


            Hashtable pack = new Hashtable();
            pack.Add("act", "api.gpio_struct_read");
            pack.Add("target", _pin_name.Text);
            intercom._serial.Write(utils.json.Encode(pack));
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Hashtable data_pack = new Hashtable();
            
            data_pack.Add("mode"        , var_esp_gpio_mode.SelectedValue.ToString());
            data_pack.Add("intr_type"   , var_esp_gpio_intr_type.SelectedValue.ToString());
            data_pack.Add("pull_up_en"  , var_esp_gpio_pull_up_en.SelectedValue.ToString());
            data_pack.Add("pull_down_en", var_esp_gpio_pull_down_en.SelectedValue.ToString());
            data_pack.Add("pin_bit_mask", var_esp_gpio_pin_bit_mask.Text);

            Hashtable pack = new Hashtable();
            pack.Add("act"      , "api.gpio_struct_write");
            pack.Add("target"   , "IO"+var_esp_gpio_pin_bit_mask.Text);
            pack.Add("data"     , data_pack);

            var foo = utils.json.Encode(pack);
            int a = 0;
            intercom._serial.Write(foo);
        }
        #endregion

        #region Action
        private void act_wire_info(object sender, EventArgs e)
        {
            //Hashtable pack = new Hashtable();
            //pack.Add("act", "gpio.info");
            //var T = utils.json.Encode(pack);
            //intercom._serial.Write( T );
        }
  
        private void btn_pin_group_Click(object sender, EventArgs e)
        {
            panel_tab1.Visible = true;
            panel_tab2.Visible = false;
            panel_tab3.Visible = false;

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

        private void cb_dtr_Handler(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            
            if(cb.Checked)
                win32_serial.SetCommFlag(intercom._serial, win32_serial.SETDTR);
            else
                win32_serial.SetCommFlag(intercom._serial, win32_serial.CLRDTR);
        }

        private void cb_rts_Handler(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;

            if (cb.Checked)
                win32_serial.SetCommFlag(intercom._serial, win32_serial.SETRTS);
            else
                win32_serial.SetCommFlag(intercom._serial, win32_serial.CLRRTS);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panel_tab2.Location = panel_tab1.Location;
            panel_tab2.Visible = true;
            panel_tab3.Visible = false;
            panel_tab1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_tab3.Location = panel_tab1.Location;
            panel_tab3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hashtable pack = new Hashtable();
            pack.Add("act", "api.get_pin_map");
            intercom._serial.Write(utils.json.Encode(pack));
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }// class
}
