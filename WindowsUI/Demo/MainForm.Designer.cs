
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
            this.winPanel1 = new WindowsUI.WinPanel();
            this.winButton2 = new WindowsUI.WinButton();
            this.winButton1 = new WindowsUI.WinButton();
            this.winCheckbox1 = new WindowsUI.Controls.WinCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.winColorPicker1 = new WindowsUI.Controls.WinColorPicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.winColorPicker2 = new WindowsUI.Controls.WinColorPicker();
            this.pnlTop.SuspendLayout();
            this.winPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlTop.Controls.Add(this.btnMinimaze);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(800, 30);
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
            this.btnMinimaze.Location = new System.Drawing.Point(644, 0);
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
            this.btnMaximize.Location = new System.Drawing.Point(696, 0);
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
            this.btnClose.Location = new System.Drawing.Point(748, 0);
            this.btnClose.Size = new System.Drawing.Size(52, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // winPanel1
            // 
            this.winPanel1.BackColor = System.Drawing.Color.Transparent;
            this.winPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.winPanel1.BorderRadius = 10;
            this.winPanel1.BorderSize = 2;
            this.winPanel1.Controls.Add(this.winButton2);
            this.winPanel1.Controls.Add(this.winButton1);
            this.winPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.winPanel1.ForeColor = System.Drawing.Color.White;
            this.winPanel1.Location = new System.Drawing.Point(12, 36);
            this.winPanel1.Name = "winPanel1";
            this.winPanel1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winPanel1.Opacity = 128;
            this.winPanel1.SeperatorWidth = 1;
            this.winPanel1.ShowBorder = false;
            this.winPanel1.Size = new System.Drawing.Size(200, 214);
            this.winPanel1.TabIndex = 2;
            this.winPanel1.Title = "Title";
            // 
            // winButton2
            // 
            this.winButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winButton2.ForeColor = System.Drawing.Color.White;
            this.winButton2.Location = new System.Drawing.Point(5, 58);
            this.winButton2.Name = "winButton2";
            this.winButton2.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton2.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winButton2.Size = new System.Drawing.Size(75, 23);
            this.winButton2.TabIndex = 4;
            this.winButton2.Text = "winButton2";
            this.winButton2.UseVisualStyleBackColor = false;
            this.winButton2.Click += new System.EventHandler(this.winButton2_Click);
            // 
            // winButton1
            // 
            this.winButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.winButton1.ForeColor = System.Drawing.Color.White;
            this.winButton1.Location = new System.Drawing.Point(5, 29);
            this.winButton1.Name = "winButton1";
            this.winButton1.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.winButton1.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winButton1.Size = new System.Drawing.Size(75, 23);
            this.winButton1.TabIndex = 3;
            this.winButton1.Text = "winButton1";
            this.winButton1.UseVisualStyleBackColor = false;
            this.winButton1.Click += new System.EventHandler(this.winButton1_Click);
            // 
            // winCheckbox1
            // 
            this.winCheckbox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.winCheckbox1.BorderColor = System.Drawing.Color.Gray;
            this.winCheckbox1.Checked = false;
            this.winCheckbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winCheckbox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.winCheckbox1.ForeColor = System.Drawing.Color.White;
            this.winCheckbox1.Location = new System.Drawing.Point(218, 47);
            this.winCheckbox1.Name = "winCheckbox1";
            this.winCheckbox1.Size = new System.Drawing.Size(16, 16);
            this.winCheckbox1.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.winCheckbox1.TabIndex = 3;
            this.winCheckbox1.CheckedChanged += new WindowsUI.Controls.WinCheckbox.checkedChanged(this.winCheckbox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
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
            this.pictureBox1.Location = new System.Drawing.Point(319, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // winColorPicker2
            // 
            this.winColorPicker2.BackColor = System.Drawing.Color.Transparent;
            this.winColorPicker2.Location = new System.Drawing.Point(218, 69);
            this.winColorPicker2.Name = "winColorPicker2";
            this.winColorPicker2.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.winColorPicker2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.winColorPicker2.Size = new System.Drawing.Size(95, 95);
            this.winColorPicker2.TabIndex = 8;
            this.winColorPicker2.Text = "winColorPicker2";
            this.winColorPicker2.ColorChanged += new WindowsUI.Controls.WinColorPicker.colorChanged(this.winColorPicker2_ColorChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winColorPicker2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winCheckbox1);
            this.Controls.Add(this.winPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Title = "DENEME";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.winPanel1, 0);
            this.Controls.SetChildIndex(this.winCheckbox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.winColorPicker2, 0);
            this.pnlTop.ResumeLayout(false);
            this.winPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsUI.WinPanel winPanel1;
        private WindowsUI.WinButton winButton1;
        private WindowsUI.Controls.WinCheckbox winCheckbox1;
        private System.Windows.Forms.Label label1;
        private WindowsUI.WinButton winButton2;
        private WindowsUI.Controls.WinColorPicker winColorPicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsUI.Controls.WinColorPicker winColorPicker2;
    }
}