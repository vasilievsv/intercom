/**
  ******************************************************************************
  * @date   : 30/05/2023 
  * @version: 
  * @author : Vasiliev Sergey
  * @brief  : Работа с WinAPI
  ******************************************************************************
  
    https://social.msdn.microsoft.com/Forums/vstudio/en-US/45a89532-b01c-4ef8-aa46-532882cec004/serialport-class-and-rtscontroltoggle?forum=csharpgeneral
    https://referencesource.microsoft.com/#system/compmod/microsoft/win32/NativeMethods.cs,ceeda2a57dec1eba,references

*/
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

using System.IO.Ports;
using System.Runtime.Versioning;

namespace utils
{
    public static class win32_serial
    {
        [DllImport("kernel32.dll", SetLastError = true)] private static extern bool SetCommState(SafeFileHandle hFile, IntPtr lpDCB);

        [DllImport("kernel32.dll", SetLastError = true)] 
        [ResourceExposure(ResourceScope.None)]    internal static extern bool EscapeCommFunction( SafeFileHandle hFile, int dwFunc);

        public const int SETRTS = 3;       // Set RTS high
        public const int CLRRTS = 4;       // Set RTS low
        public const int SETDTR = 5;       // Set DTR high
        public const int CLRDTR = 6;

        static public void SetRtsControlToggle(SerialPort port)
        {
            SetCommFlag(port, SETRTS);
        }

        static public void ClearRtsControlToggle(SerialPort port)
        {
            SetCommFlag(port, CLRRTS);
        }

        static public void SetCommFlag(SerialPort port, int value)
        {
            // Get the base stream and its type
            object baseStream = port.BaseStream;
            Type baseStreamType = baseStream.GetType();

            try
            {
                // Get the Win32 file handle for the port
                SafeFileHandle _handle = (SafeFileHandle)baseStreamType.GetField("_handle", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(baseStream);

                EscapeCommFunction(_handle, value);
            }
            catch
            {
                throw;
            }
        }
    }
}
