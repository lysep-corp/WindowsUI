using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI.Controls
{
    public class WinLabel : Label
    {
        public WinLabel()
        {
            this.Font = new Font("Segoe UI Semibold", 9f);
            this.ForeColor = Color.White;
        }
    }
}
