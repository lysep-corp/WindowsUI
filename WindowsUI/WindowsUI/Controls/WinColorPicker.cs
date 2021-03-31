using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace WindowsUI.Controls
{
    [DefaultEvent("ColorChanged")]
    public class WinColorPicker : Control
    {
        [Category("Windows UI")]
        [DisplayName("Normal Color")]
        public Color Normal { get; set; } = Color.FromArgb(25, 25, 25);

        [Category("Windows UI")]
        [DisplayName("Selected Color")]
        public Color SelectedColor { get; set; } = Color.FromArgb(255, 255, 255);

        public WinColorPicker()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Size = new Size(95, 95);
            this.BackColor = Color.Transparent;
        }
        public delegate void colorChanged(object sender, ColorChangedEventArgs e);
        public event colorChanged ColorChanged;
        PictureBox pbColorWheel = new PictureBox();
        PictureBox selectedColor = new PictureBox();

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            pbColorWheel.Image = (Image)Methods.Base64StringToBitmap(Constants.ColorWheel64);
            pbColorWheel.Location = new Point(2, 2);
            pbColorWheel.Size = new Size(Width - 4, Height - 4);
            pbColorWheel.SizeMode = PictureBoxSizeMode.Zoom;
            pbColorWheel.MouseDown += new MouseEventHandler(ColorWheel_Start);
            pbColorWheel.MouseMove += new MouseEventHandler(ColorWheel_SelectColor);
            pbColorWheel.MouseUp += new MouseEventHandler(ColorWheel_End);
            selectedColor.Visible = false;
            selectedColor.Size = new Size(8, 8);
            selectedColor.Paint += new PaintEventHandler(SelectedColor_OnPaint);
            this.Controls.Add(selectedColor);
            this.Controls.Add(pbColorWheel);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(128, Normal)), new RectangleF(0, 0, Width -1, Height - 1));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(95, 95);
        }

        private void SelectedColor_OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, selectedColor.Width - 1, selectedColor.Height - 1));
        }

        private bool MouseDown = false;
        private void ColorWheel_Start(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDown = true;
                ColorWheel_SelectColor(sender, e);
            }
        }

        private void ColorWheel_SelectColor(object sender, MouseEventArgs e)
        {
            try
            {
                if (MouseDown)
                {
                    if (e.X >= 0 && e.Y >= 0)
                    {
                        if (e.X <= pbColorWheel.Width - 2 && e.Y <= pbColorWheel.Height - 2)
                        {
                            var bmp = new Bitmap(pbColorWheel.Image, pbColorWheel.Size.Width, pbColorWheel.Size.Height);
                            Bitmap processedBtmap = Methods.ResizeBitmap(bmp, pbColorWheel.Width, pbColorWheel.Height);
                            Color output = processedBtmap.GetPixel(e.X, e.Y);
                            if (output.A == 255)
                            {
                                int x = (e.X > (pbColorWheel.Width - (pbColorWheel.Width / 2)) ? -15 : 10);
                                int y = (e.Y < (pbColorWheel.Height - (pbColorWheel.Height / 2)) ? -20 : 10);

                                selectedColor.Location = new Point(e.X + x, e.Y - y);

                                selectedColor.BackColor = output;
                                selectedColor.Visible = true;
                                SelectedColor = output;
                                if(ColorChanged != null)
                                {
                                    ColorChanged(this, new ColorChangedEventArgs() { Color = output});
                                }
                            }
                            else
                            {
                                selectedColor.Visible = false;
                            }
                        }
                    }
                }
            } catch { }
        }

        private void ColorWheel_End(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            selectedColor.Visible = false;
        }
    }

    public class ColorChangedEventArgs : EventArgs
    {
        public Color Color { get; set; }
    }
}
