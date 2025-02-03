using DrivingSchool_DataAccessLayer.Statistics;
using System.Data;
namespace Driving_school_BusinessLayer
{
    public class StatisticsService
    {
        public static int GetSuccessRate() =>GeneralStatistics.GetSuccessRate();
        public static int GetTotalStudents() => GeneralStatistics.GetTotalStudents();
        public static int GetTotalInstructors() => GeneralStatistics.GetTotalInstructors();
        public static int GetTotalVehicles() => GeneralStatistics.GetTotalVehicles();
        public static int GetTotalUsers() => GeneralStatistics.GetTotalUsers();
        public static int GetTotalGroups() => GeneralStatistics.GetTotalGroups();
        public static int GetTotalExpenses() => GeneralStatistics.GetTotalExpenses();
        public static int GetTotalLessons() => GeneralStatistics.GetTotalLessons();
        public static int GetTotalExams() => GeneralStatistics.GetTotalExams();
        public static int GetTotalArchivedFiles() => GeneralStatistics.GetTotalArchivedFiles();
        public static int GetTotalFiles() => GeneralStatistics.GetTotalFiles();
        public static DataTable GetCandidateFilesByLicenseType() => DrivingTypesStatistics.GetCandidateFilesByLicenseType(); 
        //public decimal GetCurrentBalance() => GeneralStatistics.GetCurrentBalance();
    }

}
