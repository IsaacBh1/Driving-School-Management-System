using System;
using System.Data.SqlClient;

namespace DrivingSchool_DataAccessLayer.Statistics
{
    public class GeneralStatistics
    {
        private static string ConnectionString = clsConnectionStr.ConnectionStr;
        public static int GetCount(string tableName)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = $"SELECT COUNT(*) FROM {tableName};";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return count;
        }

        public static int GetTotalStudents() => GetCount("Students");
        public static int GetTotalInstructors() => GetCount("Instructors");
        public static int GetTotalVehicles() => GetCount("vehicles");
        public static int GetTotalUsers() => GetCount("Users");
        public static int GetTotalGroups() => GetCount("Groups");
        public static int GetTotalExpenses() => GetCount("Expenses");
        public static int GetTotalLessons() => GetCount("Lessons");
        public static int GetTotalExams() => GetCount("Exams");
        public static int GetTotalArchivedFiles() => GetCount("CondidateFiles WHERE IsArchived = 1");
        public static int GetTotalFiles() => GetCount("CondidateFiles");


        public static int GetSuccessRate()
        {
            int successRate = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT " +
                               "(SELECT COUNT(*) FROM Exams WHERE Situation = 'ناجح')" +
                               " * 100.0 / " +
                               "(SELECT COUNT(*) FROM Exams Where Situation != 'مبرمج') AS SuccessRate";

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        successRate = Convert.ToInt16(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return successRate;
        }


    }
}
