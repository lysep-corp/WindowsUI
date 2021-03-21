using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsUI.Design
{
    class Shadow
    {
        public static void AddShadow(IntPtr HWnd)
        {
            WinAPI.SetClassLong(HWnd, Constants.GCL_STYLE, WinAPI.GetClassLong(HWnd, Constants.GCL_STYLE) | Constants.CS_DropSHADOW);
        }
    }
}
