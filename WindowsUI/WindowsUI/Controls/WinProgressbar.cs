using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI.Controls
{
    public class WinProgressbar : ProgressBar
    {
        public WinProgressbar()
        {
            this.Font = new Font("Segoe UI Semibold", 11f);
            this.ForeColor = Color.White;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        [Category("Windows UI")]
        [DisplayName("Normal Color")]
        public Color Normal { get; set; } = Color.FromArgb(51, 51, 51);

        [Category("Windows UI")]
        [DisplayName("Border Color")]
        public Color Border { get; set; } = Color.FromArgb(21, 21, 21);

        [Category("Windows UI")]
        [DisplayName("Progress1 Color")]
        public Color Progress1 { get; set; } = Color.FromArgb(0, 99, 177);

        [Category("Windows UI")]
        [DisplayName("Progress2 Color")]
        public Color Progress2 { get; set; } = Color.FromArgb(0, 99, 177);

        [Category("Windows UI")]
        [DisplayName("Content")]
        public string Content { get; set; } = "";

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 2;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 2;
            e.Graphics.FillRectangle(new SolidBrush(Normal), this.ClientRectangle);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(200, Border)), 0, 0, Width - 1, Height - 1);
            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, Progress1, Progress2, 180);
            e.Graphics.FillRectangle(br/*new SolidBrush(Progress)*/, 1, 1, rec.Width, rec.Height);

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            TextRenderer.DrawText(e.Graphics, Content, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }
    }
}
