﻿namespace Driving_School_Management_System.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtbxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Animated = true;
            this.txtbxUserName.BorderRadius = 20;
            this.txtbxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxUserName.DefaultText = "";
            this.txtbxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUserName.DisabledState.Parent = this.txtbxUserName;
            this.txtbxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUserName.FocusedState.Parent = this.txtbxUserName;
            this.txtbxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUserName.HoverState.Parent = this.txtbxUserName;
            this.txtbxUserName.Location = new System.Drawing.Point(596, 135);
            this.txtbxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.PasswordChar = '\0';
            this.txtbxUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtbxUserName.PlaceholderText = "";
            this.txtbxUserName.SelectedText = "";
            this.txtbxUserName.ShadowDecoration.Parent = this.txtbxUserName;
            this.txtbxUserName.Size = new System.Drawing.Size(374, 50);
            this.txtbxUserName.TabIndex = 13;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Animated = true;
            this.txtbxPassword.BorderRadius = 20;
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.DefaultText = "";
            this.txtbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.DisabledState.Parent = this.txtbxPassword;
            this.txtbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.FocusedState.Parent = this.txtbxPassword;
            this.txtbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.HoverState.Parent = this.txtbxPassword;
            this.txtbxPassword.Location = new System.Drawing.Point(596, 243);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtbxPassword.PlaceholderText = "";
            this.txtbxPassword.SelectedText = "";
            this.txtbxPassword.ShadowDecoration.Parent = this.txtbxPassword;
            this.txtbxPassword.Size = new System.Drawing.Size(374, 50);
            this.txtbxPassword.TabIndex = 13;
            this.txtbxPassword.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(827, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(868, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "كلمة المرور";
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 20;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Location = new System.Drawing.Point(596, 337);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.Size = new System.Drawing.Size(374, 50);
            this.btnlogin.TabIndex = 42;
            this.btnlogin.Text = "تسجيل الدخول";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.BackColor = System.Drawing.Color.Transparent;
            this.lblErr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblErr.Location = new System.Drawing.Point(808, 302);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(150, 19);
            this.lblErr.TabIndex = 43;
            this.lblErr.Text = "هناك معلومات خاطئة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(821, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 48);
            this.label4.TabIndex = 44;
            this.label4.Text = "مرحبا بك";
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = global::Driving_School_Management_System.Properties.Resources.minus;
            this.minimize.Location = new System.Drawing.Point(43, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(22, 23);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 1;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::Driving_School_Management_System.Properties.Resources.x__3_;
            this.close.Location = new System.Drawing.Point(15, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Driving_School_Management_System.Properties.Resources.DrivoLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUserName);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private Guna.UI2.WinForms.Guna2TextBox txtbxUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Label label4;
    }
}