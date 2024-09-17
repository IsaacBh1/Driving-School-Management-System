﻿using Driving_school_BusinessLayer;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Driving_School_Management_System.Forms
{
    public partial class AddExamForm : Form
    {

        //lblNotFoundStudent

        //----------------------------------------------------------------------------------
        //---------------------------this is for window properties ------------------------------
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
          );




        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        clsExam exam = null;
        StatusMessageForm statusMessageForm = null; 
        public AddExamForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsIDExists()
        {
            bool IsCondidateFileExists = false; 
            if (int.TryParse(txtboxID.Text , out int ID)) {

            IsCondidateFileExists = clsCondidateFile.IsCondidateFileExists(ID);
            if (!IsCondidateFileExists)
            {
                lblNotFoundStudent.Text = "ملف المرشح غير موجود"; 
            }

            }
            return IsCondidateFileExists;
        }


        private int GetExamType()
        {
            return rdobtnTheo.Checked ? 1 : 2;
        }

        private bool CheckExamInputs()
        {
            return !string.IsNullOrEmpty(txtboxID.Text) && !string.IsNullOrEmpty(CboxState.Text) && IsIDExists();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveExam(); 
        }
        private bool StoreExam()
        {
                exam = new clsExam()
                {
                    ExamTypeID = GetExamType(),
                    CandidateFileID = Convert.ToInt32(txtboxID.Text),
                    ExamDate = dateTimeExam.Value,
                    Result = Convert.ToInt32(numupdownResult.Text),
                    AdditionalNotes = txtboxAdditionalNotes.Text , 
                    Situation = CboxState.Text,
                    timeOfExam = new TimeSpan(Convert.ToInt32(numUpDwTimeHours.Value), Convert.ToInt32(numUpDwTimeMins.Value) , 0) 
                };
                return exam.Save(); 
        }


        private void SaveExam()
        {
            //CheckField( CBoxState,e)&&

            if (CheckExamInputs())
            {
                //this is the code to save on DB 
                if (StoreExam())
                {
                    // MessageBox.Show("student is saved successfully with ID = " + student.StudentID);
                    statusMessageForm = new StatusMessageForm("Exam Saved Successfully .");
                    statusMessageForm.ShowSuccess();
                    Close();
                }
                else
                {
                    statusMessageForm = new StatusMessageForm("Exam not Saved .");
                    statusMessageForm.ShowFailed();
                }
            }
            else
                MessageBox.Show("هناك معلومات مفقودة", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }
}