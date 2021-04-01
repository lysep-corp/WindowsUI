using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public class WinButton : Button
    {
        private Color normal = Color.FromArgb(51, 51, 51);
        [Category("Windows UI")]
        [DisplayName("Normal Color")]
        public Color Normal
        {
            get
            {
                return normal;
            }
            set
            {
                normal = value;
                this.Refresh();
            }
        }

        [Category("Windows UI")]
        [DisplayName("Press Color")]
        public Color Press { get; set; } = Color.FromArgb(31, 31, 31);

        [Category("Windows UI")]
        [DisplayName("Border Color")]
        public Color Border { get; set; } = Color.Gray;

        [Category("Windows UI")]
        [DisplayName("Border Size")]
        public float BorderSize { get; set; } = 1f;

        [Category("Windows UI")]
        [DisplayName("Image")]
        public Image Image { get; set; } = null;

        [Category("Windows UI")]
        [DisplayName("Image Anchor")]
        public Enums.ButtonImageAnchor ImageAnchor { get; set; } = Enums.ButtonImageAnchor.Left;

        [Category("Windows UI")]
        [DisplayName("Selected")]
        public bool Selected { get; set; } = false;

        [Category("Windows UI")]
        [DisplayName("Selected Color")]
        public Color SelectedColor { get; set; } = Color.FromArgb(0, 99, 177);

        [Category("Windows UI")]
        [DisplayName("Selected Border Size")]
        public int SelectedBorderSize { get; set; } = 2;

        [Category("Windows UI")]
        [DisplayName("Selected Style")]
        public Enums.SelectedStyle SelectedStyle { get; set; } = Enums.SelectedStyle.Left;

        private Color currentBackcolor;
        public WinButton()
        {
            this.Font = new Font("Segoe UI Semibold", 9f);
            this.ForeColor = Color.White;
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Refresh();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            currentBackcolor = Normal;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(currentBackcolor), this.ClientRectangle);
            e.Graphics.DrawRectangle(new Pen(Border, BorderSize), new Rectangle(0, 0, Width - 1, Height - 1));
            if(Image != null)
            {
                int cursorX = 0, cursorY = 0;
                switch(ImageAnchor)
                {
                    case Enums.ButtonImageAnchor.Left:
                        cursorX = 3;
                        cursorY = 3;
                        break;

                    case Enums.ButtonImageAnchor.Right:
                        cursorX = Width - (this.Height) + 2;
                        cursorY = 3;
                        break;

                    case Enums.ButtonImageAnchor.Center:
                        cursorX = Width / 2 - ((this.Height - 7) / 2);
                        cursorY = 3;
                        break;

                    case Enums.ButtonImageAnchor.CenterLeft:
                        cursorX = (Width / 2 - ((this.Height) / 2)) - (TextRenderer.MeasureText(Text, Font).Width  / 2) - 5;
                        cursorY = 3;
                        break;

                    case Enums.ButtonImageAnchor.CenterRight:
                        cursorX = (Width / 2 - ((this.Height) / 2)) + (TextRenderer.MeasureText(Text, Font).Width / 2) + 11;
                        cursorY = 3;
                        break;
                }
                e.Graphics.DrawImage(Methods.ResizeImage(Image, this.Height - 7, this.Height - 7), new PointF(cursorX, cursorY));
            }
            if(Selected) {
                if (SelectedStyle == Enums.SelectedStyle.Left) { e.Graphics.FillRectangle(new SolidBrush(SelectedColor), 1, 1, SelectedBorderSize, Height - 1); }
                else if (SelectedStyle == Enums.SelectedStyle.Fill) { e.Graphics.FillRectangle(new SolidBrush(SelectedColor), this.ClientRectangle); }
            }
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            TextRenderer.DrawText(e.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            currentBackcolor = Press;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            currentBackcolor = Normal;
            this.Invalidate();
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            currentBackcolor = Normal;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            currentBackcolor = Normal;
            this.Invalidate();
        }
    }
}
