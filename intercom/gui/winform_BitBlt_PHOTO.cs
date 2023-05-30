﻿/**
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
using utils;
using micro.sdk;

namespace app
{
    public partial class winform_BitBlt_PHOTO : Form
    {
        private Image _image;

        public winform_BitBlt_PHOTO()
        {
            InitializeComponent();

            intercom.PACK_BEGIN();
            intercom.WRITE = intercom.CG_CLEAR;
            intercom.WRITE = intercom._NOP;
            intercom.WRITE = (byte)0x00;
            intercom.WRITE = (byte)0x00;
            intercom.WRITE = (byte)0x00;
            intercom.PACK_END();
        }

        #region DRAG_AND_DROP

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            var _drop = e.Data.GetDataPresent( DataFormats.FileDrop );
            if (_drop)
                e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string [ ] files = (string [ ])e.Data.GetData( DataFormats.FileDrop );
            foreach(string file in files)
            { 
                Console.WriteLine( file );
                Console.ForegroundColor = ConsoleColor.Green;
                log.print( "CATCH.DragDrop " + file );
                _image = Image.FromFile( file );

                var gr = pictureBox2.CreateGraphics();
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                gr.DrawImage( _image, new Rectangle( 0, 0, pictureBox2.Width, pictureBox2.Height ), 0, 0, _image.Width, _image.Height, GraphicsUnit.Pixel );

                intercom.frame32_CG_BITBLT(new Bitmap( _image ) );
            }
        }
        #endregion

        private void winform_BitmapStatic_Load(object sender, EventArgs e)
        {
            #region DRAG_AND_DROP
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop  += new DragEventHandler(Form1_DragDrop);
            #endregion
        }
    }
}
