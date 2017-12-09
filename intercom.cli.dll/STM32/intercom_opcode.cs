/**
  ******************************************************************************
   *@date    3-Sep-2017
  * @version V0.0.1
  * @author  Vasiliev Sergey, Michael Kargapoltsev
  * @brief   
  ******************************************************************************
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Text.RegularExpressions;

namespace l420
{
    sealed public partial class intercom
    {
        private const byte __RESERVED       = 0x00;
        private const byte __PROTO          = 0xA0;
        private const byte __VM             = 0xB0;
        private const byte __CG             = 0xC0;
        private const byte __DATA           = 0xD0;
        private const byte __USER           = 0xF0;
        
        public const byte _NOP              = __RESERVED+0x00; //must be zero
        public const byte _END              = __RESERVED+0x0D;
        public const byte _CMP              = __RESERVED+0x03;
        
        public const byte PROTO_CONNECT     = __PROTO+0x0A;
        public const byte PROTO_ECHO        = __PROTO+0x0B;
        public const byte PROTO_MODE        = __PROTO+0x0C;
        public const byte PROTO_SYNC        = __PROTO+0x0E;
        
        public const byte VM_STREAM         = __VM+0x01;
        public const byte VM_PAUSE          = __VM+0x02;
        public const byte VM_RESTART        = __VM+0x03;
        public const byte VM_TERMINATE      = __VM+0x04;
        public const byte VM_MEM_READ       = __VM+0x05;
        public const byte VM_MEM_WRITE      = __VM+0x06;
        
        public const byte MEMREAD           = __USER+0x01;
        public const byte MEMWRITE          = __USER+0x02;
        public const byte USER_3            = __USER+0x03;
        
        public const byte CG_FONT           = __CG+0x01;
        public const byte CG_BITBLT         = __CG+0x02;
        public const byte CG_CLEAR          = __CG+0x03;
        public const byte CG_LINE           = __CG+0x04;
        public const byte CG_RECT           = __CG+0x05;
        public const byte CG_INIT           = __CG+0x0A;
        public const byte CG_INFO           = __CG+0x0B;
        
        public const byte DATA_OK           = __DATA+0x01;
        public const byte DATA_LOG          = __DATA+0x02;
        public const byte DATA_ERROR        = __DATA+0x03;
        public const byte DATA_LED          = __DATA+0x04;
        public const byte DATA_LIGHT        = __DATA+0x05;
        public const byte DATA_BUTTON       = __DATA+0x06;
        
        /// 
        /// Убираем пробелы переводим все в верхний регистр
        /// Заменяем строку с опкодом на значение константы
        /// 
        static byte[ ] _dummy = { };
        static public byte[] _parse2frame(string _buff)
        {
            if(_buff == string.Empty)
            { 
                l420.micro.print("WARNING - EMPTY_STREAM");
                return _dummy;
            }

            _buff = Regex.Replace( _buff, @"[ \t\n\r]+", "-" );

            var  _array      = _buff.ToUpper().Split( '-' );
            var  _buffer     = new byte [256];
            var  _buffer_cnt = 0;

            byte _opcodeLast = _NOP;
            byte _opcodeLastI = 0;
            foreach(var key in _array)
            {
                var T = intercom._opcodeBy( key );
                
                // ОПКОД
                if(T != null)
                {
                    // TODO: времняка
                    // OPCODE+SIZE считаем размер данных
                    if(_opcodeLast != _NOP)
                    {
                        _buffer [_opcodeLastI - 1] = (byte)(_buffer_cnt - _opcodeLastI);
                    }
                    
                    _buffer [_buffer_cnt++] = Convert.ToByte( T );  // opcode
                    _buffer [_buffer_cnt++] = 0x00;  // size

                    _opcodeLast = Convert.ToByte( T );
                    _opcodeLastI = (byte)_buffer_cnt;
                }
                // ДАННЫЕ
                else if(key != string.Empty) //value
                {
                    char        _token   = key [0];
                    string      _tmp     = string.Empty;
                    byte [ ]    _value   = { };
                    
                    switch(_token)
                    {
                        case '@':
                            _tmp   = key.Substring( 1, key.Length - 1 );
                            _value = Utils.StringToByteArray( _tmp );
                            //_buffer_cnt++;
                        break;

                        case 'X':
                        case 'Y':
                        case 'Z':
                            _tmp    = key.Substring( 1, key.Length - 1 );
                            _value  = BitConverter.GetBytes( Convert.ToSingle( _tmp ) );
                            _buffer[_buffer_cnt++] = (byte)_token;
                        break;
                        
                        case 'R':
                        case 'G':
                        case 'B':
                            _tmp    = key.Substring( 1, key.Length - 1 );
                            _value  = BitConverter.GetBytes( Convert.ToByte( _tmp ) );
                            _buffer[_buffer_cnt++] = (byte)_token;
                        break;

                        default: //default byte $

                            _value = new byte [ ] 
                            {
                                Byte.Parse( key )
                            };

                        break;
                    }
                    
                    // Копируем в промежуточный буфер
                    Array.Copy( _value, 0,_buffer, _buffer_cnt, _value.Length);
                    _buffer_cnt+=_value.Length;
                }// if(...
            }//foreach(...

            // TODO: времняка
            // OPCODE+SIZE считаем размер данных
            if(_opcodeLast != _NOP)
            {
                _buffer [_opcodeLastI-1 ] = (byte)(_buffer_cnt - _opcodeLastI);
            }

            byte [ ] _result = new byte [_buffer_cnt];
            Array.Copy( _buffer, _result, _buffer_cnt );

            return _result;
        }
        
        /// 
        /// Используем Рефлексию для вытаскивания констант с опкодами
        /// 
        static public object _opcodeBy(string name)
        {
            Type type = typeof(intercom); 
            
            ArrayList constants = new ArrayList();
            
            FieldInfo[] fieldInfos = type.GetFields
            (
                BindingFlags.Public | 
                BindingFlags.Static | 
                BindingFlags.FlattenHierarchy
            );
            
            foreach(FieldInfo fi in fieldInfos)
            {
                if(fi.IsLiteral && !fi.IsInitOnly && fi.Name == name)
                {
                    return fi.GetValue(type);
                }
            }
            
            return null;
        }
        
    }
}
