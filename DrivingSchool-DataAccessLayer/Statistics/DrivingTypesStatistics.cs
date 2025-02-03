using System.Data.SqlClient;
using System.Data;
using System;

namespace DrivingSchool_DataAccessLayer.Statistics
{
    public class DrivingTypesStatistics
    {
        private static string ConnectionString = clsConnectionStr.ConnectionStr;

        public static DataTable GetCandidateFilesByLicenseType()
        {
            DataTable candidateFiles = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT dl.Name, COUNT(*) AS Total FROM [dbo].[CondidateFiles] cf JOIN [dbo].[DrivingLicenseTypes] dl ON cf.DrivingLicenseTypeID = dl.[DrivingLiceseTypeID] GROUP BY dl.Name;";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        candidateFiles.Load(reader);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return candidateFiles;
        }



    }
}
