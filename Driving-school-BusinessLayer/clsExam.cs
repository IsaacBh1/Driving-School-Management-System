﻿using DrivingSchool_DataAccessLayer;
using System;
using System.Data;

namespace Driving_school_BusinessLayer
{
    public class clsExam
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int ExamID { get; set; }
        public int ExamTypeID { get; set; }
        public int CandidateFileID { get; set; }
        public DateTime ExamDate { get; set; }
        public int? Result { get; set; }
        public string Situation { get; set; }
        public string AdditionalNotes { get; set; }
        public TimeSpan timeOfExam { get; set; }
        /*
            ExamID 
	        CondidateFileID 
	        ExamTypeID 
	        Result 
	        Situation 
	        DateOfExam  
	        AdditionalNotes 
	        timeOfExam 
         */

        public clsExam()
        {
            ExamID = -1;
            ExamTypeID = -1;
            CandidateFileID = -1;
            ExamDate = DateTime.MinValue;
            Result = 0;
            Mode = enMode.AddNew;
        }


        public static string GetExamType(int typeid)
        {
            return typeid == 1 ? "نظري" : "تطبيقي";
        }


        public static int GetNumberOfExamsPerDay(string day)
        {
            return clsExamDataAccess.GetNumberOfExamsPerDay(day); 
        }

        public static int GetExamType(string typeName)
        {
            return typeName == "نظري" ? 1 : 2;

        }
        private clsExam(int examID, int examTypeID, int candidateFileID, DateTime examDate, int result, string situation, string additionalNotes, TimeSpan timeOfExam)
        {
            ExamID = examID;
            ExamTypeID = examTypeID;
            CandidateFileID = candidateFileID;
            ExamDate = examDate;
            Result = result;
            Situation = situation;
            AdditionalNotes = additionalNotes;
            this.timeOfExam = timeOfExam;
            Mode = enMode.Update;
        }

        private bool _AddNewExam()
        {
            ExamID = clsExamDataAccess.AddNewExam(CandidateFileID, ExamTypeID, Result, Situation, ExamDate, AdditionalNotes, timeOfExam); 
            return ExamID != -1;
        }

        private bool _UpdateExam()
        {
            return clsExamDataAccess.UpdateExam(ExamID, CandidateFileID, ExamTypeID, Result, Situation, ExamDate, AdditionalNotes, timeOfExam);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewExam())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateExam();
            }
            return false;
        }

        public static clsExam Find(int ID)
        {
            int _ExamTypeID = -1;
            int _CandidateFileID = -1;
            DateTime _ExamDate = DateTime.MinValue;
            int _Result = 0;
            string _situation = "";
            string _AdditionalNotes = ""; 
            TimeSpan _time = TimeSpan.Zero;
            if (clsExamDataAccess.GetExamInfoByID(
                ID, ref _CandidateFileID,  ref _ExamTypeID, ref _Result, ref _situation ,ref _ExamDate,ref _AdditionalNotes,ref _time))
            {
                return new clsExam(ID, _ExamTypeID, _CandidateFileID, _ExamDate, _Result, _situation, _AdditionalNotes, _time); 

            }
            return null;
        }

        public static DataTable GetAllExamInformations()
            => clsExamDataAccess.GetAllExamInformations(); 
        
        public static DataTable GetExamsByID(int ID)
            => clsExamDataAccess.GetExamByID(ID);

        public static DataTable GetExamsByExamType(int ExamType)
            => clsExamDataAccess.GetExamsByExamType(ExamType);

        public static DataTable GetExamsByStatus(string status)
            => clsExamDataAccess.GetExamsByStatus(status);

        public static DataTable GetExamsByCondidateFile(int condidateFileID)
            => clsExamDataAccess.GetExamsByCondidateFile(condidateFileID); 


        public static  bool DeleteAllFileExamsByStudentID(int StudentID)
        {
            DataTable CondidateFiles =clsCondidateFileDataAccess.GetAllCondidateFilesByStudentID(StudentID);
            
            foreach(DataRow row in CondidateFiles.Rows)
                if (!clsExamDataAccess.DeleteExamByCondidatefile((int)row["CondidateFileID"])) return false; 
            
            return true; 
        }


        public static bool DeleteExam(int id)
        {
            return clsExamDataAccess.DeleteExam(id); 
        }

        public static bool DeleteExamByCondidatefile(int CondidateFileId) 
            =>clsExamDataAccess.DeleteExamByCondidatefile(CondidateFileId);

    }
}
