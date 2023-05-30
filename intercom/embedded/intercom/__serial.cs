/**
  ******************************************************************************
  * @date    Sep-2017
  * @version V0.0.3
  * @author  Vasiliev Sergey 
  * @brief   
  ******************************************************************************
*/
using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using utils;

namespace micro.sdk
{
    sealed public partial class intercom
    {
        public const string ERROR_DEVICE_NOT_FOUND = "ERROR_DEVICE_NOT_FOUND";

        static public event System.Action<object,string> eventDataEncoded;

        //static public event System.Action   eventDataIncoming;
        //static public event System.Action   eventConnect;
        static public event System.Action   eventPortNotFound;
        static public event System.Action   eventPinChangned;
        static public event System.Action   eventIRQError;

        static public byte[]      usart_RX = new byte[4096]; //!!! TODO: Буффер приема Recieve Buffer
        static public byte[]      _frameTX = new byte[4096]; //!!! TODO: Буффер приема

        static public bool   usart_online   = false;
        static public bool   use_debug      = false;
        static public string use_port       = String.Empty;


        static public SerialPort _createPort(string _name)
        {
            var T = new SerialPort();
                    T.PortName    = _name;
                    T.BaudRate    = 9600;
                    T.Parity      = Parity.Even;
                    T.DataBits    = 8;
                    T.StopBits    = StopBits.One;
                    T.Encoding    = Encoding.Default;
            T.Handshake = Handshake.None;

            T.ErrorReceived += IRQ_Error;
            T.DataReceived += IRQ_DataIncoming;
            T.PinChanged += IRQ_PinChanged;

            var rb = T.WriteBufferSize;
            var tb = T.ReadBufferSize;

            return T;
        }


        public static void init_serial()
        {
            intercom.use_debug = argv.check_key(main.KEY_DEBUG);

            //intercom.eventDataEncoded += delegate (byte opcode, byte[] data)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkYellow;
            //    utils.log.print(BitConverter.ToString(data, 0, data.Length));
            //    Console.ResetColor();
            //};

            var port_arg = argv.get_str(main.KEY_PORT, _bydefault: "auto");
            var port_arg_buff = port_arg.Split(':'); //COM5:115200:8E1:42:42

            // валидация выхода за границу массива аргументов
            // последний ключ без значения
            intercom.usart_Open(port_arg_buff[0]);

            if (intercom._serial == null)
            {
                log.print("отсутствует серийный порт");
            }
            else
            {
                intercom._serial.BaudRate = (1 >= port_arg_buff.Length) ? (115200) : int.Parse(port_arg_buff[1]);

                var _buff = (2 >= port_arg_buff.Length) ? new char[0] : port_arg_buff[2].ToCharArray();
                intercom._serial.DataBits = (0 >= _buff.Length) ? 8 : intercom.GetDataBit(_buff[0]);
                intercom._serial.Parity = (1 >= _buff.Length) ? Parity.Even : intercom.GetParityFrom(_buff[1]);
                intercom._serial.StopBits = (2 >= _buff.Length) ? StopBits.One : intercom.GetStopBit(_buff[2]);
               // intercom._serial.Handshake = Handshake.RequestToSend;
                intercom._serial.Open();
            }
        }
        static public void _resetPort()
        {
            intercom._serial.DataReceived -= IRQ_DataIncoming;
        }
        
        ///
        /// FF-FF-FF-FF FF-FF-12 A1-03-FF-FF-FF
        ///  ^           ^  ^     ^  ^
        ///
        unsafe static private void IRQ_DataIncoming(object sender, SerialDataReceivedEventArgs e)
        {
            var _port = (sender as SerialPort);
            
            //Thread.Sleep(15);

            var _size = _port.Read( usart_RX, 0, 4096);
            var _buff = new byte[_size];

            Array.Copy(usart_RX,0 ,_buff,0 , _buff.Length);
            usart_RX = new byte[usart_RX.Length];

            var _raw_str = BitConverter.ToString(_buff, 0, _buff.Length);

            // Если есть подписчик на событие
            if (eventDataEncoded != null)
                eventDataEncoded(0x0, System.Text.Encoding.UTF8.GetString(_buff) );

            if (use_debug == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //log.print(BitConverter.ToString(_buff, 0, _buff.Length));
                log.print(System.Text.Encoding.UTF8.GetString(_buff));
                Console.ResetColor();
            }
            
            return;

            ///
            /// Этот код от протокола к stm32
            ///
            //var pack_crc = BitConverter.ToInt32 ( usart_RX, 0 );
            //var pack_size= BitConverter.ToUInt16( usart_RX, 4 );
            //var pack_cfg = BitConverter.ToChar  ( usart_RX, 6 );



            /// Разбираем массив в соответсвии с описанием формата пакета
            /// и генерируем event'ы
            ///int _cursor = 7; // с седьмого байта
            //while(_cursor <= (pack_size))
            //{
            //    var _opcode = (byte)BitConverter.ToChar( usart_RX, _cursor );
            //    var _size   = (byte)BitConverter.ToChar( usart_RX, _cursor + 1 );
            //    var _buff   = new byte [_size];

            //    Array.Copy( usart_RX, _cursor+2, _buff, 0, _size );
            //    _cursor += _size+3;

            //    //micro.print(BitConverter.ToString( _buff, 0, _buff.Length) );
            //    if(eventDataEncoded != null)
            //        eventDataEncoded( _opcode, _buff );

            //};

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
            utils.log.print( "" );

            var _names = usart_EnumPort();

            if(_names.Length == 0)
            {
                utils.log.begin( ConsoleColor.Yellow );
                
                utils.log.end();

                if(eventPortNotFound != null)
                   eventPortNotFound( );
            }
            else if(_port == "auto")
            {
                utils.log.begin( ConsoleColor.White );
                _list = new SerialPort [_names.Length];
                
                utils.log.print( "Start Discovery (devices "+ _list.Length +")" );
                for(int i = 0; i != _list.Length; i++)
                {
                    var T = _createPort(_names[i]);
                    T.Open();
                    
                    _serial = T; // hack: for OPENGL like style 
                    PACK_BEGIN();
                        WRITE = PROTO_CONNECT;
                    PACK_END();
                    _list [i] = T;
                }
                log.end();

            }
            else
            {
                _serial = _createPort( _port );
               
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
                
                if(object.Equals( _type, typeof( byte [ ] ) ) && (value as byte [ ]).Length>0)
                {
                    var buff = (value as byte[]);

                    switch ("to_raw")
                    {
                        case "to_raw":
                        {
                            if (_serial != null && _serial.IsOpen)
                            {
                                _serial.Write(buff, 0, buff.Length);
                                    
                            }
                        }
                        break;
                        //case "to_crc32":
                        //{
                        //        // четыре байта под crc
                        //        // два байта под size
                        //        // Последние два зарезервированы


                        //        Buffer.BlockCopy(buff, 0, _frameTX, 7, buff.Length);

                        //        _frameTX[4] = (byte)(buff.Length + 7);
                        //        _frameTX[5] = 0x00;
                        //        _frameTX[6] = 0xFF;

                        //        //
                        //        // CRC32
                        //        //
                        //        var decoded = new uint[(buff.Length + 3) / 4];
                        //        Buffer.BlockCopy(_frameTX, 4, decoded, 0, buff.Length - 4);
                        //        var crc = crc_stm32.fromArray(init_value: 0xFFFFFFFF, buffer: decoded);

                        //        _frameTX[0] = (byte)crc;
                        //        _frameTX[1] = (byte)(crc >> 8);
                        //        _frameTX[2] = (byte)(crc >> 0x10);
                        //        _frameTX[3] = (byte)(crc >> 0x18);

                        //        var cnt = (buff.Length < (32 - 7)) ? 32 : (buff.Length + 7);
                        //        if (_serial != null && _serial.IsOpen)
                        //        {
                        //            _serial.Write(_frameTX, 0, cnt);
                        //        }

                        //    }
                        //    break; 
                    }

                    if (use_debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        utils.log.print(BitConverter.ToString(buff, 0, buff.Length));
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

            log.begin( ConsoleColor.White );
            log.print( ">> crc\t:"    + BitConverter.ToInt32( _ref, 0 ).ToString("X"));
            log.print( ">> size\t:"   + BitConverter.ToUInt16( intercom.usart_RX, 4 ) );
            log.end();
        }



        static public Parity GetParityFrom(char _key)
        {
            switch (_key)
            {
                case 'N': return Parity.None;
                case 'E': return Parity.Even;

            }
            return Parity.None;
        }

        static public StopBits GetStopBit(char _key)
        {

            switch (_key)
            {
                case '0': return StopBits.None;
                case '1': return StopBits.One;
                case '2': return StopBits.Two;
                case '3': return StopBits.OnePointFive;

            }
            return StopBits.None;
        }

        static public int GetDataBit(char _key)
        {
            int number;

            bool success = Int32.TryParse(_key.ToString(), out number);
            if (success)
            {

                return number;
            }


            return 8;
        }

    }// class end
}
