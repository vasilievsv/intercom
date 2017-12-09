/**
  ******************************************************************************
   *@date    Sep-2017
  * @version V0.0.3
  * @author  Vasiliev Sergey 
  * @brief   
  ******************************************************************************
*/
using System;
using System.IO.Ports;
using System.Text;

namespace l420
{
    sealed public partial class intercom
    {
        public const string ERROR_DEVICE_NOT_FOUND = "ERROR_DEVICE_NOT_FOUND";

        static public event System.Action   eventDataIncoming;
        static public event System.Action   eventConnect;
        static public event System.Action   eventPortNotFound;
        static public event System.Action   eventPinChangned;
        static public event System.Action   eventIRQError;

        static public byte [ ]      usart_RX = new byte[256]; // Recieve Buffer
        static public byte[]        _frameTX = new byte[32];

        static public bool   usart_online   = false;
        static public bool   use_debug      = false;
        static public string use_port       = String.Empty;


        static public SerialPort _createPort(string _name)
        {
            var T = new SerialPort();
                    T.PortName    = _name;
                    T.BaudRate    = 115200;
                    T.Parity      = Parity.None;
                    T.DataBits    = 8;
                    T.StopBits    = StopBits.One;
                    T.Handshake   = Handshake.None;
                    T.Encoding    = Encoding.ASCII;
                    
                    T.DataReceived += IRQ_DataIncoming;
                    T.ErrorReceived+= IRQ_Error;
                    T.PinChanged   += IRQ_PinChanged;
            return T;
        }


        ///
        ///
        ///
        static private void IRQ_DataIncoming(object sender, SerialDataReceivedEventArgs e)
        {
            var _port = (sender as SerialPort);
            
            _port.Read( usart_RX, 0, 32 );

            var crc = BitConverter.ToInt32 ( usart_RX, 0 );
            var size= BitConverter.ToUInt16( usart_RX, 4 );

            //читаем остальной кусок
           if(size > 32) _port.Read(usart_RX, 32, size-32 );
 
            if(use_debug==true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                micro.print(BitConverter.ToString( usart_RX, 0, size ) );
                Console.ResetColor();
            }

            //
            // TODO: simple discovery proto 
            //if(usart_RX [0] == PROTO_CONNECT)
            //{
            //    usart_online = true;
            //    _serial      = _port;
            //
            //    if(eventConnect != null)
            //        eventConnect();
            //}

            if(eventDataIncoming != null)
            {
                eventDataIncoming();
            }
        }
        /// 
        /// 
        /// 
        static public string[] usart_EnumPort()
        {
            return SerialPort.GetPortNames();
        }
        /// 
        /// 
        /// 
        static public void usart_Close()
        {
            usart_online = false;

            foreach(var p in _list)
            {
                p.Close();
                p.Dispose();
            }
        }
        ///
        ///
        ///
        static public void usart_Open(string _port = "auto")
        {
            l420.micro.print( "" );

            var _names = usart_EnumPort();

            if(_names.Length == 0)
            {
                l420.micro.begin( ConsoleColor.Yellow );
                
                l420.micro.end();

                if(eventPortNotFound != null)
                   eventPortNotFound( );
            }
            else if(_port == "auto")
            {
                micro.begin( ConsoleColor.White );
                _list = new SerialPort [_names.Length];

                l420.micro.print( "Start Discovery (devices "+ _list.Length +")" );
                for(int i = 0; i != _list.Length; i++)
                {
                    var T = _createPort(_names[i]);
                    T.Open();
                    
                    _serial = T; // hack: переключаем для отправки в текущий порт
                    FRAME_BEGIN();
                        WRITE = PROTO_CONNECT;
                    FRAME_END();
                    _list [i] = T;
                }
                micro.end();

            }
            else
            {
                _serial = _createPort( _port );
                _serial.Open();
                usart_online = true;
            }
        }


        ///
        ///
        ///
        
        static public object usart_TX
        {
            get { return _frameTX; }
            set
            {
                var _type = value.GetType();
                
                if(object.Equals( _type, typeof( byte [ ] ) ))
                {
                    // четыре байта под crc
                    // два байта под size
                    // Последние два зарезервированы
                    for(int i = 0; i != (value as byte [ ]).Length; i++)
                    {
                        if(i >=26) continue;
                        _frameTX [4+1+i] = (value as byte [ ]) [i];
                    }

                    //
                    // CRC32
                    //
                    var  decoded = new uint [(_frameTX.Length - 4) / 4]; // get 28 byte's
                    Buffer.BlockCopy( _frameTX, 4, decoded, 0, _frameTX.Length - 4 );
                    var crc = crc_stm32.fromArray( init_value:0xFFFFFFFF, buffer:decoded );

                    _frameTX [0] = (byte)crc;
                    _frameTX [1] = (byte)(crc >> 8);
                    _frameTX [2] = (byte)(crc >> 0x10);
                    _frameTX [3] = (byte)(crc >> 0x18);

                    _frameTX [4] = (byte)(_frameTX.Length);

                    if(_serial != null && _serial.IsOpen)
                    {
                        _serial.Write( _frameTX, 0, 32 );
                    }
                    
                    if(use_debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        l420.micro.print( BitConverter.ToString( _frameTX, 0, _frameTX.Length ) );
                        Console.ResetColor();
                    }
                    
                }//if(object...
                
            }
        }
        
        static void usart_set(SerialPort _ref)
        {
            _serial = _ref;
        }
        
        ///
        ///
        ///
        static private void IRQ_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            
            if(eventPinChangned != null)
                eventPinChangned();
        }
        ///
        ///
        ///
        static private void IRQ_Error(object sender, SerialErrorReceivedEventArgs e)
        {
            
            if(eventIRQError != null)
                eventIRQError( );
        }
        

        static public SerialPort[]  _list       = { };
        static public SerialPort[]  _list_uart  = { };
        static public SerialPort    _serial     = null;
        
        static public void usart_DumpLast(ref byte[] _ref)
        {

            micro.begin( ConsoleColor.White );
            micro.print( ">> crc\t:"    + BitConverter.ToInt32( _ref, 0 ).ToString("X"));
            micro.print( ">> size\t:"   + BitConverter.ToUInt16( intercom.usart_RX, 4 ) );
            micro.end();
        }

    }// class end
}
