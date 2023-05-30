/**
  ******************************************************************************
   *@date    Nov-2017
  * @version V0.0.2
  * @author  Michael Kargapoltsev , Vasiliev Sergey
  * @brief   
  ******************************************************************************
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace micro.sdk
{
    class crc_stm32
    {
        public const UInt32 POLY_NUM = 0x04C11DB7; // Polynomial used in STM32

        static public UInt32 fromWord(UInt32 crc, UInt32 data)
        {
            int i;
 
            crc = crc ^ data;
 
            for (i = 0; i < 32; i++)
            {
                if ((crc & 0x80000000) != 0)
                {
                    crc = (crc << 1) ^ POLY_NUM; 
                }
                else
                {
                    crc = (crc << 1);
                }
            }

            return(crc);
        }
 
        static public UInt32 fromArray(UInt32 init_value, UInt32[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                init_value = fromWord(init_value, buffer[i]);
            }
 
            return init_value;
        }
    }
}
