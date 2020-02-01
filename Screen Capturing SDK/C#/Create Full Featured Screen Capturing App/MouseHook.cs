//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.ComponentModel;
using System.Windows.Forms;

namespace ScreenCapturing
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator System.Drawing.Point(POINT p)
        {
            return new System.Drawing.Point(p.X, p.Y);
        }

        public static implicit operator POINT(System.Drawing.Point p)
        {
            return new POINT(p.X, p.Y);
        }
    }

    public class MouseHook
    {
        private delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        private static HookProc MouseHookProcedure;
        public event MouseEventHandler MouseActivity;
        private int hMouseHook = 0;

        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_RBUTTONDOWN = 0x204;
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_LBUTTONDBLCLK = 0x203;
        private const int WM_RBUTTONDBLCLK = 0x206;

        private const int WH_MOUSE = 7;
        private const int WH_MOUSE_LL = 14;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int UnhookWindowsHookEx(int idHook);

        [StructLayout(LayoutKind.Sequential)]
        private class MouseLLHookStruct
        {
            public POINT pt;
            public int mouseData;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private class MouseHookStruct
        {
            public POINT pt;
            public int  hwnd;
            public int wHitTestCode;
            public int dwExtraInfo;
        }

        public void SetHook()
        {
            MouseHookProcedure = new HookProc(MouseHookProc);
        	IntPtr modulehandle = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);

            hMouseHook = SetWindowsHookEx(WH_MOUSE, MouseHookProcedure, modulehandle, 0);

            if (hMouseHook == 0)
            {
                int errorCode = Marshal.GetLastWin32Error();

                ReleaseHook(false);

                throw new Win32Exception(errorCode);
            }
        }

        public void ReleaseHook(bool throwExceptions)
        {
            if (hMouseHook != 0)
            {
                int retMouse = UnhookWindowsHookEx(hMouseHook);
                
                hMouseHook = 0;
                
                if (retMouse == 0 && throwExceptions)
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
            }
        }

        private int MouseHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if ((nCode >= 0) && (MouseActivity != null))
            {
                MouseLLHookStruct mouseHookStruct = 
                    (MouseLLHookStruct) Marshal.PtrToStructure(lParam, typeof(MouseLLHookStruct));

                MouseButtons button = MouseButtons.None;
                short mouseDelta = 0;
                
                switch (wParam)
                {
                    case WM_LBUTTONDOWN:
                        button = MouseButtons.Left;
                        break;
                    case WM_RBUTTONDOWN:
                        button = MouseButtons.Right;
                        break;
                    case WM_MOUSEWHEEL:
                        mouseDelta = (short) ((mouseHookStruct.mouseData >> 16) & 0xffff);
                        break;
                }

                int clickCount = 0;
                
                if (button != MouseButtons.None)
                    if (wParam == WM_LBUTTONDBLCLK || wParam == WM_RBUTTONDBLCLK) clickCount = 2;
                    else clickCount = 1;

                MouseEventArgs e = new MouseEventArgs(button, clickCount, mouseHookStruct.pt.X, 
                    mouseHookStruct.pt.Y, mouseDelta);
                
                MouseActivity(this, e);
            }
            
            return CallNextHookEx(hMouseHook, nCode, wParam, lParam);
        }
    }
}
