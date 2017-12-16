using System;
using System.Threading;
using System.Windows.Forms;
using l420;

namespace app
{
    public partial class winform_USART :Form
    {
        public const string ADDR_SR  = "40013800";
        public const string ADDR_DR  = "40013804";
        public const string ADDR_BRR = "40013808";
        public const string ADDR_CR1 = "4001380C";
        public const string ADDR_CR2 = "40013810";
        public const string ADDR_CR3 = "40013814";
        public const string ADDR_GTPR= "40013818";
        
        public winform_USART()
        {
            InitializeComponent();
            
            intercom.eventDataEncoded += IRQ_PackEncoded;
            

            intercom.usart_TX = intercom._parse( "MEMREAD-@"+ADDR_SR    +"-4");Thread.Sleep( 50 );
            intercom.usart_TX = intercom._parse( "MEMREAD-@"+ADDR_DR    +"-4");Thread.Sleep( 50 );
            intercom.usart_TX = intercom._parse( "MEMREAD-@"+ADDR_BRR   +"-4");Thread.Sleep( 50 );
            intercom.usart_TX = intercom._parse( "MEMREAD-@"+ADDR_CR1   +"-4");Thread.Sleep( 50 );
            intercom.usart_TX = intercom._parse( "MEMREAD-@"+ADDR_CR2   +"-4");Thread.Sleep( 50 );
            intercom.usart_TX = intercom._parse( "MEMREAD-@"+ADDR_CR3   +"-4");Thread.Sleep( 50 );
            intercom.usart_TX = intercom._parse( "MEMREAD-@"+ADDR_GTPR  +"-4");Thread.Sleep( 50 );
        }
        
        public void IRQ_PackEncoded(byte opcode, byte[] data)
        {
            micro.print( BitConverter.ToString(data,0,data.Length) );

            var _iaddr = BitConverter.ToInt32( data, 0);
            var _idata = BitConverter.ToString( data, 4, data.Length - 4 );


            if(opcode == intercom.MEMREAD)
            {
                switch(_iaddr.ToString("X"))
                {
                    case ADDR_SR  : txt_SR.Text   = _idata; break;
                    case ADDR_DR  : txt_DR.Text   = _idata; break;
                    case ADDR_BRR : txt_BRR.Text  = _idata; break;
                    case ADDR_CR1 : txt_CR1.Text  = _idata; break;
                    case ADDR_CR2 : txt_CR2.Text  = _idata; break;
                    case ADDR_CR3 : txt_CR3.Text  = _idata; break;
                    case ADDR_GTPR: txt_GTPR.Text = _idata; break;
                }
            }// if(...
        }
        
    }
}
