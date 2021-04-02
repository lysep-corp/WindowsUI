using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI.Controls
{
    [DefaultEvent("TextChanged")]
    public class WinTextbox : Control
    {
        [Category("Windows UI")]
        [DisplayName("Normal Color")]
        public Color Normal { get; set; } = Color.FromArgb(25, 25, 25);

        [Category("Windows UI")]
        [DisplayName("Content")]
        public string Content
        {
            get
            {
                return tbValue.Text;
            }
            set
            {
                tbValue.Text = value;
            }
        }

        [Category("Windows UI")]
        [DisplayName("Password Char")]
        public char PassChar
        {
            get
            {
                return tbValue.PasswordChar;
            }
            set
            {
                tbValue.PasswordChar = value;
            }
        }

        [Category("Windows UI")]
        [DisplayName("Read Only")]
        public bool ReadOnlyText
        {
            get
            {
                return tbValue.ReadOnly;
            }
            set
            {
                tbValue.ReadOnly = value;
            }
        }

        [Category("Windows UI")]
        [DisplayName("Only Numbers")]
        public bool OnlyNumbers { get; set; } = false;

        [Category("Windows UI")]
        [DisplayName("Max Length")]
        public int MaxLength
        {
            get
            {
                return tbValue.MaxLength;
            }
            set
            {
                tbValue.MaxLength = value;
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

        public delegate void textChanged(object sender, EventArgs e);
        public event textChanged TextChanged;

        public WinTextbox()
        {
            this.Size = new Size(150, 25);
            this.Font = new Font("Segoe UI Semibold", 9f);
            this.ForeColor = Color.White;

            tbValue.BorderStyle = BorderStyle.None;
            tbValue.BackColor = Normal;
            tbValue.Size = new Size(Width - 9, Height - 9);
            tbValue.Multiline = true;
            tbValue.Font = new Font("Segoe UI Semibold", 9f);
            tbValue.ForeColor = Color.White;
            tbValue.TextChanged += new EventHandler(Invoke_TextChanged);

            this.BackColor = tbValue.BackColor;
            tbValue.KeyPress += new KeyPressEventHandler(tbValue_KeyPress);
            this.Controls.Add(tbValue);

            imageDisplay.BackColor = Normal;
            imageDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            imageDisplay.Size = new Size(20, 20);
            imageDisplay.Location = new Point(2, 3);
            imageDisplay.Visible = false;
            this.Controls.Add(imageDisplay);
        }

        private void Invoke_TextChanged(object sender, EventArgs e)
        {
            if(TextChanged != null)
            {
                TextChanged(this, e);
            }
        }

        TextBox tbValue = new TextBox();
        PictureBox imageDisplay = new PictureBox();
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnResize(EventArgs e)
        {
            imageDisplay.Size = new Size(this.Height - 5, this.Height - 5);
            if (Image != null)
            {
                tbValue.Size = new Size(Width - 27, Height - 9);
                tbValue.Location = new Point(22, 5);
            }
            else
            {
                tbValue.Size = new Size(Width - 9, Height - 9);
                tbValue.Location = new Point(2, 5);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(Image != null)
            {
                imageDisplay.Visible = true;
                tbValue.Location = new Point(imageDisplay.Size.Width + 2, 5);
            }
            else
            {
                imageDisplay.Visible = false;
                tbValue.Location = new Point(2, 5);
            }

            e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 2f), new Rectangle(0, 0, Width, Height));
        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnlyNumbers)
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
        }
    }
}
