using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsUI;

namespace Demo
{
    public partial class MainForm : WinForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void winCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowTitle = winCheckbox1.Checked;
            this.Refresh();
        }

        private void winButton1_Click(object sender, EventArgs e)
        {
            ShowControlBarIcon = false;
            this.TextAnchor = Enums.TextAnchor.Center;
        }

        private void winButton2_Click(object sender, EventArgs e)
        {
            ShowControlBarIcon = true;
            this.TextAnchor = Enums.TextAnchor.Right;
        }

        private void winToggleSwitch1_CheckedChanged(object sender)
        {
            Application.DoEvents();
        }

        private void winColorPicker2_ColorChanged(object sender, WindowsUI.Controls.ColorChangedEventArgs e)
        {
            pictureBox1.BackColor = e.Color;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.ShowControlBarIcon = !this.ShowControlBarIcon;
        //}

        //private void winButton1_Click(object sender, EventArgs e)
        //{
        //    this.CloseButton = !this.CloseButton;
        //}
    }
}
