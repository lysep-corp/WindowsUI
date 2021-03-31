
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
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCircularPicturebox1)).BeginInit();
            this.winPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimaze);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(490, 30);
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
            this.btnClose.Location = new System.Drawing.Point(438, 0);
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
            this.pictureBox1.Location = new System.Drawing.Point(52, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // winButton1
            // 
            this.winButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winButton1.ForeColor = System.Drawing.Color.White;
            this.winButton1.Location = new System.Drawing.Point(47, 320);
            this.winButton1.Name = "winButton1";
            this.winButton1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton1.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winButton1.Size = new System.Drawing.Size(172, 23);
            this.winButton1.TabIndex = 5;
            this.winButton1.Text = "Log In";
            this.winButton1.UseVisualStyleBackColor = false;
            this.winButton1.Click += new System.EventHandler(this.winButton1_Click);
            // 
            // winLabel1
            // 
            this.winLabel1.AutoSize = true;
            this.winLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winLabel1.ForeColor = System.Drawing.Color.White;
            this.winLabel1.Location = new System.Drawing.Point(89, 40);
            this.winLabel1.Name = "winLabel1";
            this.winLabel1.Size = new System.Drawing.Size(75, 15);
            this.winLabel1.TabIndex = 8;
            this.winLabel1.Text = "ANTI - CORE";
            // 
            // winTextbox1
            // 
            this.winTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winTextbox1.ForeColor = System.Drawing.Color.White;
            this.winTextbox1.Image = ((System.Drawing.Image)(resources.GetObject("winTextbox1.Image")));
            this.winTextbox1.Location = new System.Drawing.Point(47, 236);
            this.winTextbox1.MaxLength = 32767;
            this.winTextbox1.Name = "winTextbox1";
            this.winTextbox1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox1.PassChar = '\0';
            this.winTextbox1.ReadOnlyText = false;
            this.winTextbox1.Size = new System.Drawing.Size(172, 25);
            this.winTextbox1.TabIndex = 2;
            this.winTextbox1.Text = "winTextbox1";
            this.winTextbox1.TextValue = "";
            this.winTextbox1.TextChanged += new WindowsUI.Controls.WinTextbox.textChanged(this.winTextbox1_TextChanged);
            // 
            // winTextbox2
            // 
            this.winTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winTextbox2.ForeColor = System.Drawing.Color.White;
            this.winTextbox2.Image = ((System.Drawing.Image)(resources.GetObject("winTextbox2.Image")));
            this.winTextbox2.Location = new System.Drawing.Point(47, 267);
            this.winTextbox2.MaxLength = 32767;
            this.winTextbox2.Name = "winTextbox2";
            this.winTextbox2.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winTextbox2.PassChar = '\0';
            this.winTextbox2.ReadOnlyText = false;
            this.winTextbox2.Size = new System.Drawing.Size(172, 25);
            this.winTextbox2.TabIndex = 4;
            this.winTextbox2.Text = "winTextbox2";
            this.winTextbox2.TextValue = "";
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
            this.winCheckbox1.Location = new System.Drawing.Point(47, 298);
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
            this.winLabel2.Location = new System.Drawing.Point(65, 299);
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
            this.winPanel1.Location = new System.Drawing.Point(228, 58);
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
            this.winProgressbar1.Content = "LYSEP";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 355);
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
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCircularPicturebox1)).EndInit();
            this.winPanel1.ResumeLayout(false);
            this.winPanel1.PerformLayout();
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
    }
}