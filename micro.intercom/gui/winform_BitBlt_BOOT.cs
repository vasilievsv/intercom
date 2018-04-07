/**
  ******************************************************************************
  * @date    
  * @version V0.0.0
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using l420;
using micro.sdk;

namespace app
{
    public partial class winform_BitBlt_BOOT : Form
    {
        private Graphics    cg;
        private Bitmap      cg_canvas;
        private Pen         cg_pen;
        private Brush       cg_brush;
        
        int _bar   = 0;
        int _boot_state = 0;
        
        Point pt1 = new Point();
        Point pt2 = new Point();
        
        static float lerp(float firstFloat, float secondFloat, float by)
        {
             return firstFloat * by + secondFloat * (1 - by);
        }
        
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed( e );
            Environment.Exit( 0 );
        }
        
        public winform_BitBlt_BOOT()
        {
            InitializeComponent();

            ///
            /// Thread: CG Render 
            /// 
            Task.Run( (Func<Task>)(() => 
            {
                cg_canvas = new Bitmap( 24, 8, PixelFormat.Format24bppRgb );
                cg_pen = new Pen( Color.Orange, 1 );
                cg_brush = new SolidBrush( Color.Red );
                cg = Graphics.FromImage( cg_canvas );

                cg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                var rnd  = new Random( 123 );

                int     ccnt        = 0;
                float   ccnt_tick   = 0f;
                var     ccnt_hold   = false;
                //var img_0 = global::SoundLightMachine.Properties.Resources._24x8_res0;
                while(true)
                {

                    cg.Clear( Color.Black );

                    switch(ccnt)
                    {
                        case 0:
                        {
                            var p1 = (int)lerp( 0, 4, ccnt_tick *2f);
                            var p2 = (int)lerp( 8, 4, ccnt_tick *2f);

                            _cg_line( 11, p1, 11, p2 );
                            _cg_line( 12, p1, 12, p2 );
                        }
                        break;

                        case 1:
                        {
                            var p1 = (int)lerp( 0, 11, ccnt_tick  );
                            var p2 = (int)lerp( 23,11, ccnt_tick);
                            _cg_line(  p1, 0, p1, 8 );
                            _cg_line(  p2, 0, p2, 8 );
                        }
                        break;

                        case 2:
                            ccnt_hold = true;
                        
                            if(_bar++ == 17)
                            {
                                ccnt_hold   = false;
                                ccnt_tick   = 0;
                                ccnt++;
                            }

                        _cg_line( 0, 0, 0, 7 );
                        _cg_line( 23, 0, 23, 7 );
                        cg.FillRectangle( cg_brush, new Rectangle( 3,3, _bar, 2 ) );
                                
                        break;

                        case 3:
                        cg.FillRectangle( cg_brush, new Rectangle( 3,3, _bar, 2 ) );
                        _cg_line( 0, 0, 0, 7 );
                        _cg_line( 23, 0, 23, 7 );
                        break;

                        case 4:
                        _cg_line( 0, 0, 0, 7 );
                        _cg_line( 23, 0, 23, 7 );
                        break;

                        case 5: ccnt = 0;
                        _bar = 0; break;
                    }

                    if( ccnt_hold == false && (ccnt_tick += 0.0925f) > 1f)
                    {
                        ccnt_tick = 0f;
                        ccnt += 1;
                    }

                    //profiler.start( "cg_bitblt", 200);
                    micro.sdk.intercom.frame32_CG_BITBLT( cg_canvas );
                    //profiler.stop( 200 );

                    // TODO: Object is currently in use elsewhere
                    pictureBox2.Image = (Bitmap)cg_canvas.Clone();
                    

                }
            }));
            
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
