/**
  ******************************************************************************
   *@date    
  * @version 
  * @author  Vasiliev Sergey
  * @brief   Работа с WinAPI
  ******************************************************************************
  
  https://superuser.com/questions/1173947/disable-all-uac-limitations-permanently
  secpol.msc

  https://winaero.com/blog/how-to-turn-off-and-disable-uac-in-windows-10/
*/
using System;
using System.Runtime.InteropServices;

namespace utils
{
    public static class win32
    {
        public delegate bool HandlerRoutine(CtrlTypes CtrlType);
        [DllImport( "user32.dll" )] static public extern int    ShowWindow      (IntPtr hwnd, int nCmdShow);
        [DllImport( "user32.dll" )] static public extern IntPtr FindWindowEx    (IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
        [DllImport( "User32.dll" )] static public extern IntPtr FindWindow      (string lpClassName, string lpWindowName);
        [DllImport( "user32.dll" )] static public extern IntPtr SendMessage     (IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        [DllImport( "user32.dll" )] static public extern IntPtr DestroyWindow   (IntPtr hWnd);
        [DllImport( "user32.dll" )] static public extern IntPtr SetActiveWindow (IntPtr hWnd);
        [DllImport( "user32.dll" )] static public extern bool   PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport( "user32.dll" )] static public extern void   mouse_event(uint dwFlags, int dx, int dy, uint dwData,UIntPtr dwExtraInfo);

        [DllImport("kernel32.dll")] static public extern IntPtr GetConsoleWindow();
        [DllImport("Kernel32.dll")] static public extern bool SetConsoleCtrlHandler(HandlerRoutine handler, bool add);

        public enum CtrlTypes
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }
        public const int BM_CLICK          = 0x00F5;
        public const int BM_GETSTATE       = 0x00F2;

        public const int SW_HIDE 			= 0;
        public const int SW_SHOW 			= 5;
        public const int SW_SHOWNORMAL     	= 1;
        public const int SW_SHOWMINIMIZED  	= 2;
        public const int SW_MINIMIZE        = 6;
    }
}
