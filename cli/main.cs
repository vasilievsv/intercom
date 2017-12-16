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
        micro.begin( ConsoleColor.White );
        if( argv.get_touch(KEY_BANNER)  || argv.count == 0) micro.print_banner();
        if( argv.get_touch(KEY_HELP)    || argv.count == 0) micro.print( _help );
        micro.end();
        
   
        if(argv.get_touch( KEY_PORT_LIST ))
        {
            micro.print( l420.intercom.usart_EnumPort() );
        }
        
        if(argv.get_touch( KEY_PORT ))
        {
            l420.intercom.use_debug         = argv.get_touch( KEY_DEBUG );

            l420.intercom.eventPinChangned  += delegate(){micro.print("IRQ_PinChanged");};
            l420.intercom.eventIRQError     += delegate(){micro.print("IRQ_Error");};
            l420.intercom.eventPortNotFound += delegate(){micro.print("PortNotFound");};
            l420.intercom.eventConnect      += delegate(){};
            l420.intercom.eventDataIncoming += delegate(){};

            l420.intercom.usart_Open( argv.get_str( KEY_PORT, "auto" ) );
        }
        
        if(argv.get_touch(KEY_GUI))
        { 
            switch(argv.get_num(KEY_GUI,0))
            {
                case 0:break;
                case 1: Application.Run(new app.winform_NRF());    break;
                case 2: Application.Run(new app.winform_SPI());    break;
                case 3: Application.Run(new app.winform_USART());  break;
            }
        }
        else if(argv.get_touch( KEY_LOOP ))
        {
            while(true)
            {
                Thread.Sleep( argv.get_num( KEY_LOOP, 150 ) );
                l420.intercom.usart_TX = l420.intercom._parse( argv.get_str( KEY_HEX ) );
            }
        }
        else
        {
            l420.intercom.usart_TX = l420.intercom._parse( argv.get_str( KEY_HEX ) );
        }
        
        Thread.Sleep( 250 );
        
        if(argv.get_touch( KEY_DEBUG ))
        {
            l420.intercom.usart_DumpLast(ref l420.intercom.usart_RX);
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
