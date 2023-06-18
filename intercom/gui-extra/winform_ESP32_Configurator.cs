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
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using micro.sdk;
using utils;

namespace app
{
    public partial class winform_ESP32_Configurator : Form
    {
        const string API_GET_MCU_INFO       = "api.get_mcu_info";
        const string API_GPIO_STRUCT_META   = "api.gpio_struct_meta";
        const string API_GPIO_STRUCT_READ   = "api.gpio_struct_read";
        const string API_GPIO_STRUCT_WRITE  = "api.gpio_struct_write";

        System.Windows.Forms.Timer _timer;

        bool flag_gpio_enum_ready = false;

        #region INITIALIZE
        public winform_ESP32_Configurator()
        {
            InitializeComponent();
            
            //intercom._resetPort();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1100;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }
   
        private void winform_remote_backdoor_Load(object sender, EventArgs e)
        {
            intercom.eventDataEncoded += IRQ_DataIncoming;
            //act_wire_info(null,null);
            //cmd_select_pin(null, null);
        }
        #endregion

        #region PACKAGE_ROUTINE
        private void _timer_Tick(object sender, EventArgs e)
        {
            Hashtable pack;
            
            //pack= new Hashtable();
            //    pack.Add("act", "api.get_mcu_info");
            //    pack.Add("did", "");
            //intercom._serial.Write(utils.json.Encode(pack));

            if (flag_gpio_enum_ready == false)
            {
                //Thread.Sleep(1100);

                pack = new Hashtable();
                pack.Add("act", "api.gpio_struct_meta");
                pack.Add("did", "");
                intercom._serial.Write(utils.json.Encode(pack));
            }
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

            if (_act == API_GET_MCU_INFO && _data.Count > 0)
            {
                var a1 = _data["cores"].ToString();
                var a2 = _data["features"].ToString();
                var a3 = _data["model"].ToString();
                var a4 = _data["revision"].ToString();
                var a5 = _data["cpu_freq"].ToString();
                var a6 = _data["free_heap"].ToString();
                var a7 = _data["time"].ToString();
                var a8 = _data["date"].ToString();

                Invoke(new Action(() =>
                {
                    var_esp_mode.Text = a3;
                    var_esp_time.Text = a7;
                    var_esp_date.Text = a8;
                    var_esp_cores.Text = a1;
                    var_esp_feature.Text = a2;
                    var_esp_revision.Text = a4;
                    var_esp_cpu_freq.Text = a5;
                    var_esp_free_heap.Text = a6;
                }));
            }

            //
            // Данные от ESP32
            //
            if (_act == API_GPIO_STRUCT_READ )
            {
                Invoke(new Action(() =>
                {
                    _kindex(ref var_esp_gpio_mode           , _data["mode"]);
                    _kindex(ref var_esp_gpio_intr_type      , _data["intr_type"]);
                    _kindex(ref var_esp_gpio_pull_up_en     , _data["pull_up_en"]);
                    _kindex(ref var_esp_gpio_pull_down_en   , _data["pull_down_en"]);
         
                    var_esp_gpio_pin_bit_mask.Text = _data["pin_bit_mask"].ToString();
                }));
            }

            if (_act == API_GPIO_STRUCT_META)
            {
                var a1 = _data["gpio_meta"] as Hashtable;
                var b1 = a1["intr_type"] as Hashtable;
                var b2 = a1["mode"] as Hashtable;
                var b3 = a1["pull"] as Hashtable;

                Invoke(new Action(() =>
                {
                    var_esp_gpio_mode.DataSource = new BindingSource(b2, null);
                    var_esp_gpio_pull_down_en.DataSource = new BindingSource(b3, null);
                    var_esp_gpio_pull_up_en.DataSource = new BindingSource(b3, null);
                    var_esp_gpio_intr_type.DataSource = new BindingSource(b1, null);

                    flag_gpio_enum_ready = true;
                }));
            }

        }//func:IRQ_DataIncoming
        
        // Установка выбранного элемента по Custom Value 
        int _kindex(ref ComboBox cb,object pack_value) 
        {
            var arg1_ = int.Parse(pack_value.ToString());
            foreach (var item in cb.Items)
            {
                var T = (DictionaryEntry)item;
                if (arg1_ == int.Parse(T.Value.ToString()))
                {
                    var T1 = cb.Items.IndexOf(item);
                    cb.SelectedIndex = T1;
                    return T1;
                }
            }
            return 0;
        }

        #endregion

        #region COMMAND
        private void cmd_select_pin(object sender, EventArgs e)
        {
            var _pin_name = (Label)sender;

            panel_tab1.Visible = false;
            panel_tab3.Visible = false;
            panel_tab2.Visible = true;
            panel_tab2.Location = panel_tab1.Location;

            Hashtable pack = new Hashtable();
            pack.Add("act", API_GPIO_STRUCT_READ);
            pack.Add("target", _pin_name.Text);
            
            intercom._serial.Write(utils.json.Encode(pack));
        }
        private void cmd_write_gpio(object sender, EventArgs e)
        {
            // Данные
            Hashtable data_pack = new Hashtable();
            
            data_pack.Add("mode"        , var_esp_gpio_mode.SelectedValue.ToString());
            data_pack.Add("intr_type"   , var_esp_gpio_intr_type.SelectedValue.ToString());
            data_pack.Add("pull_up_en"  , var_esp_gpio_pull_up_en.SelectedValue.ToString());
            data_pack.Add("pull_down_en", var_esp_gpio_pull_down_en.SelectedValue.ToString());
            data_pack.Add("pin_bit_mask", var_esp_gpio_pin_bit_mask.Text);

            // Заголовок
            Hashtable pack = new Hashtable();
            pack.Add("act"      , API_GPIO_STRUCT_WRITE);
            pack.Add("target"   , "IO"+var_esp_gpio_pin_bit_mask.Text);
            pack.Add("data"     , data_pack);

            var _encode = utils.json.Encode(pack);
            intercom._serial.Write( _encode );
        }
        #endregion

        #region COMMAND
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
