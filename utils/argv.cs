/**
  ******************************************************************************
  * @date    Jun-2017
  * @version V0.0.0
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************
*/
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace l420
{
    sealed public class argv
    {
        static string[] _safe_argv = null;

        const string ERROR_0x01_ARGS_NULL       = "ERROR_0x01_ARGS_NULL";
        const string ERROR_0x02_ARGS_INVALID    = "ERROR_0x02_ARGS_INVALID";

        const string NOTICE_USE_DEFAULT_VALUE   = "NOTICE_USE_DEFAULT_ARG";
        const string NOTICE_KEY_NOT_FOUND       = "NOTICE_ARG_KEY_NOT_FOUND";
        

        static public string [ ] safe_arv
        {
            get
            {
                if(_safe_argv == null) get_raw( "foo" ); // hack - force init
                return _safe_argv;
            }
        }

        static public int count
        {
            get { return argv.safe_arv.Length-1; } 
        }
        ////
        /// 
        //
        static public bool int2bool(int value)
        {
            return (value > 0) ? true : false;
        }


        // гарантировано возвращает строку
        // 
        //   
        //new [ ] { "--port", "com3", "--hex", "USER_1-@40013800-32", "--debug" };
        static public string get_raw( string key)
        {
            string result = string.Empty;
            
            // pass to filter
            if(argv._safe_argv == null)
            {
                string [ ] _raw      = Environment.GetCommandLineArgs();
                string _args_v1_raw  = string.Join( " ", _raw );
                string _args_v2_safe = _args_v1_raw.Replace( '=', ' ' ); // конфиг от J475
                _safe_argv          = _args_v2_safe.Split( ' ' );       // разбиваем обратно на элементы
            }
            
            if (_safe_argv.Contains(key) == true)
            {
                var buff  = argv._safe_argv.ToList();
                var index = buff.IndexOf(key) + 1;
                
                // валидация выхода за границу массива аргументов
                // последний ключ без значения
                result = (index >= argv._safe_argv.Length) ? string.Empty : argv._safe_argv [index];
            }
            else
            {
                //micro.print(WARNING_0x04_KEY_NOT_FOUND + " " + key);
            }
            
            return result;
        }
        ////
        ///
        //
        static public string get_str(string key, string _bydefault="")
        {
            string T    = _bydefault;
            string raw  = get_raw( key );
            
            if (raw.Length > 0)
            {
                T = raw;
            }
            else
            {
                //micro.print(NOTICE_USE_DEFAULT_VALUE + " " + key + " " + _default);
            }
            
            return T;
        }
        ////
        ///
        //
        static public int get_num( string key, int _bydefault)
        {
            int T = _bydefault;
        
            var raw = get_raw( key );
        
            bool isValid = Regex.IsMatch( raw, @"^\d+$" ); // This will return true if input is all numbers
        
            if(isValid == false)
            {
                //micro.print( NOTICE_USE_DEFAULT_VALUE+ " "+ key +" " + _default );
                T = _bydefault;
            }
            else
            {
                T = int.Parse( raw );
            }
            
            return T;
        }
        ////
        ///
        //
        static public bool get_bool( string key, int _bydefault)
        {
            int T = get_num( key, _bydefault);
            return int2bool(T);
        }
        ///
        /// Проверка наличия параметра
        ///
        static public bool check_key( string key )
        {
            var T = Array.FindAll(argv.safe_arv, s => s.Equals(key));

            return (T.Length > 0) ? true: false;
        }
    }
}
