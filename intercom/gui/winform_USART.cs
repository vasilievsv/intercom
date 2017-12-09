using System.Windows.Forms;

using l420;

namespace intercom
{
    public partial class winform_USART :Form
    {
        public winform_USART()
        {
            InitializeComponent();

            l420.intercom.usart_TX =  l420.intercom._parse2frame( "MEMREAD-@40013800-4");
            
        }
    }
}
