using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI.Controls
{
    public class WinCircularPicturebox : PictureBox
    {
        public WinCircularPicturebox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new System.Drawing.Size(this.Width, this.Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
            this.Region = new System.Drawing.Region(path);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pe.Graphics.DrawEllipse(new System.Drawing.Pen(this.BackColor), 0, 0, this.Width - 1, this.Height - 1);
            pe.Dispose();
        }
    }
}
