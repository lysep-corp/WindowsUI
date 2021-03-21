using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsUI
{
    class Methods
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
    }
}
