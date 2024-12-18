﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Driving_school_BusinessLayer; 
namespace Driving_School_Management_System.Forms
{
    public partial class AddCondidateFileForm : Form
    {
        //----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------

        //constructor
        public AddCondidateFileForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _initializeFormCboxes();
            GetDrivingLicensePrice(CbxDrivingLicenseType.Text);
            changeDrivingLicenseEvent(CbxDrivingLicenseType, null); 
        }



        public AddCondidateFileForm(int studentId)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _initializeFormCboxes();
            GetDrivingLicensePrice(CbxDrivingLicenseType.Text);
            txtbxCondidateID.Text = studentId.ToString();
            txtbxIdentityNumber.Text = GetStudentIdentityNumberfromID(studentId);
            txtbxCondidateID.Enabled = false;
            txtbxIdentityNumber.Enabled = false; 
        }



        public AddCondidateFileForm(int fileId , bool IsFile = false)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _initializeFormCboxes();
            GetDrivingLicensePrice(CbxDrivingLicenseType.Text);
            changeDrivingLicenseEvent(CbxDrivingLicenseType, null);
            condidateFile = clsCondidateFile.Find(fileId);
            InetializeFileOnUpdate(condidateFile);
            if (condidateFile != null)
            {
                payment = clsPayment.Find(condidateFile.PaymentID);

            }
        }


        private void InetializeFileOnUpdate(clsCondidateFile condidateFile)
        {
            if (!(condidateFile is null))
            {
                txtbxCondidateID.Text = condidateFile.StudentID.ToString();
                txtbxIdentityNumber.Text = condidateFile.Student.NationalCard.CardNumber;
                txtbxCondidateID.Enabled = false; 
                txtbxIdentityNumber.Enabled = false;
                CbxDrivingLicenseType.Text = condidateFile.drivingLicenseType.Name;
                CbxGroup.Text = condidateFile.Group.Name;
                txtBoxAdditionalNotes.Text = condidateFile.AdditionalNotes;
                txtbxPrice.Value = condidateFile.Payment.FullAmount;
                txtbxAmountPayed.Value = condidateFile.Payment.AmountPayed;
                txtbxRest.Text = (txtbxPrice.Value - txtbxAmountPayed.Value).ToString();
                txtbxRest.Enabled= false;
               /* CboxAppInsructor.Text = condidateFile.ApplicationInstructor.UserName;
                CboxTheoInsructor.Text = condidateFile.TheoreticalInstructor.UserName; */
            }
        }








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

        //----------------------------------------------------------------------------------
        //----------------------this is for closing the window-------------------------------

        private void pictureBox1_Click(object sender, EventArgs e) => Close();
        private void guna2Button2_Click(object sender, EventArgs e) => Close();

        //----------------------------------------------------------------------------------
        //------this is for searching the student by his id or his Identity number----------

        private int GetStudentIDfromIdentityNumber(string IdentityNumber)
        {
            return clsStudent.GetStudentIDByIdentityNumber(IdentityNumber); 
        }
        private string GetStudentIdentityNumberfromID(int ID)
        {
            return clsStudent.GetStudentIdentityNumberByID(ID);
        }
        //----------------------------------------------------------------------------------
        //----------------------this is for getting all IDs and infos in the form --------------------

        private int GetIDOfIndructor(string UserName)
        {
            return clsInstructor.GetInstructorIDByUserName(UserName); 
        }
        private int GetIDOfVehicleFromVehicleName(string VehicleName)
        {
            return clsVehicle.GetVehicleIDByVehicleName(VehicleName);  
        }
        private int GetIDOfDrivingLicenseTypeFromName(string Name)
        {
            return clsDrivingLicenseType.GetDrivingLicenseTypeIDByName(Name);
        }

        private decimal GetDrivingLicensePrice(string Name)
        {
            return clsDrivingLicenseType.GetDrivingLicenseTypePriceByID(GetIDOfDrivingLicenseTypeFromName(Name)); 
        }
        private int GetGruopIDFromName(string Name)
        {
            return clsGroup.GetGroupIDbyName(Name);
        }


        //----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------



        private bool InformationCorrect = true;
        private StatusMessageForm statusMessageForm;
        private clsCondidateFile condidateFile = new clsCondidateFile();
        private clsPayment payment = new clsPayment();
        private clsBatch batch = new clsBatch();
        public delegate void AddNewCondidateFile();
        public event AddNewCondidateFile OnCondidateFileAddedEventHundler;
        public clsMoneyBank moneyBank = new clsMoneyBank(); 

        //----------------------------------------------------------------------------------
        //----------------this is for inetialize comboboxes of the form----------------------

        private void _initializeDrivingLicenseTypeCbox()
        {
            CbxDrivingLicenseType.DataSource = clsDrivingLicenseType.GetAllNames().DefaultView;
            CbxDrivingLicenseType.DisplayMember = "Name";
        }

        //GetAllGroupsNames()
        private void _initializeGroupsCbox()
        {
            CbxGroup.DataSource = clsGroup.GetAllGroupsNames().DefaultView;
            CbxGroup.DisplayMember = "Name";
        }

        private void _initializeInstructorsCbox()
        {
            CboxAppInsructor.DataSource = clsInstructor.GatAllInsructorsUserName().DefaultView;
            CboxAppInsructor.DisplayMember = "UserName";
            CboxTheoInsructor.DataSource = clsInstructor.GatAllInsructorsUserName().DefaultView;
            CboxTheoInsructor.DisplayMember = "UserName";
        }
       /* private void _initializeVehicleCbox()
        {
          CboxVehicle.DataSource =clsVehicle.GetAllVehiclesNames().DefaultView;
          CboxVehicle.DisplayMember = "Name";

        }*/
        private void _initializeFormCboxes()
        {
            _initializeDrivingLicenseTypeCbox();
            _initializeGroupsCbox();
            _initializeInstructorsCbox();
            //_initializeVehicleCbox();
        }
     
        //----------------------------------------------------------------------------------
        //--------------------ths is for checking if all required field is exist-----------

        public void CheckField(Control txtBoxField)
        {
            if (txtBoxField is Guna.UI2.WinForms.Guna2TextBox GunatextBox)
            {
                GunatextBox.BorderColor = string.IsNullOrEmpty(GunatextBox.Text) ? Color.IndianRed : Color.White;
                InformationCorrect = !string.IsNullOrEmpty(GunatextBox.Text) && InformationCorrect;

            }
            else if(txtBoxField is NumericUpDown NumInput)
            {
                NumInput.BackColor = string.IsNullOrEmpty(NumInput.Text) ? Color.Gray : Color.White;
                InformationCorrect = !string.IsNullOrEmpty(NumInput.Text) && InformationCorrect;
            }
            else if (txtBoxField is MetroFramework.Controls.MetroComboBox MetroInput)
            {
                MetroInput.BackColor = string.IsNullOrEmpty(MetroInput.Text) ? Color.Gray : Color.White;
                InformationCorrect = !string.IsNullOrEmpty(MetroInput.Text) && InformationCorrect;

            }
        }
        public void CheckCondidatesFileInformations()
        {
            InformationCorrect = true; 
            CheckField(txtbxCondidateID); 
            CheckField(txtbxIdentityNumber); 
            CheckField(txtbxPrice); 
            CheckField(CbxDrivingLicenseType); 
            CheckField(CbxGroup); 
        }


        //----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------


        private bool _SaveCondidatesFile()
        {

            if (int.TryParse (txtbxCondidateID.Text , out int studentID))
            {
                payment.AmountPayed = Convert.ToDecimal(txtbxAmountPayed.Text);
                payment.FullAmount = Convert.ToDecimal(txtbxPrice.Text);
                payment.MoneyBankID = clsMoneyBank.GetCurrentMoneyBank();
                moneyBank = clsMoneyBank.Find(clsMoneyBank.GetCurrentMoneyBank());
                moneyBank.AddPayment(txtbxAmountPayed.Value);
                if (payment.AmountPayed < 0 || !payment.Save()) return false;
                if(payment.AmountPayed > 0)
                {
                    batch.PaymentID = payment.PaymentID;
                    batch.Price = payment.AmountPayed;
                    batch.PaymentDate = DateTime.Now; 
                    
                    batch.Save();
                }
                condidateFile.StudentID = studentID;
                condidateFile.DrivingLicenseTypeID = GetIDOfDrivingLicenseTypeFromName(CbxDrivingLicenseType.Text); 
                condidateFile.AdditionalNotes = txtBoxAdditionalNotes.Text;
                condidateFile.IsActive = true;
                condidateFile.CreatingFileDate = DateTime.Now;
                condidateFile.IsArchived = false;
                condidateFile.PaymentID = payment.PaymentID;
                condidateFile.GroupID = GetGruopIDFromName(CbxGroup.Text);
                condidateFile.ApplicationInstructorID = GetIDOfIndructor(CboxAppInsructor.Text); 
                condidateFile.TheoreticalInstructorID = GetIDOfIndructor(CboxTheoInsructor.Text);
                return moneyBank.Save() && condidateFile.Save() ; 

            }                     

            return false; 
        }


        private void SaveFile()
        {
            CheckCondidatesFileInformations();
            if (InformationCorrect)
            {
                //this is the code to save on DB 
                if (_SaveCondidatesFile())
                {
                    // MessageBox.Show("student is saved successfully with ID = " + student.StudentID);
                    statusMessageForm = new StatusMessageForm("File Saved Successfully");
                    statusMessageForm.ShowSuccess();
                    OnCondidateFileAddedEventHundler?.Invoke();
                    Close();
                }
                else
                {
                    statusMessageForm = new StatusMessageForm("File not Saved");
                    statusMessageForm.ShowFailed();
                }
            }
            else
                MessageBox.Show("هناك معلومات مفقودة", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveFile(); 

        }

        private void IDChangedEvent(object sender, EventArgs e)
        {
            if (int.TryParse(txtbxCondidateID.Text, out int ID)) {
                txtbxIdentityNumber.Text = GetStudentIdentityNumberfromID(ID); 
            }; 
        }

        private void IdentityNumberChangedEvent(object sender, EventArgs e)
        {
            int ID = GetStudentIDfromIdentityNumber(txtbxIdentityNumber.Text);
            if (ID > 0) txtbxCondidateID.Text = ID.ToString();
            else txtbxCondidateID.Text = ""; 


        }

        private void changeDrivingLicenseEvent(object sender, EventArgs e)
        {
            txtbxPrice.Text = GetDrivingLicensePrice(CbxDrivingLicenseType.Text).ToString(); 
        }

        private void txtbxAmountPayed_ValueChanged(object sender, EventArgs e)
        {
            if (txtbxPrice.Value >= txtbxAmountPayed.Value)
                txtbxRest.Text = (txtbxPrice.Value - txtbxAmountPayed.Value).ToString(); 
        }
    }
}
