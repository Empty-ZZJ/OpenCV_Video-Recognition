using System;
using System.Runtime.InteropServices;

namespace VideoSystem.DllImport_Pro
{
    public class DllImport_Pro
    {


        [DllImport("User32.dll", EntryPoint = "FindWindow")]//寻找窗口句柄
        public static extern IntPtr FindWindow (string lpClassName, string lpWindowName);
        [DllImport("./dll/win-core-shadow.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void windows_shadow (int a, int b, int c);//设置窗口阴影
        [DllImport("UxTheme.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void SetWindowTheme (int hwnd, char[] pszSubAppName, int pszSubIdList);//设置窗口主题
        [DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int SendMessageA (int hWnd, int Msg, int wParam, int lParam);//发送消息，主要开启双缓存，要不然列表会卡
        [DllImport("User32.dll", EntryPoint = "GetInputState")]
        public static extern int GetInputState ();
        [DllImport("./dll/win-core-message.dll", EntryPoint = "PeekMessage")]
        public static extern int PeekMessage ();

    }
}
