using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsUI.Design;

namespace WindowsUI
{
    public class WinForm : Form
    {
        public WinForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(33, 33, 33);
            this.ForeColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(WinForm_Load);
            this.Controls.Add(pnlTop);
            pnlTop.BackColor = Color.Black;
        }

        public Panel pnlTop = new Panel();
        Label lblProgram = new Label();
        public Button btnMinimaze = new Button();
        public Button btnMaximize = new Button();
        public Button btnClose = new Button();
        PictureBox pbProgram = new PictureBox();
        PictureBox pbResize = new PictureBox();

        [Category("Windows UI - Control Bar")]
        [DisplayName("Title")]
        public string Title
        {
            get
            {
                return lblProgram.Text;
            }
            set
            {
                lblProgram.Text = value;
            }
        }

        [Category("Windows UI - Control Bar")]
        [DisplayName("Close Button")]
        public bool CloseButton
        {
            get
            {
                return btnClose.Visible;
            }
            set
            {
                btnClose.Visible = value;
            }
        }

        [Category("Windows UI - Control Bar")]
        [DisplayName("Minimaze Button")]
        public bool MinimazeButton
        {
            get
            {
                return btnMinimaze.Visible;
            }
            set
            {
                btnMinimaze.Visible = value;
            }
        }

        [Category("Windows UI - Control Bar")]
        [DisplayName("Maximize Button")]
        public bool MaximizeButton
        {
            get
            {
                return btnMaximize.Visible;
            }
            set
            {
                btnMaximize.Visible = value;
            }
        }

        private bool showTitle = true;
        [Category("Windows UI - Control Bar")]
        [DisplayName("Show Title")]
        public bool ShowTitle
        {
            get
            {
                return showTitle;
            }
            set
            {
                showTitle = value;
                if(TextAnchor == Enums.TextAnchor.Right)
                {
                    lblProgram.Visible = showTitle;
                }
                else
                {
                    lblProgram.Visible = false;
                }
                pnlTop.Invalidate();
            }
        }

        [Category("Windows UI")]
        [DisplayName("Drag")]
        [Description("If Drag with Visual Type, Maybe exception or bug")]
        public bool Drag { get; set; } = true;

        [Category("Windows UI")]
        [DisplayName("Extra Shadow")]
        [Description("GS_DropShadow")]
        public bool ExtraDropShadow { get; set; } = false;

        [Category("Windows UI - Control Bar")]
        [DisplayName("Show Control Bar Icon")]
        public bool ShowControlBarIcon
        {
            get
            {
                return pbProgram.Visible;
            }
            set
            {
                pbProgram.Visible = value;
                if (pbProgram.Visible)
                {
                    lblProgram.Location = new Point(33, 8);
                }
                else
                {
                    lblProgram.Location = new Point(5, 8);
                }
            }
        }

        [Category("Windows UI")]
        public bool Resizer { get; set; } = true;

        [Category("Windows UI - Resize")]
        public int MinWidth { get; set; } = 350;

        [Category("Windows UI - Resize")]
        public int MinHeight { get; set; } = 350;

        [Category("Windows UI - Resize")]
        [DisplayName("ResizeGrip Size")]
        public int ResizeGripSize { get; set; } = 4;

        private Enums.AccentState accentState = Enums.AccentState.ACCENT_ENABLE_BLURBEHIND;
        [Category("Windows UI")]
        [DisplayName("Form Accent")]
        public Enums.AccentState FormAccent
        {
            get
            {
                return accentState;
            }
            set
            {
                accentState = value;
                Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = accentState });
            }
        }

        private Enums.TextAnchor textAnchor = Enums.TextAnchor.Right;
        [Category("Windows UI - Control Bar")]
        [DisplayName("Text Anchor")]
        public Enums.TextAnchor TextAnchor
        {
            get
            {
                return textAnchor;
            }
            set
            {
                textAnchor = value;
                if(textAnchor == Enums.TextAnchor.Right)
                {
                    lblProgram.Visible = ShowTitle;
                }
                else if (textAnchor == Enums.TextAnchor.Center)
                {
                    lblProgram.Visible = false;
                }
                pnlTop.Invalidate();
            }
        }

        private void WinForm_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(WinForm_Resize);

            #region Top Panel
            pnlTop.Size = new Size(560, 30);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Paint += new PaintEventHandler(pnlTop_Paint);
            AddDrag(pnlTop);
            //this.Controls.Add(pnlTop);
            #endregion

            #region Minimaze Button
            btnMinimaze.ForeColor = ForeColor;
            btnMinimaze.BackColor = pnlTop.BackColor;
            btnMinimaze.FlatStyle = FlatStyle.Flat;
            btnMinimaze.FlatAppearance.BorderSize = 0;
            btnMinimaze.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 44, 44);
            btnMinimaze.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 66, 66);
            btnMinimaze.Size = new Size(52, 30);
            btnMinimaze.Dock = DockStyle.Right;
            btnMinimaze.Cursor = Cursors.Hand;
            btnMinimaze.Font = new Font("Segoe UI Symbol", 9f);
            btnMinimaze.Text = "─";
            btnMinimaze.Click += new EventHandler(Minimaze);
            pnlTop.Controls.Add(btnMinimaze);
            #endregion

            #region Maximize Button
            btnMaximize.ForeColor = ForeColor;
            btnMaximize.BackColor = pnlTop.BackColor;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 44, 44);
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 66, 66);
            btnMaximize.Size = new Size(52, 30);
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Font = new Font("Segoe UI Symbol", 9f);
            btnMaximize.Text = "◻";
            btnMaximize.Click += new EventHandler(Maximize);
            pnlTop.Controls.Add(btnMaximize);
            #endregion

            #region Close Button
            btnClose.ForeColor = ForeColor;
            btnClose.BackColor = pnlTop.BackColor;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.Size = new Size(52, 30);
            btnClose.Dock = DockStyle.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI Symbol", 9f);
            btnClose.Text = "✕";
            btnClose.Click += new EventHandler(Close);
            pnlTop.Controls.Add(btnClose);
            #endregion

            #region Program (Picturebox for Icon)
            pbProgram.SizeMode = PictureBoxSizeMode.Zoom;
            pbProgram.Location = new Point(4, 2);
            pbProgram.Size = new Size(24, 24);
            pbProgram.Image = this.Icon.ToBitmap();
            AddDrag(pbProgram);
            pnlTop.Controls.Add(pbProgram);
            #endregion

            #region Program (Label -> Title)
            if (this.Icon != null && ShowControlBarIcon)
            {
                lblProgram.Location = new Point(33, 8);
            }
            else
            {
                lblProgram.Location = new Point(5, 8);
            }
            lblProgram.ForeColor = ForeColor;
            AddDrag(lblProgram);
            pnlTop.Controls.Add(lblProgram);
            #endregion

            #region ResizeGrip (Picturebox)
            pbResize.MouseDown += SizerMouseDown;
            pbResize.MouseMove += SizerMouseMove;
            pbResize.MouseUp += SizerMouseUp;
            pbResize.Size = new Size(ResizeGripSize, ResizeGripSize);
            pbResize.BackColor = Color.Transparent;
            pbResize.Location = new Point(this.Width - pbResize.Size.Width, this.Height - pbResize.Size.Height);
            //pbResize.Cursor = Cursors.SizeNWSE;
            this.Controls.Add(pbResize);
            pbResize.BringToFront();
            #endregion

            #region Extra
            Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = FormAccent });
            if(ExtraDropShadow)
                Shadow.AddShadow(Handle);
            #endregion
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            if(TextAnchor == Enums.TextAnchor.Center && ShowTitle)
            {
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                TextRenderer.DrawText(e.Graphics, Title, Font, new Point(pnlTop.Width + 2, pnlTop.Height / 2), Color.FromArgb(128, ForeColor), flags);
            }
        }

        private void WinForm_Resize(object sender, EventArgs e)
        {
            pbResize.Location = new Point(this.Width - pbResize.Size.Width, this.Height - pbResize.Size.Height);
            pbResize.BringToFront();
            pnlTop.Invalidate();
        }

        private void Close(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Maximize(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Normal;
                    break;

                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        private void Minimaze(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Resize 
        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        void SizerMouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        void SizerMouseMove(object sender, MouseEventArgs e)
        {
            pbResize.Cursor = Resizer ? Cursors.SizeNWSE : Cursors.Default;
            if (mov && Resizer)
            {
                Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = Enums.AccentState.ACCENT_DISABLED });
                this.Opacity = 0.85;
                int t_width = MousePosition.X - Mx + Sw;
                int t_height = MousePosition.Y - My + Sh;
                if(t_width >= MinWidth)
                {
                    Width = t_width;
                }
                if(t_height >= MinHeight)
                {
                    Height = t_height;
                }
            }
        }

        void SizerMouseUp(object sender, MouseEventArgs e)
        {
            Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = FormAccent });
            Opacity = 1.0;
            mov = false;
        }
        #endregion

        #region DragForm

        public void AddDrag(Control cntrl)
        {
            cntrl.MouseDown += new MouseEventHandler(Drag_MouseDown);
            cntrl.MouseMove += new MouseEventHandler(Drag_MouseMove);
            cntrl.MouseUp += new MouseEventHandler(Drag_MouseUp);
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            if(Drag)
            {
                Control cntrl = (Control)sender;
                Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = Enums.AccentState.ACCENT_DISABLED });
                this.Opacity = 0.85;
                cntrl.Cursor = Cursors.Hand;
            }
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && Drag)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if(Drag)
            {
                Control cntrl = (Control)sender;
                Aero.ChangeAccent(Handle, new Enums.AccentPolicy { GradientColor = 0xFD70000, AccentState = FormAccent });
                this.Opacity = 1;
                cntrl.Cursor = Cursors.Default;
            }
        }
        #endregion
    }
}
