﻿namespace Driving_School_Management_System.Forms
{
    partial class AddExamForm
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
            this.dateTimeExam = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdobtnApp = new System.Windows.Forms.RadioButton();
            this.rdobtnTheo = new System.Windows.Forms.RadioButton();
            this.chckLessonsType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotFoundStudent = new System.Windows.Forms.Label();
            this.txtboxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numupdownResult = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CboxState = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtboxAdditionalNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownResult)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeExam
            // 
            this.dateTimeExam.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeExam.Location = new System.Drawing.Point(126, 23);
            this.dateTimeExam.Name = "dateTimeExam";
            this.dateTimeExam.Size = new System.Drawing.Size(359, 27);
            this.dateTimeExam.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(580, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "التاريخ الامتحان\n";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.chckLessonsType);
            this.panel3.Location = new System.Drawing.Point(16, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 70);
            this.panel3.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdobtnApp);
            this.panel6.Controls.Add(this.rdobtnTheo);
            this.panel6.Location = new System.Drawing.Point(126, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(359, 65);
            this.panel6.TabIndex = 13;
            // 
            // rdobtnApp
            // 
            this.rdobtnApp.AutoSize = true;
            this.rdobtnApp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdobtnApp.Location = new System.Drawing.Point(59, 18);
            this.rdobtnApp.Name = "rdobtnApp";
            this.rdobtnApp.Size = new System.Drawing.Size(112, 33);
            this.rdobtnApp.TabIndex = 12;
            this.rdobtnApp.TabStop = true;
            this.rdobtnApp.Text = "تطبيقية";
            this.rdobtnApp.UseVisualStyleBackColor = true;
            // 
            // rdobtnTheo
            // 
            this.rdobtnTheo.AutoSize = true;
            this.rdobtnTheo.Checked = true;
            this.rdobtnTheo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdobtnTheo.Location = new System.Drawing.Point(195, 18);
            this.rdobtnTheo.Name = "rdobtnTheo";
            this.rdobtnTheo.Size = new System.Drawing.Size(93, 33);
            this.rdobtnTheo.TabIndex = 12;
            this.rdobtnTheo.TabStop = true;
            this.rdobtnTheo.Text = "نظرية";
            this.rdobtnTheo.UseVisualStyleBackColor = true;
            // 
            // chckLessonsType
            // 
            this.chckLessonsType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chckLessonsType.AutoSize = true;
            this.chckLessonsType.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLessonsType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chckLessonsType.Location = new System.Drawing.Point(682, 20);
            this.chckLessonsType.Name = "chckLessonsType";
            this.chckLessonsType.Size = new System.Drawing.Size(64, 31);
            this.chckLessonsType.TabIndex = 9;
            this.chckLessonsType.Text = "النوع";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblNotFoundStudent);
            this.panel1.Controls.Add(this.txtboxID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 76);
            this.panel1.TabIndex = 26;
            // 
            // lblNotFoundStudent
            // 
            this.lblNotFoundStudent.AutoSize = true;
            this.lblNotFoundStudent.ForeColor = System.Drawing.Color.Red;
            this.lblNotFoundStudent.Location = new System.Drawing.Point(303, 51);
            this.lblNotFoundStudent.Name = "lblNotFoundStudent";
            this.lblNotFoundStudent.Size = new System.Drawing.Size(34, 19);
            this.lblNotFoundStudent.TabIndex = 13;
            this.lblNotFoundStudent.Text = "     ";
            // 
            // txtboxID
            // 
            this.txtboxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxID.DefaultText = "";
            this.txtboxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxID.DisabledState.Parent = this.txtboxID;
            this.txtboxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxID.FocusedState.Parent = this.txtboxID;
            this.txtboxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxID.HoverState.Parent = this.txtboxID;
            this.txtboxID.Location = new System.Drawing.Point(126, 7);
            this.txtboxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.PasswordChar = '\0';
            this.txtboxID.PlaceholderText = "";
            this.txtboxID.SelectedText = "";
            this.txtboxID.ShadowDecoration.Parent = this.txtboxID;
            this.txtboxID.Size = new System.Drawing.Size(359, 40);
            this.txtboxID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(580, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(601, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = " معرف الملف";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 4;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(21, 571);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(126, 44);
            this.btnSubmit.TabIndex = 41;
            this.btnSubmit.Text = "التسجيل";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dateTimeExam);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(16, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 70);
            this.panel4.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(559, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Driving_School_Management_System.Properties.Resources.x_light;
            this.pictureBox1.Location = new System.Drawing.Point(21, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(-31, 59);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(891, 14);
            this.guna2Separator1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(644, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.label1.Size = new System.Drawing.Size(184, 51);
            this.label1.TabIndex = 37;
            this.label1.Text = "أضف امتحان";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(790, 475);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.numupdownResult);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(16, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 70);
            this.panel2.TabIndex = 27;
            // 
            // numupdownResult
            // 
            this.numupdownResult.Location = new System.Drawing.Point(134, 21);
            this.numupdownResult.Name = "numupdownResult";
            this.numupdownResult.Size = new System.Drawing.Size(358, 27);
            this.numupdownResult.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(682, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = " نتائج";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.CboxState);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(16, 313);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(771, 70);
            this.panel5.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Salmon;
            this.label8.Location = new System.Drawing.Point(650, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // CboxState
            // 
            this.CboxState.BackColor = System.Drawing.Color.Transparent;
            this.CboxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxState.FocusedColor = System.Drawing.Color.Empty;
            this.CboxState.FocusedState.Parent = this.CboxState;
            this.CboxState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CboxState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CboxState.FormattingEnabled = true;
            this.CboxState.HoverState.Parent = this.CboxState;
            this.CboxState.ItemHeight = 30;
            this.CboxState.Items.AddRange(new object[] {
            "مبرمج",
            "ناجح",
            "راسب"});
            this.CboxState.ItemsAppearance.Parent = this.CboxState;
            this.CboxState.Location = new System.Drawing.Point(134, 21);
            this.CboxState.Name = "CboxState";
            this.CboxState.ShadowDecoration.Parent = this.CboxState;
            this.CboxState.Size = new System.Drawing.Size(358, 36);
            this.CboxState.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(670, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = " الحالة";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.txtboxAdditionalNotes);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(16, 389);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(771, 70);
            this.panel8.TabIndex = 32;
            // 
            // txtboxAdditionalNotes
            // 
            this.txtboxAdditionalNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxAdditionalNotes.DefaultText = "";
            this.txtboxAdditionalNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxAdditionalNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxAdditionalNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxAdditionalNotes.DisabledState.Parent = this.txtboxAdditionalNotes;
            this.txtboxAdditionalNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxAdditionalNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxAdditionalNotes.FocusedState.Parent = this.txtboxAdditionalNotes;
            this.txtboxAdditionalNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxAdditionalNotes.HoverState.Parent = this.txtboxAdditionalNotes;
            this.txtboxAdditionalNotes.Location = new System.Drawing.Point(134, 15);
            this.txtboxAdditionalNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxAdditionalNotes.Name = "txtboxAdditionalNotes";
            this.txtboxAdditionalNotes.PasswordChar = '\0';
            this.txtboxAdditionalNotes.PlaceholderText = "";
            this.txtboxAdditionalNotes.SelectedText = "";
            this.txtboxAdditionalNotes.ShadowDecoration.Parent = this.txtboxAdditionalNotes;
            this.txtboxAdditionalNotes.Size = new System.Drawing.Size(359, 40);
            this.txtboxAdditionalNotes.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(559, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = " ملاحظات إضافية";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.BorderRadius = 4;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(161, 571);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(126, 44);
            this.guna2Button2.TabIndex = 42;
            this.guna2Button2.Text = "اغلاق";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // AddExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(828, 631);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExamForm";
            this.Text = "AddExamForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownResult)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeExam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdobtnApp;
        private System.Windows.Forms.RadioButton rdobtnTheo;
        private System.Windows.Forms.Label chckLessonsType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txtboxID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numupdownResult;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox CboxState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox txtboxAdditionalNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNotFoundStudent;
    }
}