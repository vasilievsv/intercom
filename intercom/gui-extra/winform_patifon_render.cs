/**
  ******************************************************************************
  * @date    
  * @version V0.0.0
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************
    
    https://material.io/guidelines/motion/material-motion.html
    https://gist.github.com/cjddmut/d789b9eb78216998e95c
    
*/
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;

using micro.sdk;

using System.Text.RegularExpressions;

namespace app
{
    public partial class winform_patifon_render : Form
    {
        public winform_patifon_render()
        {
            InitializeComponent();
        }

        unsafe  private void IRQ_DataIncoming(object sender, SerialDataReceivedEventArgs e)
        {


        }

        public void IRQ_PackEncoded(byte opcode, byte[] data)
        {

        }

    }
}
