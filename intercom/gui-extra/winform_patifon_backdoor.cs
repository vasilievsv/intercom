/**
  ******************************************************************************
  * @date    
  * @version V0.0.0
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************
    
    https://material.io/guidelines/motion/material-motion.html
    https://gist.github.com/cjddmut/d789b9eb78216998e95c
    
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

namespace app
{
    public partial class winform_patifon_backdoor : Form
    {
        private Graphics    cg = null;
        private Bitmap      cg_canvas = null;
        private Pen         cg_pen = null;
        private Brush       cg_brush = null;

        //int _bar;
        //int _boot_state;

        Point pt1 = new Point();
        Point pt2 = new Point();
 
        static float interpolate(float firstFloat, float secondFloat, float by)
        {
             return firstFloat * by + secondFloat * (1 - by);
        }

        public static float EaseInQuad(float start, float end, float value)
        {
            end -= start;
            return end * value * value + start;
        }

        public static float EaseOutQuad(float start, float end, float value)
        {
            end -= start;
            return -end * value * (value - 2) + start;
        }
       
        unsafe  private void IRQ_DataIncoming(object sender, SerialDataReceivedEventArgs e)
        {
            var _port = (sender as SerialPort);
            
            var str = _port.ReadLine();
            
            var json_array  = utils.json.Decode(str) as ArrayList;
            var T           = json_array[0] as Hashtable;
            var json_data   = T["data"] as Hashtable;


            cg_canvas = new Bitmap(pictureBox2.Width-1, pictureBox2.Height-1, PixelFormat.Format24bppRgb);
            cg = Graphics.FromImage(cg_canvas);
            cg.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            var _block_size = 5;
            var _global_offset_x = 20;// pictureBox2.Width / 2;
            var _global_offset_y = 20;// pictureBox2.Height/ 2;

            //
            // render
            //
            var array_ts    = json_data["json_array1"] as ArrayList;  // ts
            var array_in    = json_data["json_array2"] as ArrayList;  // input
            var array_out   = json_data["json_array3"] as ArrayList;  // out
            var array_delay = json_data["json_array4"] as ArrayList;  // out

            long _tmp_last_ts = 0;
            for (int i = 0; i < array_ts.Count; i++)
            {
                var _delay_ms   = Convert.ToInt32( array_delay[i] );
                var _ts         = Convert.ToInt64( array_ts[i] );
                float _ts_ms    = (int)(_ts - ((_tmp_last_ts == 0) ? _ts : _tmp_last_ts))/1000;


                var _bytes_input= Encoding.Default.GetBytes( array_in[i].ToString() );

                
                int _time_offset = (int)(_ts_ms * float.Parse(textBox1.Text));
                int _time_delay = (int)(_delay_ms + _time_offset);

                // RENDER INPUT BYTES
                for (int j = 0; j < _bytes_input.Length; j++)
                {
                    byte color = _bytes_input[j];
                    cg_brush = new SolidBrush(Color.FromArgb(255, color, color, 0));
                    
                    var _x = (i * _block_size + _time_offset) + _global_offset_x;
                    var _y = (j * (_block_size+5)) + _global_offset_y;
                    
                    cg.FillRectangle(cg_brush, new Rectangle(_x, _y, _block_size, _block_size+4));
                }
                // RENDER OUTPUT BYTES
                var _bytes_output = Encoding.Default.GetBytes(array_in[i].ToString());
                for (int j = 0; j < _bytes_output.Length; j++)
                {
                    byte color = _bytes_output[j];
                    cg_brush = new SolidBrush(Color.FromArgb(255, 0, color, color));

                    var _x = (i * _block_size + _time_delay) + _global_offset_x;
                    var _y = (j * (_block_size + 5)) + _global_offset_y;

                    cg.FillRectangle(cg_brush, new Rectangle(_x, _y, _block_size, _block_size+4));
                }

                _tmp_last_ts = _ts;
                //log.print(BitConverter.ToString(_bytes_input, 0, _bytes_input.Length));
            }

            pictureBox2.Image = (Bitmap)cg_canvas.Clone();


        }
        public winform_patifon_backdoor()
        {
            InitializeComponent();

            intercom._resetPort();
            intercom._serial.DataReceived += IRQ_DataIncoming;


            //int     ccnt        = 0;
            //float   ccnt_tick   = 0f;
            //float   ccnt_rest   = 1f;
            //var     ccnt_hold   = false;

            ///
            /// Thread: CG Render 
            /// 
            //Task.Run( () => 
            //{
            //    cg_canvas   = new Bitmap( 24, 8, PixelFormat.Format24bppRgb );
            //    cg          = Graphics.FromImage( cg_canvas );
            //    cg_pen      = new Pen( Color.Orange, 1 );
            //    cg_brush    = new SolidBrush( Color.Red );
            //    var cg_brush1   = new SolidBrush( Color.ForestGreen);

            //    int x = 10;
            //            var rnd = new Random();
            //    while(true)
            //    {
            //        cg.Clear( Color.Black );

            //        var _w = (int)EaseOutQuad(0,24,ccnt_tick);
            //        var _h = (int)EaseOutQuad(0,8,ccnt_tick*0.5f);
            //        var _x = (23-_w)/2+1;
            //        var _y = (7-_h)/2+1;
            //        cg.FillRectangle( cg_brush, new Rectangle( _x, _y, _w, _h ) );


            //        //cg.FillRectangle( cg_brush1, new Rectangle( (int)EaseQuad( 0, 24, ccnt_tick ), 0, 1, 8 ) );
            //        cg.FillRectangle( cg_brush1, new Rectangle( (int)EaseOutQuad( 16, 0, ccnt_tick), 0, 1, 8 ) );

            //        if( (ccnt_tick+=0.0559999f) > 1f)
            //        {
            //            ccnt_tick = 0f;
            //            //ccnt += 1;

            //            //cg_brush = new SolidBrush( Color.FromArgb( rnd.Next(0,255), rnd.Next(0,255), rnd.Next(0,255) ) );
            //        }
            //        // TODO: Object is currently in use elsewhere
            //        pictureBox2.Image = (Bitmap)cg_canvas.Clone();
            //    }
            //});

            
        }
 
        public void IRQ_PackEncoded(byte opcode, byte[] data)
        {

                


            /// !!! cross thread update
            //Invoke(new Action(() => { now_second.Text = dt.ToString("ss"); }));
            //Invoke(new Action(() => { now_time.Text = dt.ToString("hh:mm"); }));
            //Invoke(new Action(() => { now_tzd.Text = Convert.ToString(json["timezone"]); }));
            //Invoke(new Action(() =>
            //{
               
            //}));

        }

        void _cg_line(int x1, int y1, int x2, int y2)
        {
            pt1.X = x1; pt2.X = x2;
            pt1.Y = y1; pt2.Y = y2;
            cg.DrawLine( cg_pen, pt1, pt2 );
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList data = new ArrayList( intercom._parse(txtRequestBytes.Text) );
            Hashtable pack = new Hashtable();

            pack.Add("cmd", "db.get_records");
            pack.Add("value", data);

            
            var T = utils.json.Encode( pack );
            intercom._serial.Write( T );
            log.print( T );
            
        }
    }
}
