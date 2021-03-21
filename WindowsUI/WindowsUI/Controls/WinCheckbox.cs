using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI.Controls
{
    [DefaultEvent("CheckedChanged")]
    public class WinCheckbox : UserControl
    {
        public WinCheckbox()
        {
            this.Size = new Size(24, 24);
            this.Font = new Font("Segoe UI Semibold", 11f);
            this.ForeColor = Color.White;
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        public delegate void checkedChanged(object sender, EventArgs e);
        public event checkedChanged CheckedChanged;

        [Category("Windows UI")]
        [DisplayName("Border Color")]
        public Color BorderColor { get; set; } = Color.Gray;

        [Category("Windows UI")]
        [DisplayName("Background Color")]
        public Color BackgroundColor { get; set; } = Color.FromArgb(31, 31, 31);

        [Category("Windows UI")]
        [DisplayName("Checked")]
        public bool Checked { get; set; } = false;

        private Enums.SizeMode sizeMode = Enums.SizeMode.Normal;
        [Category("Windows UI")]
        [DisplayName("Size Mode")]
        public Enums.SizeMode SizeMode
        {
            get
            {
                return sizeMode;
            }
            set
            {
                sizeMode = value;
                if (sizeMode == Enums.SizeMode.Normal)
                {
                    this.Size = new Size(16, 16);
                }
                else if (sizeMode == Enums.SizeMode.Big)
                {
                    this.Size = new Size(24, 24);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, BackgroundColor)), this.ClientRectangle);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(128, BorderColor), 2f), new Rectangle(0, 0, Width, Height));
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            if(Checked)
            {
                TextRenderer.DrawText(e.Graphics, "", Font, new Point(Width + 2, Height / 2), Color.FromArgb(128, ForeColor), flags);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(SizeMode  == Enums.SizeMode.Normal)
            {
                this.Size = new Size(16, 16);
            }
            else if (SizeMode == Enums.SizeMode.Big)
            {
                this.Size = new Size(24, 24);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Checked = !Checked;
            this.Invalidate();
            if(CheckedChanged != null)
            {
                CheckedChanged(this, e);
            }
        }
    }
}
