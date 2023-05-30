/**
  ******************************************************************************
  * @date    3-Sep-2017
  * @version V1.0.3
  * @author  Vasiliev Sergey
  * @brief   Консольный Терминал - ЗАПРОС/ОТВЕТ
  ******************************************************************************
*/
using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

using utils;
using micro.sdk;

public partial class main
{
    public const string KEY_BANNER     = "-b";
    public const string KEY_HELP       = "-?";
    public const string KEY_PORT       = "--port";         // ttyUSB0:115200:8N1:42:42
    public const string KEY_PORT_LIST  = "--port-list";
    public const string KEY_DEBUG      = "--debug";
    public const string KEY_GUI        = "--gui";          // консоль + окно
    public const string KEY_TCP        = "--tcp";          
    public const string KEY_FILE       = "--file";
    public const string KEY_HEX        = "--hex";
    public const string KEY_LOOP       = "--loop";
    public const string KEY_LINE_REPEAT= "--line-send-repeat";
    
    
    [STAThread]
    static void Main()
    {
        log.begin( ConsoleColor.White );
        if( argv.check_key(KEY_BANNER)  || argv.count == 0) log.print_random_banner();
        if( argv.check_key(KEY_HELP)    || argv.count == 0) log.print( _help );
        log.end();
        

        if (argv.check_key( KEY_PORT_LIST ))
            log.print( intercom.usart_EnumPort() );
        
        if(argv.check_key( KEY_PORT ))
            intercom.init_serial();
        
        if (argv.check_key(KEY_TCP))
            intercom.init_socket( argv.get_str(main.KEY_TCP, _bydefault: "localhost") );



        if (argv.check_key(KEY_GUI))
        {
            switch (argv.get_num(KEY_GUI, _bydefault: 0))
            {
                case 1: break;
                case 2: Application.Run(new app.winform_ESP32_AutoProgram()); break;
            }
        }
        else if (argv.check_key(KEY_FILE))
        {
            var values = file.ReadLineToList(argv.get_str(KEY_FILE));
            foreach (var v in values)
            {
                var count = argv.get_num(KEY_LINE_REPEAT, _bydefault: 1);
                
                for (int i = 0; i != count; i++)
                {
                    if (argv.check_key(KEY_PORT))
                        intercom.usart_TX = intercom._parse(v);

                    else if (argv.check_key(KEY_TCP))
                        intercom.socket_TX = intercom._parse(v);

                    log.print(v);
                    Thread.Sleep(argv.get_num(KEY_LOOP, _bydefault: 150));
                }
                
            }
        }
        else if(argv.check_key( KEY_LOOP ))
        {
            while(true)
            {
                Thread.Sleep( argv.get_num(KEY_LOOP, _bydefault:150) );

                if (argv.check_key(KEY_PORT))
                    intercom.usart_TX = intercom._parse( argv.get_str(KEY_HEX) );

                else if (argv.check_key(KEY_TCP))
                    intercom.socket_TX = intercom._parse(argv.get_str(KEY_HEX));

            }
        }
        else
        {
            if (argv.check_key(KEY_TCP))
            {
                intercom.socket_TX = intercom._parse(argv.get_str(KEY_HEX));
            }

            if ( argv.check_key(KEY_PORT) )
            {
                //intercom._serial = intercom._parse(argv.get_str(KEY_HEX));
            }
        }
        
        Thread.Sleep( 150 );
        
        if(argv.check_key( KEY_DEBUG ))
        {
            intercom.usart_DumpLast(ref intercom.usart_RX);
        }
        
    }


 const string _help =
@"
   -? show this message
   -b show banner
   --debug
   --gui  |*0|1|2|3|
   --port-list
   --port com[1..9] | *auto | COM5:115200:8N1
   --hex  00-00-00-00-00
   --file barz.txt
   --loop 150

    usage: 
        $ intercom --port com3 --hex MEMREAD-@40013800-22 --debug --loop 500 -?
        $ intercom --tcp  10.10.0.1 --hex FF-FF-FF-FF --debug --loop 500 -?
        $ intercom --port 127.0.0.1:3131 --file bar.txt --line-send-repeat 10
";
}//class end