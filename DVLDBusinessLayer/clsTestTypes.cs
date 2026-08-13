using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestTypes
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public clsTestTypes.enTestType ID { set; get; }

        public string Title { set; get; }
        public string Description { set; get; }
        public float Fees { set; get; }

        public clsTestTypes()
        {
            this.ID = clsTestTypes.enTestType.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = -1;
            Mode = enMode.AddNew;
        }

        public clsTestTypes(clsTestTypes.enTestType ID, string Title,string Description,float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
            Mode = enMode.Update;
        }

        public static clsTestTypes FindByID(clsTestTypes.enTestType TestTypeID)
        {

            string Title = "", Description = "";
            float Fees = -1;

            if (clsTestTypesDataAccess.GetTestInfoByTestID((int)TestTypeID, ref Title, ref Description,
                ref Fees))
                return new clsTestTypes(TestTypeID, Title, Description, Fees);
            else
                return null;
        }

        private bool _AddNewTestType()
        {
            //call DataAccess Layer 

            this.ID = (clsTestTypes.enTestType)clsTestTypesDataAccess.AddNewTestType(this.Title, this.Description, this.Fees);

            return (this.Title != "");
        }

        private bool _UpdateTestType()
        {
            return clsTestTypesDataAccess.UpdateTestType((int)this.ID, this.Title,this.Description,this.Fees);
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
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

    }
}
