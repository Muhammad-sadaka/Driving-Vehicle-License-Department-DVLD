using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplicationTypes
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ApplicationTypeID { set; get; }
        public string Title { set; get; }
        public float Fees { set; get; }

        public clsApplicationTypes()
        {
            this.ApplicationTypeID = -1;
            this.Title = "";
            this.Fees = -1;
            Mode = enMode.AddNew;
        }

        public clsApplicationTypes(int ApplicationTypeID, string Title, float Fees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.Title = Title;
            this.Fees = Fees;
            Mode = enMode.Update;
        }

        private bool _AddNewApplicationType()
        {
            //call DataAccess Layer 

            this.ApplicationTypeID = clsApplicationTypesDataAccess.AddNewApplicationType(this.Title, this.Fees);


            return (this.ApplicationTypeID != -1);
        }

        public static clsApplicationTypes FindByID(int ApplicationTypeID)
        {

            string Title = "";
            float Fees = -1;

            if (clsApplicationTypesDataAccess.GetApplicationInfoByApplicationTypeID(ApplicationTypeID, ref Title,
                ref Fees))
                return new clsApplicationTypes(ApplicationTypeID, Title, Fees);
            else
                return null;
        }

        private bool _UpdateTestType()
        {
            return clsApplicationTypesDataAccess.UpdateTestType(this.ApplicationTypeID, this.Title, this.Fees);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestType();

            }

            return false;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }



    }
}
