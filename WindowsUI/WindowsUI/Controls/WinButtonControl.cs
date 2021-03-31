using System;
using System.Collections.Generic;
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
                e.Control.Margin = new Padding(1, 1, 1, 1);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
