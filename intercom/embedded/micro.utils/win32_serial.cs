/**
  ******************************************************************************
  * @date   : 30/05/2023 
  * @version: 
  * @author : Vasiliev Sergey
  * @brief  : Работа с WinAPI
  ******************************************************************************
  
    https://social.msdn.microsoft.com/Forums/vstudio/en-US/45a89532-b01c-4ef8-aa46-532882cec004/serialport-class-and-rtscontroltoggle?forum=csharpgeneral

*/
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

using System.IO.Ports;

namespace utils
{
    public static class win32_serial
    {
        [DllImport("kernel32.dll", SetLastError = true)] private static extern bool SetCommState(SafeFileHandle hFile, IntPtr lpDCB);


        static public void SetRtsControlToggle(SerialPort port)
        {
            SetDcbFlag(port, 12, 3); // flag 12 is fRtsControl, value 3 is RTS_CONTROL_TOGGLE
        }

        static public void ClearRtsControlToggle(SerialPort port)
        {
            SetDcbFlag(port, 12, 0); // flag 12 is fRtsControl, value 0 is RTS_CONTROL_DISABLE
        }

        static public void SetDcbFlag(SerialPort port, int flag, int value)
        {

            // Get the base stream and its type
            object baseStream = port.BaseStream;
            Type baseStreamType = baseStream.GetType();

            try
            {
                // Get the Win32 file handle for the port
                SafeFileHandle _handle = (SafeFileHandle)baseStreamType.GetField("_handle", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(baseStream);

                // Box the private DCB field
                object dcb = baseStreamType.GetField("dcb", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(baseStream);

                // Create unmanaged memory to copy dcb field into
                IntPtr hGlobal = Marshal.AllocHGlobal(Marshal.SizeOf(dcb));
                try
                {
                    // Copy dcb field to unmanaged memory
                    Marshal.StructureToPtr(dcb, hGlobal, false);

                    // Call SetCommState
                    if (!SetCommState(_handle, hGlobal))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                finally
                {
                    // Free the unmanaged memory
                    Marshal.FreeHGlobal(hGlobal);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
