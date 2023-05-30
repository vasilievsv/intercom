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
    public partial class winform_BitmapTest : Form
    {
        private Graphics    cg;
        private Bitmap      cg_canvas;
        private Pen         cg_pen;
        private Brush       cg_brush;

        int _bar   = 0;
        int _boot_state = 0;

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

            //_port.ReadTimeout = 3000;
            var str = _port.ReadLine();

            var json = utils.json.Decode(str) as ArrayList;


            var T = json[0] as Hashtable;
            var K = T["data"] as ArrayList;


           
            
            cg_canvas = new Bitmap(720, 460, PixelFormat.Format24bppRgb);
            cg = Graphics.FromImage(cg_canvas);
            cg.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            for (int i = 0; i < K.Count; i++)
            {
                var B = Encoding.Default.GetBytes( K[i].ToString() );


                for (int j = 0; j < B.Length; j++)
                {
                    byte color = B[j];
                    cg_brush = new SolidBrush(Color.FromArgb(0xBE, color, 0x0));

                    var _x = i;
                    var _y = j;
                    cg.FillRectangle(cg_brush, new Rectangle(_x*25+8, _y*25+8, 24, 24));
                }

                log.print(BitConverter.ToString(B, 0, B.Length));
            }



            pictureBox2.Image = (Bitmap)cg_canvas.Clone();

        }
        public winform_BitmapTest()
        {
            InitializeComponent();

            intercom._resetPort();
            intercom._serial.DataReceived += IRQ_DataIncoming;


            int     ccnt        = 0;
            float   ccnt_tick   = 0f;
            float   ccnt_rest   = 1f;
            var     ccnt_hold   = false;

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
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void form_Picture_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList(intercom._parse(txtRequestBytes.Text));

            Hashtable pack = new Hashtable();
            pack.Add("cmd", "db.get_records");
            pack.Add("value", list);



            var T = utils.json.Encode( pack );
            intercom._serial.Write( T );
            log.print( T );
            
        }
    }
}
