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
            Image result = Image.FromFile(temp);
            Bitmap btmp = Methods.ResizeImage(result, 64, 64);
            winTileButton1.Image = (Image)btmp;
        }

        private void winTextbox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(winTextbox1.TextValue);
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
    }
}
