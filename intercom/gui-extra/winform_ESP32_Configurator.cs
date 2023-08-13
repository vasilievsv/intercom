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
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;


namespace app
{
    public partial class winform_ESP32_Configurator : Form
    {
        System.Windows.Forms.Timer _timer;

        const string API_GET_MCU_INFO       = "api.get_mcu_info";
        const string API_GPIO_STRUCT_META   = "api.gpio_struct_meta";
        const string API_GPIO_STRUCT_READ   = "api.gpio_struct_read";
        const string API_GPIO_STRUCT_WRITE  = "api.gpio_struct_write";

        const string API_OTA_STRUCT_WRITE   = "api.ota_struct_write";
        const string API_OTA_STRUCT_READ    = "api.ota_struct_read";
        const string API_OTA_STRUCT_SAVE    = "api.ota_struct_save";
        const string API_OTA_DO_UPDATE      = "api.ota_do_update";

        bool flag_gpio_enum_ready = false;

        
        public winform_ESP32_Configurator()
        {
            InitializeComponent();
            
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1100;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }


        private void winform_Load(object sender, EventArgs e)
        {
            intercom.eventDataEncoded += IRQ_DataIncoming;

            MyTab_init
            (
                new Button[] { btn_tab1, btn_tab2, btn_tab3 },
                new Panel[]  { panel_tab1, panel_tab2, panel_tab3 }
            );

            foreach (Control c in this.panel1.Controls)
            {
                if (c is Label)
                {
                    c.BackColor = System.Drawing.Color.Black;
                    c.ForeColor = System.Drawing.Color.White;
                }
            }

        }

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

        #region SERIAL_PORT

        unsafe private void IRQ_DataIncoming(object sender, string str)
        {
            var json_array = utils.json.Decode(str) as Hashtable;
            // Только валидный json
            if (json_array == null)
                return;

            var _act = json_array["act"] as string;
            var _did = json_array["did"] as string;
            var _data= json_array["data"] as Hashtable;

            #region PACKAGE_HANDLER_INFO
            if (_act == API_GET_MCU_INFO && _data.Count > 0)
            {
                Invoke(new Action(() =>
                {
                    var_esp_cores.Text      = _data["cores"].ToString();
                    var_esp_feature.Text    = _data["features"].ToString();
                    var_esp_mode.Text       = _data["model"].ToString();
                    var_esp_revision.Text   = _data["revision"].ToString();
                    var_esp_cpu_freq.Text   = _data["cpu_freq"].ToString();
                    var_esp_free_heap.Text  = _data["free_heap"].ToString();
                    var_esp_time.Text       = _data["time"].ToString();
                    var_esp_date.Text       = _data["date"].ToString();
                }));
            }
            #endregion

            #region PACKAGE_HANDLER_API_GPIO
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
                var T = _data["gpio"] as Hashtable;

                var _meta = T["gpio_meta"] as Hashtable; 
                var b1 = _meta["intr_type"] as Hashtable;
                var b2 = _meta["mode"] as Hashtable;
                var b3 = _meta["pull"] as Hashtable;

                Invoke(new Action(() =>
                {
                    flag_gpio_enum_ready = true;

                    var_esp_gpio_mode.DataSource            = new BindingSource(b2, null);
                    var_esp_gpio_pull_down_en.DataSource    = new BindingSource(b3, null);
                    var_esp_gpio_pull_up_en.DataSource      = new BindingSource(b3, null);
                    var_esp_gpio_intr_type.DataSource       = new BindingSource(b1, null);
                }));

                //
                // Colorize Pin map
                //
                var _pin_array = T["gpio_default_array"] as Hashtable;
                Invoke(new Action(() =>
                {
                    // my pin
                    // https://stackoverflow.com/questions/11284113/find-the-label-which-contains-the-required-text

                    foreach (Control c in this.panel1.Controls)
                    {
                        if (c is Label)
                        {
                            foreach (DictionaryEntry s in _pin_array)
                            {
                                if (c.Text == s.Key.ToString())
                                { 
                                    c.BackColor = System.Drawing.Color.LightGreen;
                                    c.ForeColor = System.Drawing.Color.Black;
                                    break;
                                }
                            }
                       
                        }
                    }
                }));


            }
            #endregion

            #region PACKAGE_HANDLER_API_OTA
            if (_act == API_OTA_STRUCT_READ)
            {
                var a1 = _data["host"].ToString();
                var b1 = _data["host_port"].ToString();
                var b2 = _data["host_file"].ToString();

                Invoke(new Action(() =>
                {
                    var_ota_host.Text = a1;
                    var_ota_port.Text = b1;
                    var_ota_path.Text = b2;
                }));
            }
            #endregion

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

        private void cmd_write_gpio(object sender, EventArgs e)
        {
            // Данные
            Hashtable data_pack = new Hashtable
            {
                { "mode"        , helper_cb_get(ref var_esp_gpio_mode) },
                { "intr_type"   , helper_cb_get(ref var_esp_gpio_intr_type)},
                { "pull_up_en"  , helper_cb_get(ref var_esp_gpio_pull_up_en) },
                { "pull_down_en", helper_cb_get(ref var_esp_gpio_pull_down_en) },
                { "pin_bit_mask", int.Parse( var_esp_gpio_pin_bit_mask.Text ) }
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

        #region CONTROLS
        private void act_wire_info(object sender, EventArgs e)
        {
            //Hashtable pack = new Hashtable();
            //pack.Add("act", "gpio.info");
            //var T = utils.json.Encode(pack);
            //intercom._serial.Write( T );
        }
  
        private void btn_pin_group_Click(object sender, EventArgs e)
        {
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        #region COMMAND_OTA
        private void btn_ota_struct_read(object sender, EventArgs e)
        {
            // Данные
            Hashtable data_pack = new Hashtable
            {
                { "param_1", "?" },
                { "param_2", "?" },
                { "param_3", "?" }
            };

            // Заголовок
            Hashtable pack = new Hashtable
            {
                { "act"     , API_OTA_STRUCT_READ },
                { "did"     , "root.ctrl.ota"},
                { "target"  , "table_var" },
                { "data"    , data_pack }
            };

            intercom._serial.Write(utils.json.Encode(pack));
        }
        private void btn_ota_struct_write(object sender, EventArgs e)
        {
            Hashtable pack = new Hashtable
            {
                { "act"     , API_OTA_STRUCT_WRITE },
                { "target"  , "table_var" },
                { "did"     , "root.ctrl.ota"},
                { "data"    , new Hashtable{
                    { "host", var_ota_host.Text },
                    { "host_port", var_ota_port.Text },
                    { "host_file", var_ota_path.Text },
                    { "use_https", true }
                } }
            };

            intercom._serial.Write(utils.json.Encode(pack));
        }
        private void btn_ota_do_update(object sender, EventArgs e)
        {
            // Заголовок
            Hashtable pack = new Hashtable
            {
                { "act"     , API_OTA_DO_UPDATE },
                { "target"  , "table_var" },
                { "did"     , "root.ctrl.ota"},
                { "data"    , new Hashtable{
                    { "flag_do_update", 1 } 
                } }
            };

            intercom._serial.Write(utils.json.Encode(pack));
        }
        #endregion

        #region MY_TAB

        Button[] _tab_buttons;
        Panel[]  _tab_views;

        private void MyTab_init(Button[] buttons, Panel[] views)
        {
            _tab_buttons = buttons;
            _tab_views = views;

            // События от кнопок
            foreach (var p in buttons)
            {
                p.MouseDown += MyTab_SelectBy;
            }

            // Скрываем панели по дефолту
            foreach (var _view in views)
            {
                _view.Location = new Point(tab_render.Location.X, tab_render.Location.Y + tab_render.Height);
                _view.Visible = false;
            }

            // Активируем первый там
            MyTab_SelectBy(buttons[0]);
        }

        private void MyTab_SelectBy(object sender, MouseEventArgs e = null)
        {
            Button T = (Button)sender;

            // hide all views
            foreach (var _view in _tab_views)
                _view.Visible = false;
            // Activate panel by button index
            _tab_views[Array.IndexOf(_tab_buttons, T)].Visible = true;

            Bitmap cg_canvas;
            Graphics cg;
            Brush cg_brush_active = new SolidBrush(Color.Red); ;
            Brush cg_brush_inactive = new SolidBrush(Color.LightGray);

            cg_canvas = new Bitmap(tab_render.Width, tab_render.Height, PixelFormat.Format24bppRgb);
            cg = Graphics.FromImage(cg_canvas);

            int _pos;

            cg.Clear(Color.White);

            // gray line
            foreach (var _btns in _tab_buttons)
            {
                _pos = Math.Abs(tab_render.Location.X - _btns.Location.X) + (_btns.Width / 2) - (48 / 2);
                cg.FillRectangle(cg_brush_inactive, new Rectangle(_pos, 0, 48, 4));
            }

            // active line
            _pos = Math.Abs(tab_render.Location.X - T.Location.X) + (T.Width / 2) - (48 / 2);
            cg.FillRectangle(cg_brush_active, new Rectangle(_pos, 0, 48, 4));

            tab_render.Image = (Bitmap)cg_canvas.Clone();
        }
        #endregion

        #region MY_PIN_MAP
        private void my_pin_select_handler(object sender, EventArgs e)
        {
            var _pin_name = (Label)sender;

            Hashtable pack = new Hashtable();
            pack.Add("act", API_GPIO_STRUCT_READ);
            pack.Add("target", _pin_name.Text);

            intercom._serial.Write(utils.json.Encode(pack));
        }

        #endregion
    }// class
}
