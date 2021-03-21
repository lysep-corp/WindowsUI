using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsUI.Design;

namespace WindowsUI
{
    public class WinPanel : Panel
    {
        public WinPanel()
        {
            this.Font = new Font("Segoe UI", 11f);
            this.ForeColor = Color.White;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        [Category("Windows UI")]
        [DisplayName("Title")]
        public string Title { get; set; } = "Title";

        [Category("Windows UI")]
        [DisplayName("Border Radius")]
        public int BorderRadius { get; set; } = 50;

        [Category("Windows UI")]
        [DisplayName("Separator Width")]
        public int SeperatorWidth { get; set; } = 1;

        [Category("Windows UI")]
        [DisplayName("Normal Color")]
        public Color Normal { get; set; } = Color.FromArgb(31, 31, 31);

        [Category("Windows UI")]
        [DisplayName("Opacity")]
        public int Opacity { get; set; } = 128;

        [Category("Windows UI")]
        [DisplayName("Border Color")]
        public bool ShowBorder { get; set; } = false;

        [Category("Windows UI")]
        [DisplayName("Border Size")]
        public int BorderSize { get; set; } = 2;

        [Category("Windows UI")]
        [DisplayName("Border Color")]
        public Color BorderColor { get; set; } = Color.FromArgb(21, 21, 21);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            RectangleF Rect = new RectangleF(0, 0, this.Width - 1, this.Height - 1);
            GraphicsPath GraphPath = Methods.GetRoundPath(Rect, BorderRadius);
            //this.Region = new Region(GraphPath);

            SolidBrush brushes = new SolidBrush(Color.FromArgb(Opacity, Normal));
            e.Graphics.FillPath(brushes, GraphPath);
            if (ShowBorder) { e.Graphics.DrawPath(new Pen(Color.FromArgb(Opacity, BorderColor), BorderSize), Methods.GetRoundPath(Rect, BorderRadius)); }

            TextFormatFlags flags = TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, Title, Font, new Point(Width / 2 - (TextRenderer.MeasureText(Title, Font).Width / 2), TextRenderer.MeasureText(Title, Font).Height / 2 + 2), ForeColor, flags);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, Color.DarkGray)), new RectangleF(5, TextRenderer.MeasureText(Title, Font).Height + 2, ClientRectangle.Width - 11, SeperatorWidth));
        }
    }
}
