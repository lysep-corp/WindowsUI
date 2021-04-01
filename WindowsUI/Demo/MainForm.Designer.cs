
namespace Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.winColorPicker1 = new WindowsUI.Controls.WinColorPicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.winButton1 = new WindowsUI.WinButton();
            this.winLabel1 = new WindowsUI.Controls.WinLabel();
            this.winTextbox1 = new WindowsUI.Controls.WinTextbox();
            this.winTextbox2 = new WindowsUI.Controls.WinTextbox();
            this.winTileButton1 = new WindowsUI.Controls.WinTileButton();
            this.winCircularPicturebox1 = new WindowsUI.Controls.WinCircularPicturebox();
            this.winColorPicker2 = new WindowsUI.Controls.WinColorPicker();
            this.winCheckbox1 = new WindowsUI.Controls.WinCheckbox();
            this.winLabel2 = new WindowsUI.Controls.WinLabel();
            this.winLabel3 = new WindowsUI.Controls.WinLabel();
            this.winPanel1 = new WindowsUI.WinPanel();
            this.winProgressbar1 = new WindowsUI.Controls.WinProgressbar();
            this.winCheckbox2 = new WindowsUI.Controls.WinCheckbox();
            this.winProgressbar2 = new WindowsUI.Controls.WinProgressbar();
            this.updateSelectedTab = new System.Windows.Forms.Timer(this.components);
            this.winButtonControl1 = new WindowsUI.Controls.WinButtonControl();
            this.winButton2 = new WindowsUI.WinButton();
            this.winButton3 = new WindowsUI.WinButton();
            this.winButton4 = new WindowsUI.WinButton();
            this.lblSelectedTabIndex = new WindowsUI.Controls.WinLabel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCircularPicturebox1)).BeginInit();
            this.winPanel1.SuspendLayout();
            this.winButtonControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimaze);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(620, 30);
            this.pnlTop.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMaximize, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMinimaze, 0);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.BackColor = System.Drawing.Color.Black;
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(144, 0);
            this.btnMinimaze.Size = new System.Drawing.Size(52, 30);
            this.btnMinimaze.Text = "─";
            this.btnMinimaze.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(196, 0);
            this.btnMaximize.Size = new System.Drawing.Size(52, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "◻";
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(568, 0);
            this.btnClose.Size = new System.Drawing.Size(52, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // winColorPicker1
            // 
            this.winColorPicker1.BackColor = System.Drawing.Color.Transparent;
            this.winColorPicker1.Location = new System.Drawing.Point(0, 0);
            this.winColorPicker1.Name = "winColorPicker1";
            this.winColorPicker1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winColorPicker1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.winColorPicker1.Size = new System.Drawing.Size(95, 95);
            this.winColorPicker1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // winButton1
            // 
            this.winButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton1.Border = System.Drawing.Color.Gray;
            this.winButton1.BorderSize = 1F;
            this.winButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winButton1.ForeColor = System.Drawing.Color.White;
            this.winButton1.Image = ((System.Drawing.Image)(resources.GetObject("winButton1.Image")));
            this.winButton1.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.CenterRight;
            this.winButton1.Location = new System.Drawing.Point(26, 350);
            this.winButton1.Name = "winButton1";
            this.winButton1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton1.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winButton1.Selected = false;
            this.winButton1.SelectedBorderSize = 4;
            this.winButton1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winButton1.SelectedStyle = WindowsUI.Enums.SelectedStyle.Left;
            this.winButton1.Size = new System.Drawing.Size(172, 23);
            this.winButton1.TabIndex = 5;
            this.winButton1.Text = "Log InASDASD";
            this.winButton1.UseVisualStyleBackColor = false;
            this.winButton1.Click += new System.EventHandler(this.winButton1_Click);
            // 
            // winLabel1
            // 
            this.winLabel1.AutoSize = true;
            this.winLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winLabel1.ForeColor = System.Drawing.Color.White;
            this.winLabel1.Location = new System.Drawing.Point(68, 70);
            this.winLabel1.Name = "winLabel1";
            this.winLabel1.Size = new System.Drawing.Size(75, 15);
            this.winLabel1.TabIndex = 8;
            this.winLabel1.Text = "ANTI - CORE";
            // 
            // winTextbox1
            // 
            this.winTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox1.Content = "";
            this.winTextbox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winTextbox1.ForeColor = System.Drawing.Color.White;
            this.winTextbox1.Image = ((System.Drawing.Image)(resources.GetObject("winTextbox1.Image")));
            this.winTextbox1.Location = new System.Drawing.Point(26, 266);
            this.winTextbox1.MaxLength = 32767;
            this.winTextbox1.Name = "winTextbox1";
            this.winTextbox1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox1.PassChar = '\0';
            this.winTextbox1.ReadOnlyText = false;
            this.winTextbox1.Size = new System.Drawing.Size(172, 25);
            this.winTextbox1.TabIndex = 2;
            this.winTextbox1.Text = "winTextbox1";
            this.winTextbox1.TextChanged += new WindowsUI.Controls.WinTextbox.textChanged(this.winTextbox1_TextChanged);
            // 
            // winTextbox2
            // 
            this.winTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox2.Content = "";
            this.winTextbox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winTextbox2.ForeColor = System.Drawing.Color.White;
            this.winTextbox2.Image = ((System.Drawing.Image)(resources.GetObject("winTextbox2.Image")));
            this.winTextbox2.Location = new System.Drawing.Point(26, 297);
            this.winTextbox2.MaxLength = 32767;
            this.winTextbox2.Name = "winTextbox2";
            this.winTextbox2.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox2.PassChar = '\0';
            this.winTextbox2.ReadOnlyText = false;
            this.winTextbox2.Size = new System.Drawing.Size(172, 25);
            this.winTextbox2.TabIndex = 4;
            this.winTextbox2.Text = "winTextbox2";
            // 
            // winTileButton1
            // 
            this.winTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winTileButton1.CenterStyle = WindowsUI.Enums.CenterStyle.BelowImage;
            this.winTileButton1.Content = "Discord";
            this.winTileButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winTileButton1.ForeColor = System.Drawing.Color.White;
            this.winTileButton1.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
            this.winTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("winTileButton1.Image")));
            this.winTileButton1.Location = new System.Drawing.Point(148, 183);
            this.winTileButton1.Name = "winTileButton1";
            this.winTileButton1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winTileButton1.Press = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.winTileButton1.Size = new System.Drawing.Size(94, 94);
            this.winTileButton1.TabIndex = 9;
            this.winTileButton1.Text = "winTileButton1";
            this.winTileButton1.TextAnchor = WindowsUI.Enums.AdvancedTextAnchor.Center;
            this.winTileButton1.OnTileButtonMouseClick += new WindowsUI.Controls.WinTileButton.WindowDeletgate(this.winTileButton1_OnTileButtonMouseClick);
            this.winTileButton1.Click += new System.EventHandler(this.winTileButton1_Click);
            // 
            // winCircularPicturebox1
            // 
            this.winCircularPicturebox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winCircularPicturebox1.Location = new System.Drawing.Point(29, 192);
            this.winCircularPicturebox1.Name = "winCircularPicturebox1";
            this.winCircularPicturebox1.Size = new System.Drawing.Size(64, 64);
            this.winCircularPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winCircularPicturebox1.TabIndex = 10;
            this.winCircularPicturebox1.TabStop = false;
            // 
            // winColorPicker2
            // 
            this.winColorPicker2.BackColor = System.Drawing.Color.Transparent;
            this.winColorPicker2.Location = new System.Drawing.Point(6, 26);
            this.winColorPicker2.Name = "winColorPicker2";
            this.winColorPicker2.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winColorPicker2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.winColorPicker2.Size = new System.Drawing.Size(95, 95);
            this.winColorPicker2.TabIndex = 11;
            this.winColorPicker2.Text = "winColorPicker2";
            // 
            // winCheckbox1
            // 
            this.winCheckbox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winCheckbox1.BorderColor = System.Drawing.Color.Gray;
            this.winCheckbox1.Checked = false;
            this.winCheckbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winCheckbox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.winCheckbox1.ForeColor = System.Drawing.Color.White;
            this.winCheckbox1.Location = new System.Drawing.Point(26, 328);
            this.winCheckbox1.Name = "winCheckbox1";
            this.winCheckbox1.Size = new System.Drawing.Size(16, 16);
            this.winCheckbox1.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.winCheckbox1.TabIndex = 12;
            // 
            // winLabel2
            // 
            this.winLabel2.AutoSize = true;
            this.winLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winLabel2.ForeColor = System.Drawing.Color.White;
            this.winLabel2.Location = new System.Drawing.Point(44, 329);
            this.winLabel2.Name = "winLabel2";
            this.winLabel2.Size = new System.Drawing.Size(85, 15);
            this.winLabel2.TabIndex = 13;
            this.winLabel2.Text = "Remember me";
            // 
            // winLabel3
            // 
            this.winLabel3.AutoSize = true;
            this.winLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winLabel3.ForeColor = System.Drawing.Color.White;
            this.winLabel3.Location = new System.Drawing.Point(8, 262);
            this.winLabel3.Name = "winLabel3";
            this.winLabel3.Size = new System.Drawing.Size(106, 15);
            this.winLabel3.TabIndex = 14;
            this.winLabel3.Text = "Microsoft User API";
            // 
            // winPanel1
            // 
            this.winPanel1.BackColor = System.Drawing.Color.Transparent;
            this.winPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.winPanel1.BorderRadius = 15;
            this.winPanel1.BorderSize = 2;
            this.winPanel1.Controls.Add(this.winProgressbar1);
            this.winPanel1.Controls.Add(this.winCircularPicturebox1);
            this.winPanel1.Controls.Add(this.winTileButton1);
            this.winPanel1.Controls.Add(this.winLabel3);
            this.winPanel1.Controls.Add(this.winColorPicker2);
            this.winPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.winPanel1.ForeColor = System.Drawing.Color.White;
            this.winPanel1.Location = new System.Drawing.Point(207, 88);
            this.winPanel1.Name = "winPanel1";
            this.winPanel1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winPanel1.Opacity = 128;
            this.winPanel1.SeperatorWidth = 1;
            this.winPanel1.ShowBorder = false;
            this.winPanel1.Size = new System.Drawing.Size(250, 285);
            this.winPanel1.TabIndex = 15;
            this.winPanel1.Title = "Title";
            // 
            // winProgressbar1
            // 
            this.winProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.winProgressbar1.Border = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winProgressbar1.Content = "LYSEP1";
            this.winProgressbar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.winProgressbar1.ForeColor = System.Drawing.Color.White;
            this.winProgressbar1.Location = new System.Drawing.Point(119, 39);
            this.winProgressbar1.Name = "winProgressbar1";
            this.winProgressbar1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winProgressbar1.Progress1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winProgressbar1.Progress2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winProgressbar1.Size = new System.Drawing.Size(100, 23);
            this.winProgressbar1.TabIndex = 16;
            this.winProgressbar1.Value = 90;
            // 
            // winCheckbox2
            // 
            this.winCheckbox2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winCheckbox2.BorderColor = System.Drawing.Color.Gray;
            this.winCheckbox2.Checked = false;
            this.winCheckbox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winCheckbox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.winCheckbox2.ForeColor = System.Drawing.Color.White;
            this.winCheckbox2.Location = new System.Drawing.Point(334, 13);
            this.winCheckbox2.Name = "winCheckbox2";
            this.winCheckbox2.Size = new System.Drawing.Size(16, 16);
            this.winCheckbox2.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.winCheckbox2.TabIndex = 1;
            // 
            // winProgressbar2
            // 
            this.winProgressbar2.BackColor = System.Drawing.Color.Transparent;
            this.winProgressbar2.Border = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.winProgressbar2.Content = "";
            this.winProgressbar2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.winProgressbar2.ForeColor = System.Drawing.Color.White;
            this.winProgressbar2.Location = new System.Drawing.Point(379, 2);
            this.winProgressbar2.Name = "winProgressbar2";
            this.winProgressbar2.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winProgressbar2.Progress1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winProgressbar2.Progress2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winProgressbar2.Size = new System.Drawing.Size(100, 23);
            this.winProgressbar2.TabIndex = 3;
            // 
            // updateSelectedTab
            // 
            this.updateSelectedTab.Enabled = true;
            this.updateSelectedTab.Tick += new System.EventHandler(this.updateSelectedTab_Tick);
            // 
            // winButtonControl1
            // 
            this.winButtonControl1.BackColor = System.Drawing.Color.Black;
            this.winButtonControl1.Controls.Add(this.winButton2);
            this.winButtonControl1.Controls.Add(this.winButton3);
            this.winButtonControl1.Controls.Add(this.winButton4);
            this.winButtonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.winButtonControl1.Location = new System.Drawing.Point(0, 30);
            this.winButtonControl1.Name = "winButtonControl1";
            this.winButtonControl1.SelectedTabIndex = 1;
            this.winButtonControl1.Size = new System.Drawing.Size(620, 26);
            this.winButtonControl1.TabBarStyle = true;
            this.winButtonControl1.TabIndex = 17;
            // 
            // winButton2
            // 
            this.winButton2.Border = System.Drawing.Color.Black;
            this.winButton2.BorderSize = 0F;
            this.winButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winButton2.ForeColor = System.Drawing.Color.White;
            this.winButton2.Image = null;
            this.winButton2.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.winButton2.Location = new System.Drawing.Point(1, 1);
            this.winButton2.Margin = new System.Windows.Forms.Padding(1);
            this.winButton2.Name = "winButton2";
            this.winButton2.Normal = System.Drawing.Color.Black;
            this.winButton2.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winButton2.Selected = false;
            this.winButton2.SelectedBorderSize = 2;
            this.winButton2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winButton2.SelectedStyle = WindowsUI.Enums.SelectedStyle.Fill;
            this.winButton2.Size = new System.Drawing.Size(95, 23);
            this.winButton2.TabIndex = 0;
            this.winButton2.Text = "WinButtonTab";
            this.winButton2.UseVisualStyleBackColor = true;
            // 
            // winButton3
            // 
            this.winButton3.Border = System.Drawing.Color.Black;
            this.winButton3.BorderSize = 0F;
            this.winButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winButton3.ForeColor = System.Drawing.Color.White;
            this.winButton3.Image = null;
            this.winButton3.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.winButton3.Location = new System.Drawing.Point(98, 1);
            this.winButton3.Margin = new System.Windows.Forms.Padding(1);
            this.winButton3.Name = "winButton3";
            this.winButton3.Normal = System.Drawing.Color.Black;
            this.winButton3.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winButton3.Selected = true;
            this.winButton3.SelectedBorderSize = 2;
            this.winButton3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winButton3.SelectedStyle = WindowsUI.Enums.SelectedStyle.Fill;
            this.winButton3.Size = new System.Drawing.Size(95, 23);
            this.winButton3.TabIndex = 1;
            this.winButton3.Text = "WinButtonTab";
            this.winButton3.UseVisualStyleBackColor = true;
            // 
            // winButton4
            // 
            this.winButton4.Border = System.Drawing.Color.Black;
            this.winButton4.BorderSize = 0F;
            this.winButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winButton4.ForeColor = System.Drawing.Color.White;
            this.winButton4.Image = null;
            this.winButton4.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.winButton4.Location = new System.Drawing.Point(195, 1);
            this.winButton4.Margin = new System.Windows.Forms.Padding(1);
            this.winButton4.Name = "winButton4";
            this.winButton4.Normal = System.Drawing.Color.Black;
            this.winButton4.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winButton4.Selected = false;
            this.winButton4.SelectedBorderSize = 2;
            this.winButton4.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winButton4.SelectedStyle = WindowsUI.Enums.SelectedStyle.Fill;
            this.winButton4.Size = new System.Drawing.Size(95, 23);
            this.winButton4.TabIndex = 3;
            this.winButton4.Text = "WinButtonTab";
            this.winButton4.UseVisualStyleBackColor = true;
            // 
            // lblSelectedTabIndex
            // 
            this.lblSelectedTabIndex.AutoSize = true;
            this.lblSelectedTabIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblSelectedTabIndex.ForeColor = System.Drawing.Color.White;
            this.lblSelectedTabIndex.Location = new System.Drawing.Point(204, 69);
            this.lblSelectedTabIndex.Name = "lblSelectedTabIndex";
            this.lblSelectedTabIndex.Size = new System.Drawing.Size(123, 15);
            this.lblSelectedTabIndex.TabIndex = 18;
            this.lblSelectedTabIndex.Text = "Selected Tab Index : 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 406);
            this.Controls.Add(this.lblSelectedTabIndex);
            this.Controls.Add(this.winButtonControl1);
            this.Controls.Add(this.winPanel1);
            this.Controls.Add(this.winLabel2);
            this.Controls.Add(this.winCheckbox1);
            this.Controls.Add(this.winLabel1);
            this.Controls.Add(this.winButton1);
            this.Controls.Add(this.winTextbox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.winTextbox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeButton = false;
            this.MinHeight = 150;
            this.MinimazeButton = false;
            this.MinWidth = 150;
            this.Name = "MainForm";
            this.Resizer = false;
            this.TextAnchor = WindowsUI.Enums.TextAnchor.Center;
            this.Title = "Log In";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.winTextbox1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.winTextbox2, 0);
            this.Controls.SetChildIndex(this.winButton1, 0);
            this.Controls.SetChildIndex(this.winLabel1, 0);
            this.Controls.SetChildIndex(this.winCheckbox1, 0);
            this.Controls.SetChildIndex(this.winLabel2, 0);
            this.Controls.SetChildIndex(this.winPanel1, 0);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.winButtonControl1, 0);
            this.Controls.SetChildIndex(this.lblSelectedTabIndex, 0);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCircularPicturebox1)).EndInit();
            this.winPanel1.ResumeLayout(false);
            this.winPanel1.PerformLayout();
            this.winButtonControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsUI.Controls.WinColorPicker winColorPicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsUI.WinButton winButton1;
        private WindowsUI.Controls.WinLabel winLabel1;
        private WindowsUI.Controls.WinTextbox winTextbox1;
        private WindowsUI.Controls.WinTextbox winTextbox2;
        private WindowsUI.Controls.WinTileButton winTileButton1;
        private WindowsUI.Controls.WinCircularPicturebox winCircularPicturebox1;
        private WindowsUI.Controls.WinColorPicker winColorPicker2;
        private WindowsUI.Controls.WinCheckbox winCheckbox1;
        private WindowsUI.Controls.WinLabel winLabel2;
        private WindowsUI.Controls.WinLabel winLabel3;
        private WindowsUI.WinPanel winPanel1;
        private WindowsUI.Controls.WinProgressbar winProgressbar1;
        private WindowsUI.Controls.WinCheckbox winCheckbox2;
        private WindowsUI.Controls.WinProgressbar winProgressbar2;
        private System.Windows.Forms.Timer updateSelectedTab;
        private WindowsUI.Controls.WinButtonControl winButtonControl1;
        private WindowsUI.WinButton winButton2;
        private WindowsUI.WinButton winButton3;
        private WindowsUI.WinButton winButton4;
        private WindowsUI.Controls.WinLabel lblSelectedTabIndex;
    }
}