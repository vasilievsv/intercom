/**
  ******************************************************************************
  * @date    Sep-2021
  * @version V0.0.3
  * @author  Vasiliev Sergey 
  * @brief   
  ******************************************************************************
 
  https://docs.microsoft.com/ru-ru/dotnet/framework/network-programming/asynchronous-client-socket-example

 */
using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using utils;

using System.Net;
using System.Net.Sockets;


namespace micro.sdk
{
    sealed public partial class intercom
    {
        public static void init_socket( string port_arg)
        {
            var port_arg_buff = port_arg.Split(':'); // localhost.loc:8070
            
            embedded.AsynchronousClient.StartClient(port_arg_buff[0], Convert.ToInt32( port_arg_buff[1] ));
        }

        ///
        ///
        ///
        static public object socket_TX
        {
            get { return _frameTX; }
            set
            {
                var _type = value.GetType();

                if (object.Equals(_type, typeof(string)) && (value as string).Length > 0)
                {
                    try
                    {
                        byte[] tmp = System.Text.Encoding.ASCII.GetBytes(value as string);

                        embedded.AsynchronousClient.Receive(embedded.AsynchronousClient.client);
                        embedded.AsynchronousClient.Send(tmp);

                        embedded.AsynchronousClient.receiveDone.WaitOne();

                        if (eventDataEncoded != null)
                            eventDataEncoded(null, embedded.AsynchronousClient.response);
                    }
                    catch
                    {
                        log.print("lost connect");
                    }
                }

                if (object.Equals( _type, typeof( byte [ ] ) ) && (value as byte [ ]).Length>0)
                {
                    var buff = (value as byte[]);

                    switch ("to_raw")
                    {
                        case "to_raw":
                        {
                            if (true)
                            {
                                embedded.AsynchronousClient.Send( buff );
                            }
                        }
                        break;
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

    }// class end
}
