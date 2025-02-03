using Driving_school_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_School_Management_System.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            FillCandidateFilesByLicenseType(); 
            FillCountStatisticsInformations();
            InetializeMoneyBank(clsMoneyBank.Find(clsMoneyBank.GetCurrentMoneyBank()));
            InetializeExpencesAmount(clsExpense.GetAllExpensesStatistics());

        }
        private void FillCountStatisticsInformations() {
            numberOfStudentsLbl.Text = StatisticsService.GetTotalStudents().ToString(); 
            numberOfExamsLbl.Text = StatisticsService.GetTotalExams().ToString();
            numberOfCarsLbl.Text = StatisticsService.GetTotalVehicles().ToString();
            numberOfGroupsLbl.Text = StatisticsService.GetTotalGroups().ToString();
            numberOfInstructorsLbl.Text = StatisticsService.GetTotalInstructors().ToString();
            numberOfUsersLbl.Text = StatisticsService.GetTotalUsers().ToString();
            numberOfArchivedFilesLbl.Text = StatisticsService.GetTotalArchivedFiles().ToString();
            numberOfLessonsLbl.Text = StatisticsService.GetTotalLessons().ToString();
            numberOfFilesLbl.Text = StatisticsService.GetTotalFiles().ToString();
            percentageOfSuccessLbl.Text = StatisticsService.GetSuccessRate().ToString() + "%";
            num_files_lbl.Text = numberOfFilesLbl.Text; 
        }
        private void FillCandidateFilesByLicenseType()
        {
            Dock = DockStyle.Fill;
            chart1.Titles.Add("الملفات لكل رخصة سياقة");
            DataTable LicenceTypes = StatisticsService.GetCandidateFilesByLicenseType();
            chart1.Series[0].IsValueShownAsLabel = true;
            foreach (DataRow item in LicenceTypes.Rows)
                chart1.Series[0].Points.AddXY(item["Name"], item["Total"]);

        }

        private void InetializeMoneyBank(clsMoneyBank moneyBank)
        {
            //lblID.Text = moneyBank.MoneyBankID.ToString();
            lblFirstBalance.Text = moneyBank.InitialAmount.ToString("0.0") + " DA";
            if (moneyBank.InitialAmount <= moneyBank.InternalAmount)
                lblIncomes.Text = (moneyBank.InternalAmount - moneyBank.InitialAmount).ToString("0.0") + " DA";
            else
                lblIncomes.Text = "0 DA";

            lblExpences.Text = moneyBank.Expences.ToString("0.0") + " DA";
            lblExpences.Text = moneyBank.InternalAmount.ToString("0.0") + " DA";
        }


        private void InetializeExpencesAmount(DataTable ExpencesTypesStatistics)
        {
            foreach (DataRow item in ExpencesTypesStatistics.Rows)
            {
                pnlExpences.Controls.Add(new ExpensesBar(item["Name"].ToString(),Convert.ToDecimal(item["total"]),Convert.ToInt16(item["percentage"] ))); 
            }
        }




    }
}
