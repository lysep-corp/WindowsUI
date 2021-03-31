
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
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCircularPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimaze);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(1116, 30);
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
            this.btnClose.Location = new System.Drawing.Point(1064, 0);
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
            this.winButton1.Location = new System.Drawing.Point(47, 307);
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
            this.winTextbox2.Image = null;
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
            this.winTileButton1.CenterStyle = WindowsUI.Enums.CenterStyle.AboveImage;
            this.winTileButton1.Content = "Discord";
            this.winTileButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winTileButton1.ForeColor = System.Drawing.Color.White;
            this.winTileButton1.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
            this.winTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("winTileButton1.Image")));
            this.winTileButton1.Location = new System.Drawing.Point(275, 74);
            this.winTileButton1.Name = "winTileButton1";
            this.winTileButton1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.winTileButton1.Press = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.winTileButton1.Size = new System.Drawing.Size(212, 241);
            this.winTileButton1.TabIndex = 9;
            this.winTileButton1.Text = "winTileButton1";
            this.winTileButton1.TextAnchor = WindowsUI.Enums.AdvancedTextAnchor.Center;
            this.winTileButton1.OnTileButtonMouseClick += new WindowsUI.Controls.WinTileButton.WindowDeletgate(this.winTileButton1_OnTileButtonMouseClick);
            this.winTileButton1.Click += new System.EventHandler(this.winTileButton1_Click);
            // 
            // winCircularPicturebox1
            // 
            this.winCircularPicturebox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winCircularPicturebox1.Location = new System.Drawing.Point(493, 74);
            this.winCircularPicturebox1.Name = "winCircularPicturebox1";
            this.winCircularPicturebox1.Size = new System.Drawing.Size(172, 172);
            this.winCircularPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winCircularPicturebox1.TabIndex = 10;
            this.winCircularPicturebox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 370);
            this.Controls.Add(this.winCircularPicturebox1);
            this.Controls.Add(this.winTileButton1);
            this.Controls.Add(this.winLabel1);
            this.Controls.Add(this.winButton1);
            this.Controls.Add(this.winTextbox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.winTextbox1);
            this.FormAccent = WindowsUI.Enums.AccentState.ACCENT_ENABLE_HOSTBACKDROP;
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
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.winTileButton1, 0);
            this.Controls.SetChildIndex(this.winCircularPicturebox1, 0);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCircularPicturebox1)).EndInit();
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
    }
}