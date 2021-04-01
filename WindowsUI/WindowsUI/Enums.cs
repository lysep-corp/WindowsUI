using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsUI
{
    public class Enums
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        public enum WindowCompositionAttribute
        {
            WCA_UNDEFINED = 0,
            WCA_NCRENDERING_ENABLED = 1,
            WCA_NCRENDERING_POLICY = 2,
            WCA_TRANSITIONS_FORCEDISABLED = 3,
            WCA_ALLOW_NCPAINT = 4,
            WCA_CAPTION_BUTTON_BOUNDS = 5,
            WCA_NONCLIENT_RTL_LAYOUT = 6,
            WCA_FORCE_ICONIC_REPRESENTATION = 7,
            WCA_EXTENDED_FRAME_BOUNDS = 8,
            WCA_HAS_ICONIC_BITMAP = 9,
            WCA_THEME_ATTRIBUTES = 10,
            WCA_NCRENDERING_EXILED = 11,
            WCA_NCADORNMENTINFO = 12,
            WCA_EXCLUDED_FROM_LIVEPREVIEW = 13,
            WCA_VIDEO_OVERLAY_ACTIVE = 14,
            WCA_FORCE_ACTIVEWINDOW_APPEARANCE = 15,
            WCA_DISALLOW_PEEK = 16,
            WCA_CLOAK = 17,
            WCA_CLOAKED = 18,
            WCA_ACCENT_POLICY = 19,
            WCA_FREEZE_REPRESENTATION = 20,
            WCA_EVER_UNCLOAKED = 21,
            WCA_VISUAL_OWNER = 22,
            WCA_HOLOGRAPHIC = 23,
            WCA_EXCLUDED_FROM_DDA = 24,
            WCA_PASSIVEUPDATEMODE = 25,
            WCA_LAST = 26
        }

        public enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_ENABLE_ACRYLICBLURBEHIND = 4, // RS4 1803
            ACCENT_ENABLE_HOSTBACKDROP = 5, // RS5 1809
            ACCENT_INVALID_STATE = 6
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        /*------------------------------------------------------------------------*/

        public enum SizeMode
        {
            Normal,
            Big,
        }

        public enum TextAnchor
        {
            Left,
            Center
        }

        public enum AdvancedTextAnchor
        {
            LeftTop,
            RightTop,
            LeftBottom,
            RightBottom,
            Center,
            CenterTop,
            CenterBottom
        }

        public enum ButtonImageAnchor
        {
            Left,
            CenterLeft,
            Center,
            CenterRight,
            Right
        }

        public enum CenterStyle
        {
            Normal,
            AboveImage,
            BelowImage
        }

        public enum SelectedStyle
        {
            Left,
            Fill
        }
    }
}
