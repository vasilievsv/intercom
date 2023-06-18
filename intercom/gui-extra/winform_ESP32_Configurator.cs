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

            pack = new Hashtable();
            pack.Add("act", "api.get_mcu_info");
            pack.Add("did", "");
            intercom._serial.Write(utils.json.Encode(pack));

            if (flag_gpio_enum_ready == false)
            {
                Thread.Sleep(100);

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
                Invoke(new Action(() =>
                {
                    var_esp_cores.Text = _data["cores"].ToString();
                    var_esp_feature.Text = _data["features"].ToString();
                    var_esp_mode.Text = _data["model"].ToString();
                    var_esp_revision.Text = _data["revision"].ToString();
                    var_esp_cpu_freq.Text = _data["cpu_freq"].ToString();
                    var_esp_free_heap.Text = _data["free_heap"].ToString();
                    var_esp_time.Text = _data["time"].ToString();
                    var_esp_date.Text = _data["date"].ToString();
                }));
            }

            //
            // Данные от ESP32
            //
            if (_act == API_GPIO_STRUCT_READ )
            {
                Invoke(new Action(() =>
                {
                    helper_cb_set(ref var_esp_gpio_mode           , _data["mode"]);
                    helper_cb_set(ref var_esp_gpio_intr_type      , _data["intr_type"]);
                    helper_cb_set(ref var_esp_gpio_pull_up_en     , _data["pull_up_en"]);
                    helper_cb_set(ref var_esp_gpio_pull_down_en   , _data["pull_down_en"]);
         
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
        #endregion

        #region HELPER_COMBOBOX
        // Установка выбранного элемента по Custom Value 
        void helper_cb_set(ref ComboBox cb, object pack_value)
        {
            var arg1_ = int.Parse(pack_value.ToString());
            foreach (var item in cb.Items)
            {
                var T = (DictionaryEntry)item;
                if (arg1_ == int.Parse(T.Value.ToString()))
                {
                    var T1 = cb.Items.IndexOf(item);
                    cb.SelectedIndex = T1;
                }
            }
        }
        int helper_cb_get(ref ComboBox cb) 
        { 
            return int.Parse(((DictionaryEntry)cb.SelectedItem).Value.ToString()); 
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
            Hashtable data_pack = new Hashtable
            {
                { "mode"        , helper_cb_get(ref var_esp_gpio_mode) },
                { "intr_type"   , helper_cb_get(ref var_esp_gpio_intr_type)},
                { "pull_up_en"  , helper_cb_get(ref var_esp_gpio_pull_up_en) },
                { "pull_down_en", helper_cb_get(ref var_esp_gpio_pull_down_en) },
                { "pin_bit_mask", var_esp_gpio_pin_bit_mask.Text }
            };

            // Заголовок
            Hashtable pack = new Hashtable
            {
                { "act"     , API_GPIO_STRUCT_WRITE },
                { "target"  , "IO" + var_esp_gpio_pin_bit_mask.Text },
                { "data"    , data_pack }
            };

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
