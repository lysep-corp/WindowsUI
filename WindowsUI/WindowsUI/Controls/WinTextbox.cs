using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
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
        [DisplayName("Text Value")]
        public string TextValue
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
            tbValue.Location = new Point(2, 5);
            tbValue.Multiline = true;
            tbValue.Font = new Font("Segoe UI Semibold", 9f);
            tbValue.ForeColor = Color.White;
            tbValue.TextChanged += new EventHandler(Invoke_TextChanged);

            this.BackColor = tbValue.BackColor;
            this.Controls.Add(tbValue);
        }

        private void Invoke_TextChanged(object sender, EventArgs e)
        {
            if(TextChanged != null)
            {
                TextChanged(this, e);
            }
        }

        TextBox tbValue = new TextBox();

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnResize(EventArgs e)
        {
            tbValue.Size = new Size(Width - 9, Height - 9);
            tbValue.Location = new Point(2, 5);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 2f), new Rectangle(0, 0, Width, Height));
        }
    }
}
