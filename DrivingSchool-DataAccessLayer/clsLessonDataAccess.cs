﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DrivingSchool_DataAccessLayer
{
    public sealed class clsLessonDataAccess
    {
        private static string ConnectionString = clsConnectionStr.ConnectionStr;

        public static DataTable GetAllLessons()
        {
            DataTable lessons = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select * from Lessons order by LessonID desc; ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    lessons.Load(reader);
                }
                reader.Close();
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
            return lessons;
        }

        public static bool GetLessonInfoByID(int lessonID, ref string type, ref DateTime dateOfLessons, ref TimeSpan timeOfLesson, ref int durationHours, ref int durationMin, ref int instructor , ref int GroupID)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string query = "select * from Lessons where LessonID = @lessonID";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@lessonID", lessonID);
            bool isFound = false;
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;
                    type = (string)reader["Type"];
                    dateOfLessons = (DateTime)reader["DateOfLessons"];
                    timeOfLesson = (TimeSpan)reader["TimeOfLesson"];
                    durationHours = (int)reader["DurationHours"];
                    durationMin = (int)reader["DurationMin"];
                    instructor = (int)reader["Instructor"];
                    GroupID = (int)reader["GroupID"];
                }
                reader.Close();
                return isFound;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static int AddNewLesson(string type, DateTime dateOfLessons, TimeSpan timeOfLesson, int durationHours, int durationMin, int GroupID, int instructor)
        {
            int id = -1;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string query = "insert into Lessons (Type, DateOfLessons, TimeOfLesson, DurationHours, DurationMin, Instructor , GroupID) Values (@Type, @DateOfLessons, @TimeOfLesson, @DurationHours, @DurationMin, @Instructor , @GroupID);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@DateOfLessons", dateOfLessons);
            command.Parameters.AddWithValue("@TimeOfLesson", timeOfLesson);
            command.Parameters.AddWithValue("@DurationHours", durationHours);
            command.Parameters.AddWithValue("@DurationMin", durationMin);
            command.Parameters.AddWithValue("@GroupID", GroupID);
            command.Parameters.AddWithValue("@Instructor", instructor);
            try
            {
                sqlConnection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    id = ID;
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return id;
        }

        public static bool UpdateLesson(int lessonID, string type, DateTime dateOfLessons, TimeSpan timeOfLesson, int durationHours, int durationMin, int instructor, int GroupID)
        {
            int affectedRows = 0;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string query = "UPDATE [dbo].[Lessons] SET " +
                "Type = @Type," +
                "DateOfLessons = @DateOfLessons," +
                "TimeOfLesson = @TimeOfLesson," +
                "DurationHours = @DurationHours," +
                "DurationMin = @DurationMin," +
                "GroupID = @GroupID," +
                "Instructor = @Instructor" +
                " WHERE LessonID = @lessonID";
            
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@lessonID", lessonID);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@DateOfLessons", dateOfLessons);
            command.Parameters.AddWithValue("@TimeOfLesson", timeOfLesson);
            command.Parameters.AddWithValue("@DurationHours", durationHours);
            command.Parameters.AddWithValue("@DurationMin", durationMin);
            command.Parameters.AddWithValue("@GroupID", GroupID);
            command.Parameters.AddWithValue("@Instructor", instructor);
            try
            {
                sqlConnection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return (affectedRows != 0);
        }

        public static bool DeleteLesson(int id)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "DELETE FROM Lessons WHERE LessonID = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                int affectedRows = 0;
                connection.Open();
                affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0) result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static bool IsLessonExist(int id)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select Found = 1 from Lessons where LessonID = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                result = sqlDataReader.HasRows;
                sqlDataReader.Close();
            }
            catch { result = false; }
            finally { connection.Close(); }
            return result;
        }

        public static int GetLessonIDByInfo(string type, DateTime dateOfLessons, TimeSpan timeOfLesson, int durationHours, int durationMin, int condidateFileID, int instructor)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select LessonID from Lessons where " +
                "Type = @Type and " +
                "DateOfLessons = @DateOfLessons and " +
                "TimeOfLesson = @TimeOfLesson and " +
                "DurationHours = @DurationHours and " +
                "DurationMin = @DurationMin and " +
                "CondidateFileID = @CondidateFileID and " +
                "Instructor = @Instructor";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@DateOfLessons", dateOfLessons);
            command.Parameters.AddWithValue("@TimeOfLesson", timeOfLesson);
            command.Parameters.AddWithValue("@DurationHours", durationHours);
            command.Parameters.AddWithValue("@DurationMin", durationMin);
            command.Parameters.AddWithValue("@CondidateFileID", condidateFileID);
            command.Parameters.AddWithValue("@Instructor", instructor);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = (int)reader["LessonID"];
                    }
                }
                reader.Close();
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
            return id;
        }


        public static int GetNumberOfLessonsPerDay(string day)
        {
            int Numberoflessons = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select count(*)as NumberOfLessons from Lessons where DateOfLessons like '"+day+"';"; 

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Numberoflessons = (int)reader["NumberOfLessons"];
                    }
                }
                reader.Close();
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
            return Numberoflessons;

        }

        public static bool IsLessonExist(string type, DateTime dateOfLessons, TimeSpan timeOfLesson, int durationHours, int durationMin, int condidateFileID, int instructor)
        {
            return (GetLessonIDByInfo(type, dateOfLessons, timeOfLesson, durationHours, durationMin, condidateFileID, instructor) != -1);
        }

        public static bool GetLessonInfoByID(int iD, ref int candidateFileID, ref DateTime lessonDate, ref string notes, ref int applicationInstructorID, ref bool isCompleted)
        {
            throw new NotImplementedException();
        }

        public static DataTable SearchLessonByID(int ID)
        {
            DataTable lessons = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select * from Lessons where  LessonID = @ID; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID" , ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    lessons.Load(reader);
                }
                reader.Close();
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
            return lessons;
        }
        public static DataTable SearchLessonByLessonType(string Type)
        {
            DataTable lessons = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "select * from Lessons where Type = @type;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@type", Type);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    lessons.Load(reader);
                }
                reader.Close();
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
            return lessons;
        }

        public static DataTable SearchLessonByGroup(string group)
        {
            DataTable lessons = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = @"select 
                             Lessons.*
                             from Lessons 
                             inner join Groups On Lessons.GroupID = Groups.GroupID 
                             where Groups.Name = @group ; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@group", group);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    lessons.Load(reader);
                }
                reader.Close();
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
            return lessons;
        }







    }

}
