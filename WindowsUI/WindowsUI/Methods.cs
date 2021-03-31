using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public class Methods
    {
        public static GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            gp.CloseFigure();

            return gp;
        }

        public static void DrawBlurredLine(Graphics graph, Color lineColor, Point p1, Point p2, int maxAlpha, int penWidth)
        {
            float stepAlpha = (float)maxAlpha / penWidth;

            float actualAlpha = stepAlpha;
            for (int pWidth = penWidth; pWidth > 0; pWidth--)
            {
                Color BlurredColor = Color.FromArgb((int)actualAlpha, lineColor);
                Pen BlurredPen = new Pen(BlurredColor, pWidth);
                BlurredPen.StartCap = LineCap.Round;
                BlurredPen.EndCap = LineCap.Round;

                graph.DrawLine(BlurredPen, p1, p2);

                actualAlpha += stepAlpha;
            }
        }

        public static void DrawBlurredRectangle(Graphics graph, Color lineColor, Rectangle rect, int maxAlpha, int penWidth)
        {
            float stepAlpha = (float)maxAlpha / penWidth;

            float actualAlpha = stepAlpha;
            for (int pWidth = penWidth; pWidth > 0; pWidth--)
            {
                Color BlurredColor = Color.FromArgb((int)actualAlpha, lineColor);
                Pen BlurredPen = new Pen(BlurredColor, pWidth);
                BlurredPen.StartCap = LineCap.Round;
                BlurredPen.EndCap = LineCap.Round;

                graph.DrawRectangle(BlurredPen, rect);

                actualAlpha += stepAlpha;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        public static Image ByteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        public static void CopyEvent(Control form, Control src, string fieldName, string eventName, Control dest)
        {
            EventHandlerList events = (EventHandlerList)typeof(Control)
                                       .GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance)
                                       .GetValue(src, null);
            object key = typeof(Control).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Static).GetValue(null);
            EventInfo evInfo = typeof(Control).GetEvent(eventName, BindingFlags.Public | BindingFlags.Instance);
            Delegate del = events[key];
            if (del != null)
            {
                Delegate d = Delegate.CreateDelegate(evInfo.EventHandlerType, form, del.Method);
                MethodInfo addHandler = evInfo.GetAddMethod();
                Object[] addHandlerArgs = { d };
                addHandler.Invoke(dest, addHandlerArgs);
            }
        }

        public static Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;
            //Convert Base64 string to byte[]
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmpReturn;
        }
    }
}
