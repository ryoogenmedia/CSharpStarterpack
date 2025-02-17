﻿namespace SharpStarter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            panelSubSetting = new Panel();
            btnProfil = new Button();
            btnAkun = new Button();
            btnSetting = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            panelPlayer = new Panel();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelSubSetting.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(panelSubSetting);
            panelSideMenu.Controls.Add(btnSetting);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 450);
            panelSideMenu.TabIndex = 0;
            // 
            // panelSubSetting
            // 
            panelSubSetting.BackColor = Color.FromArgb(35, 32, 39);
            panelSubSetting.Controls.Add(btnProfil);
            panelSubSetting.Controls.Add(btnAkun);
            panelSubSetting.Dock = DockStyle.Top;
            panelSubSetting.Location = new Point(0, 190);
            panelSubSetting.Name = "panelSubSetting";
            panelSubSetting.Size = new Size(250, 100);
            panelSubSetting.TabIndex = 3;
            // 
            // btnProfil
            // 
            btnProfil.Dock = DockStyle.Top;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.ForeColor = Color.LightGray;
            btnProfil.Location = new Point(0, 45);
            btnProfil.Name = "btnProfil";
            btnProfil.Padding = new Padding(35, 0, 0, 0);
            btnProfil.Size = new Size(250, 45);
            btnProfil.TabIndex = 1;
            btnProfil.Text = "Profil";
            btnProfil.TextAlign = ContentAlignment.MiddleLeft;
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnAkun
            // 
            btnAkun.Dock = DockStyle.Top;
            btnAkun.FlatAppearance.BorderSize = 0;
            btnAkun.FlatStyle = FlatStyle.Flat;
            btnAkun.ForeColor = Color.LightGray;
            btnAkun.Location = new Point(0, 0);
            btnAkun.Name = "btnAkun";
            btnAkun.Padding = new Padding(35, 0, 0, 0);
            btnAkun.Size = new Size(250, 45);
            btnAkun.TabIndex = 0;
            btnAkun.Text = "Akun";
            btnAkun.TextAlign = ContentAlignment.MiddleLeft;
            btnAkun.UseVisualStyleBackColor = true;
            btnAkun.Click += btnAkun_Click;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.ForeColor = Color.Gainsboro;
            btnSetting.Location = new Point(0, 145);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(10, 0, 0, 0);
            btnSetting.Size = new Size(250, 45);
            btnSetting.TabIndex = 2;
            btnSetting.Text = "Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(250, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(23, 21, 32);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(250, 399);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(550, 51);
            panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(550, 399);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 77);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSideMenu);
            Name = "Form1";
            Text = "Form1";
            panelSideMenu.ResumeLayout(false);
            panelSubSetting.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button btnDashboard;
        private Panel panelSubSetting;
        private Button btnProfil;
        private Button btnAkun;
        private Button btnSetting;
        private Panel panelPlayer;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
    }
}
