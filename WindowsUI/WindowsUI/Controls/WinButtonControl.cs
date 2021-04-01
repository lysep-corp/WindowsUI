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
    public class WinButtonControl : FlowLayoutPanel
    {
        public WinButtonControl()
        {
            this.BackColor = Color.Black;
            this.Dock = DockStyle.Top;
            this.Height = 26;
        }

        [Category("Windows UI")]
        [DisplayName("TabBar Style")]
        public bool TabBarStyle { get; set; } = false;

        private int selectedTabIndex = 0;
        [Category("Windows UI")]
        [DisplayName("Selected Button Index")]
        public int SelectedTabIndex
        {
            get
            {
                return selectedTabIndex;
            }
            set
            {
                selectedTabIndex = value;
                if(TabBarStyle) {
                    WinButton btn = (WinButton)Controls[selectedTabIndex];
                    foreach (Control cntrl in this.Controls)
                    {
                        if (cntrl.GetType() == typeof(WinButton))
                        {
                            WinButton thisSender = (WinButton)cntrl;

                            if (thisSender == btn)
                            {
                                btn.Selected = true;
                            }
                            else
                            {
                                thisSender.Selected = false;
                            }
                            thisSender.Refresh();
                        }
                    }
                }
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            if(e.Control.GetType() != typeof(WinButton))
            {
                this.Controls.Remove(e.Control);
            }
            else
            {
                WinButton btn = (WinButton)e.Control;
                btn.BorderSize = 0;
                btn.Border  = this.BackColor;
                btn.Normal = this.BackColor;
                btn.Click += new EventHandler(btn_ClickSelectedState);
                e.Control.Margin = new Padding(1, 1, 1, 1);
                if (this.Controls.Count == 1 && TabBarStyle)
                {
                    btn.Selected = true;
                    btn.Refresh();
                }
            }
        }

        private void btn_ClickSelectedState(object sender, EventArgs e)
        {
            if(TabBarStyle)
            {
                foreach (Control cntrl in this.Controls)
                {
                    if (cntrl.GetType() == typeof(WinButton))
                    {
                        WinButton btn = (WinButton)cntrl;
                        WinButton thisBtn = (WinButton)sender;

                        if (btn == thisBtn)
                        {
                            thisBtn.Selected = true;
                        }
                        else
                        {
                            btn.Selected = false;
                        }
                        btn.Refresh();
                    }
                }
            }
            SelectedTabIndex = this.Controls.GetChildIndex((Control)sender);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
