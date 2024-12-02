using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using Driving_school_BusinessLayer;
using Driving_school_BusinessLayer.Utilities;
namespace Driving_School_Management_System.Forms
{
    public partial class LoginForm : Form
    {


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


        public LoginForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

    
        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private bool CheckInputs()
        {
            return !string.IsNullOrEmpty(txtbxPassword.Text) && !string.IsNullOrEmpty(txtbxUserName.Text); 
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if(!CheckInputs())
            {
                lblErr.ForeColor = Color.Salmon;
                return; 
            }

            clsUser CurrentUser = clsUser.GetUserInfosFromUserNamePassword(txtbxUserName.Text,clsHash.HashPassword(txtbxPassword.Text));
            if (CurrentUser is null)
            {
                lblErr.ForeColor = Color.Salmon;
                return;
            }

            Global.User = CurrentUser; 

            MainForm main = new MainForm();
            Hide();
            main.ShowDialog();
        }
    }
}
