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
            MicrosoftUser.GetUserPicturePath(null, out var temp);
            winCircularPicturebox1.ImageLocation = temp;
        }

        private void winTextbox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(winTextbox1.Content);
        }

        private void winButton1_Click(object sender, EventArgs e)
        {

        }

        private void winTileButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(winTileButton1.Text);
        }

        private void winTileButton1_OnTileButtonMouseClick(object sender, EventArgs e)
        {

        }

        private void updateSelectedTab_Tick(object sender, EventArgs e)
        {
            this.lblSelectedTabIndex.Text = "Selected Tab Index : " + winButtonControl1.SelectedTabIndex;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
