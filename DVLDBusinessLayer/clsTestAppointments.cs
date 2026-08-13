using System;
using System.Data;
using DVLDDataAccessLayer;
using DVLDDataAccess;

namespace DVLDBusinessLayer
{
    public class clsTestAppointments
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AppointmentID { set; get; }
        public clsTestTypes.enTestType TestTypeID { set; get; }
        public int LDLApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public clsApplications RetakeTestAppInfo { set; get; }

        public int TestID
        {
            get { return _GetTestID(); }

        }

        public clsTestAppointments()
        {
            this.AppointmentID = -1;
            this.TestTypeID = clsTestTypes.enTestType.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;
        }

        private clsTestAppointments(int AppointmentID, clsTestTypes.enTestType TestTypeID,int LDLApplicationID, DateTime AppointmentDate,float PaidFees,int CreatedByUserID,bool IsLocked,int RetakeTestApplicationID)
        {
            this.AppointmentID = AppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLApplicationID = LDLApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestAppInfo = clsApplications.FindBaseApplication(RetakeTestApplicationID);
            Mode = enMode.Update;
        }

        public static clsTestAppointments GetTestAppointmentInfoByID(int AppointmentID)
        {
            float PaidFees = -1;
            DateTime AppointmentDate = DateTime.Now;
            int LDLApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            bool IsLocked = false;
            int TestTypeID = -1;
            if (clsTestAppointmentsDataAccess.GetTestAppointmentInfoByID(AppointmentID, ref TestTypeID, ref LDLApplicationID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID,ref IsLocked,ref RetakeTestApplicationID))

                return new clsTestAppointments(AppointmentID, (clsTestTypes.enTestType)TestTypeID, LDLApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID,IsLocked, RetakeTestApplicationID);
            else
                return null;
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentsDataAccess.GetAllTestAppointments();

        }

        public DataTable GetAllAppointmentsForLDLApplicationIDAndTestType(clsTestTypes.enTestType TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetAllAppointmentsForLDLApplicationIDAndTestType(this.LDLApplicationID, (int)TestTypeID);

        }


        public static DataTable GetAllAppointmentsForLDLApplicationIDAndTestType(int LDLApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetAllAppointmentsForLDLApplicationIDAndTestType(LDLApplicationID, (int)TestTypeID);
        }

        public static clsTestAppointments GetLastTestAppointment(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)
        {
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointmentsDataAccess.GetLastTestAppointment(LocalDrivingLicenseApplicationID, (int)TestTypeID,
                ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }

        private bool _AddNewTestAppointment()
        {
            this.AppointmentID = clsTestAppointmentsDataAccess.AddNewTestAppointment((int)this.TestTypeID,this.LDLApplicationID,this.AppointmentDate,this.PaidFees,this.CreatedByUserID,this.RetakeTestApplicationID);
            return (this.AppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsDataAccess.UpdateTestAppointment(this.AppointmentID,(int)this.TestTypeID,this.LDLApplicationID,this.AppointmentDate,this.PaidFees,this.CreatedByUserID,this.IsLocked,this.RetakeTestApplicationID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestAppointment();
            }
            return false;
        }

        private int _GetTestID()
        {
            return clsTestAppointmentsDataAccess.GetTestID(AppointmentID);
        }

    }
}
