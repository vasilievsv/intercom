/**
  ******************************************************************************
  * @date    3-Sep-2017
  * @version V1.0.3
  * @author  Vasiliev Sergey
  * @brief   Консольный Терминал - ЗАПРОС/ОТВЕТ
  ******************************************************************************
*/
using System;
using System.Threading;
using System.Windows.Forms;
using l420;

using micro.sdk;

public partial class main
{
    const string KEY_BANNER     = "-b";
    const string KEY_HELP       = "-?";
    const string KEY_PORT       = "--port";
    const string KEY_PORT_LIST  = "--port-list";
    const string KEY_DEBUG      = "--debug";
    const string KEY_LOOP       = "--loop";
    const string KEY_HEX        = "--hex";
    const string KEY_FILE       = "--file";
    const string KEY_GUI        = "--gui";

    [STAThread]
    static void Main()
    {
        log.begin( ConsoleColor.White );
        if( argv.check_key(KEY_BANNER)  || argv.count == 0) log.print_banner();
        if( argv.check_key(KEY_HELP)    || argv.count == 0) log.print( _help );
        log.end();
        
   
        if(argv.check_key( KEY_PORT_LIST ))
        {
            log.print( intercom.usart_EnumPort() );
        }
        
        if(argv.check_key( KEY_PORT ))
        {
            intercom.use_debug         = argv.check_key( KEY_DEBUG );

            intercom.eventPinChangned  += delegate(){log.print("IRQ_PinChanged");};
            intercom.eventIRQError     += delegate(){log.print("IRQ_Error");};
            intercom.eventPortNotFound += delegate(){log.print("PortNotFound");};
            intercom.eventConnect      += delegate(){};
            intercom.eventDataIncoming += delegate(){};

            intercom.usart_Open( argv.get_str( KEY_PORT, _bydefault:"auto" ) );
        }
        
        if(argv.check_key(KEY_GUI))
        { 
            switch(argv.get_num(KEY_GUI, _bydefault:0))
            {
                case 1: Application.Run(new app.winform_NRF());    break;
                case 2: Application.Run(new app.winform_SPI());    break;
                case 3: Application.Run(new app.winform_USART());  break;
            }
        }
        else if(argv.check_key( KEY_LOOP ))
        {
            while(true)
            {
                Thread.Sleep( argv.get_num( KEY_LOOP, _bydefault:150 ) );
                intercom.usart_TX = intercom._parse( argv.get_str( KEY_HEX ) );
            }
        }
        else
        {
            intercom.usart_TX = intercom._parse( argv.get_str( KEY_HEX ) );
        }
        
        Thread.Sleep( 250 );
        
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
   --port com[1..9] | *auto
   --hex  00-00-00-00-00
   --file barz.txt
   --loop 150

    usage: 
   $intercom --port com3 --hex MEMREAD-@40013800-22 --debug --loop 500 -?
";
}//class end
