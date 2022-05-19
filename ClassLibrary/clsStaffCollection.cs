using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();





        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }


        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;

            }
            set
            {
                mThisStaff = value;
            }
        }


        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectALL");
            PopulateArray(DB);

        }

        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@JoinDate", mThisStaff.JoinDate);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Available", mThisStaff.Available);
            return DB.Execute("sproc_tblStaff_Insert");




        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@JoinDate", mThisStaff.JoinDate);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Available", mThisStaff.Available);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffName(string StaffName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", StaffName);
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AnStaff.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Joindate"]);
                mStaffList.Add(AnStaff);
                Index++;
            }


        }
    } 
}