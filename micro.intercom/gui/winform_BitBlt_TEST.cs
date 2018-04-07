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
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using l420;

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

        public winform_BitmapTest()
        {
            InitializeComponent();
            
            int     ccnt        = 0;
            float   ccnt_tick   = 0f;
            float   ccnt_rest   = 1f;
            var     ccnt_hold   = false;

            ///
            /// Thread: CG Render 
            /// 
            Task.Run( () => 
            {
                cg_canvas   = new Bitmap( 24, 8, PixelFormat.Format24bppRgb );
                cg_pen      = new Pen( Color.Orange, 1 );
                cg_brush    = new SolidBrush( Color.Red );
                var cg_brush1   = new SolidBrush( Color.ForestGreen);
                cg          = Graphics.FromImage( cg_canvas );

                int x = 10;
                        var rnd = new Random();
                while(true)
                {
                    cg.Clear( Color.Black );

                    var _w = (int)EaseOutQuad(0,24,ccnt_tick);
                    var _h = (int)EaseOutQuad(0,8,ccnt_tick*0.5f);
                    var _x = (23-_w)/2+1;
                    var _y = (7-_h)/2+1;
                    //cg.FillRectangle( cg_brush, new Rectangle( _x, _y, _w, _h ) );


                    //cg.FillRectangle( cg_brush1, new Rectangle( (int)EaseQuad( 0, 24, ccnt_tick ), 0, 1, 8 ) );
                    //cg.FillRectangle( cg_brush1, new Rectangle( (int)EaseOutQuad( 16, 0, ccnt_tick), 0, 1, 8 ) );

                    if( (ccnt_tick+=0.0559999f) > 1f)
                    {
                        ccnt_tick = 0f;
                        //ccnt += 1;

                        //cg_brush = new SolidBrush( Color.FromArgb( rnd.Next(0,255), rnd.Next(0,255), rnd.Next(0,255) ) );
                    }
                    // TODO: Object is currently in use elsewhere
                    pictureBox2.Image = (Bitmap)cg_canvas.Clone();
                }
            });

            
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
    }
}
