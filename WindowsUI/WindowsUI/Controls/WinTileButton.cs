using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsUI.Enums;

namespace WindowsUI.Controls
{
    [DefaultEvent("OnTileButtonMouseClick")]
    public class WinTileButton : Control
    {
        public WinTileButton()
        {
            this.BackColor = Normal;
            this.Font = new Font("Segoe UI Semibold", 9f);
            this.ForeColor = Color.White;
            this.DoubleBuffered = true;

            imageDisplay.BackColor = Color.Transparent;
            imageDisplay.Dock = DockStyle.Fill;
            imageDisplay.Visible = false;
            imageDisplay.SizeMode = PictureBoxSizeMode.CenterImage;
            imageDisplay.Click += new EventHandler(Img_Click);
            imageDisplay.MouseDown += new MouseEventHandler(Img_MouseDown);
            imageDisplay.MouseHover += new EventHandler(Img_MouseHover);
            imageDisplay.MouseUp += new MouseEventHandler(Img_MouseUp);
            this.Controls.Add(imageDisplay);
        }

        PictureBox imageDisplay = new PictureBox();
        private Color backColor = Color.FromArgb(0, 99, 177);

        public delegate void WindowDeletgate(object sender, EventArgs e);
        public event WindowDeletgate OnTileButtonMouseClick;
        public event WindowDeletgate OnTileButtonMouseDown;
        public event WindowDeletgate OnTileButtonMouseHover;
        public event WindowDeletgate OnTileButtonMouseUp;

        #region Colors

        [Category("Windows UI")]
        [DisplayName("Normal Color")]
        public Color Normal { get; set; } = Color.FromArgb(0, 99, 177);

        [Category("Windows UI")]
        [DisplayName("Hover Color")]
        public Color Hover { get; set; } = Color.FromArgb(0, 33, 59);

        [Category("Windows UI")]
        [DisplayName("Press Color")]              
        public Color Press { get; set; } = Color.FromArgb(0, 66, 118);

        #endregion

        #region ...

        private string content = string.Empty;
        [Category("Windows UI")]
        [DisplayName("Content")]
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                this.Invalidate();
            }
        }

        private AdvancedTextAnchor textAnchor = AdvancedTextAnchor.Center;
        [Category("Windows UI")]
        [DisplayName("Text Anchor")]
        public AdvancedTextAnchor TextAnchor
        {
            get
            {
                return textAnchor;
            }
            set
            {
                textAnchor = value;
                this.Invalidate();
            }
        }

        private CenterStyle centerStyle = CenterStyle.BelowImage;
        [Category("Windows UI")]
        [DisplayName("Center Style")]
        public CenterStyle CenterStyle
        {
            get
            {
                return centerStyle;
            }
            set
            {
                centerStyle = value;
                this.Invalidate();
            }
        }

        [Category("Windows UI")]
        [DisplayName("Image")]
        public Image Image
        {
            get
            {
                return imageDisplay.Image;
            }
            set
            {
                imageDisplay.Image = value;
                this.Invalidate();
            }
        }

        #endregion
        #region Events


        /*----------------------------------------------------------------------------------------*/

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(backColor), this.ClientRectangle);
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            int cursorX = -1, cursorY = -1;
            switch (TextAnchor)
            {
                case AdvancedTextAnchor.Center:
                    cursorX = (this.Width / 2) - (TextRenderer.MeasureText(Content, Font).Width / 2);
                    cursorY = (this.Height / 2) - (TextRenderer.MeasureText(Content, Font).Height / 2);
                    break;

                case AdvancedTextAnchor.CenterTop:
                    cursorX = (this.Width / 2) - (TextRenderer.MeasureText(Content, Font).Width / 2);
                    cursorY = 3;
                    break;

                case AdvancedTextAnchor.CenterBottom:
                    cursorX = (this.Width / 2) - (TextRenderer.MeasureText(Content, Font).Width / 2);
                    cursorY = (this.Height - (TextRenderer.MeasureText(Content, Font).Height) + 3) - (TextRenderer.MeasureText(Content, Font).Height / 2);
                    break;

                case AdvancedTextAnchor.LeftTop:
                    cursorX = 3;
                    cursorY = 3;
                    break;

                case AdvancedTextAnchor.RightTop:
                    cursorX = (this.Width) - (TextRenderer.MeasureText(Content, Font).Width + 1);
                    cursorY = 3;
                    break;

                case AdvancedTextAnchor.LeftBottom:
                    cursorX = 3;
                    cursorY = (this.Height - 3) - (TextRenderer.MeasureText(Content, Font).Height);
                    break;

                case AdvancedTextAnchor.RightBottom:
                    cursorX = (this.Width) - (TextRenderer.MeasureText(Content, Font).Width + 1);
                    cursorY = (this.Height - 3) - (TextRenderer.MeasureText(Content, Font).Height);
                    break;
            }

            if (Image != null)
            {
                imageDisplay.Visible = true;
                if (TextAnchor == AdvancedTextAnchor.Center)
                {
                    switch (CenterStyle)
                    {
                        case CenterStyle.BelowImage:
                            cursorY += Image.Width / 2 + 3;
                            break;

                        case CenterStyle.AboveImage:
                            cursorY -= Image.Height / 2 + 9;
                            break;
                    }
                }
            }
            else
            {
                imageDisplay.Visible = false;
            }

            e.Graphics.DrawString(Content, Font, new SolidBrush(ForeColor), new PointF(cursorX, cursorY));
        }

        private void Img_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            backColor = Normal;
            this.Refresh();
            if (OnTileButtonMouseUp != null)
            {
                OnTileButtonMouseUp(this, e);
            }
        }

        private void Img_MouseHover(object sender, EventArgs e)
        {
            backColor = Hover;
            this.Refresh();
            if (OnTileButtonMouseHover != null)
            {
                OnTileButtonMouseHover(this, e);
            }
        }

        private void Img_MouseDown(object sender, MouseEventArgs e)
        {
            backColor = Press;
            this.Refresh();
            if (OnTileButtonMouseDown != null)
            {
                OnTileButtonMouseDown(this, e);
            }
        }

        private void Img_Click(object sender, EventArgs e)
        {
            backColor = Press;
            this.Refresh();
            if (OnTileButtonMouseClick != null)
            {
                OnTileButtonMouseClick(this, e);
            }
        }

        /*----------------------------------------------------------------------------------------*/

        protected override void OnClick(EventArgs e)
        {
            if(OnTileButtonMouseClick != null)
            {
                backColor = Press;
                OnTileButtonMouseClick(this, e);
                this.Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            backColor = Press;
            this.Refresh();
            if (OnTileButtonMouseDown != null)
            {
                OnTileButtonMouseDown(this, e);
            }
        }

        protected override void OnMouseHover(EventArgs e)
        {
            backColor = Hover;
            this.Refresh();
            if (OnTileButtonMouseHover != null)
            {
                OnTileButtonMouseHover(this, e);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            backColor = Normal;
            this.Refresh();
            if (OnTileButtonMouseUp != null)
            {
                OnTileButtonMouseUp(this, e);
            }
        }

#endregion
    }
}
