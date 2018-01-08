/**
  ******************************************************************************
   *@date    Sep-2017
  * @version V0.0.7
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Reflection;
using System.Threading;

namespace l420
{
    sealed public partial class intercom
    {
        public const byte       FRAME_SIZE  = 255;
        static public byte[]    _frame32    = new byte[FRAME_SIZE];
        static public byte      _cursor     = 0;

        ///
        ///
        ///
        static public void PACK_BEGIN()
        {
            Array.Clear( _frame32, 0, FRAME_SIZE );
            _cursor = 0;
        }
        ///
        ///
        ///
        static public void PACK_END()
        {
            _cursor = FRAME_SIZE;
            //CRC IMPLEMENT
            //WRITE = (byte)0x0A;
            //WRITE = (byte)0x0D;
            intercom.usart_TX = intercom._frame32;
        }
        ///
        ///
        ///
        static public object WRITE
        {
            set
            {
                var _type = value.GetType().Name.ToString();

                switch(_type)
                {
                    case "Byte": _frame32 [_cursor++] = (byte)value; break;

                    case "Byte[]":
                    {
                        byte [ ] T = (byte [ ])value;
                        var _len   = (byte)T.Length;

                        Array.Copy( T, 0, _frame32, _cursor, _len );
                        _cursor += _len; // передвинули курсор
                    }
                    break;
                }// switch

            }
        }

        ///
        ///
        ///
        static Bitmap bmp_24rgb = new Bitmap( 24, 8, PixelFormat.Format24bppRgb);
        static public void frame32_CG_BITBLT(Bitmap src_bmp)
        {
            byte _count = 0;
            byte [ ] frame32 = new byte [ ]
            {
                0x00,0x00,0x00,0x00,
                 
                0x00, 0x00, 0x00,
                0x00, 0x00, 0x00,
                0x00, 0x00, 0x00,
                0x00, 0x00, 0x00,
                0x00, 0x00, 0x00,
                0x00, 0x00, 0x00,
                0x00, 0x00, 0x00,
                0, 0, 0, 0,
                
                0,
                0x0A, 0x0D,
            };

            for(int line = 0; line != 8; line++)
            {
                for(int stride = 0; stride !=3; stride++)
                {
                   var T = _arrayFrom( src_bmp, _count * 24);
                   
                   Array.Copy( T, 0, frame32, 2, 24 );  // Копируем в массив на отправку новые данные

                   frame32 [5] = _count++;
                   frame32 [6] =  CG_BITBLT;
                   intercom.usart_TX = frame32;    // Отсылаем кадр
                }
               
            }
        }
        ///
        ///
        ///
        static public byte [ ] pack_int  (int value)    { return BitConverter.GetBytes( value ); }
        static public byte [ ] pack_float(float value)  { return BitConverter.GetBytes( value ); }


        ///
        /// Blitting means bit-boundary block transfer 
        ///
        static public byte[] _arrayFrom(Bitmap bmp, int _offset)
        {
            var rect    = new Rectangle( 0, 0, 24, 8);
            var ret     = new byte [24];
            var data    = bmp.LockBits( rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb );
            
            var ptr = (IntPtr)((long)data.Scan0 + _offset);

            System.Runtime.InteropServices.Marshal.Copy( ptr, ret, 0, 24 );

            bmp.UnlockBits(data);

            return ret;
        }
        
    }
}
