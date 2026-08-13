using System;
using System.Data;
using DVLDDataAccessLayer;
using DVLDDataAccess;

namespace DVLDBusinessLayer
{
    public class clsPeople
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        { get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; } }
        public short Gender { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public clsCountries CountryInfo;
        public int NationalityCountryID { set; get; }
        public string NationalNo { set; get; }

        public clsPeople()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            this.NationalNo = "";
            this.Gender = 0;

            Mode = enMode.AddNew;

        }

        private clsPeople(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName,
            string Email, string Phone, string Address, DateTime DateOfBirth,
            int NationalityCountryID, string ImagePath, string NationalNo, short Gender)

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.NationalNo = NationalNo;
            this.Gender = Gender;
            this.CountryInfo = clsCountries.FindConuntryByID(NationalityCountryID);

            Mode = enMode.Update;
         }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.NationalNo, this.FirstName,
              this.SecondName, this.ThirdName, this.LastName, this.Gender, this.NationalityCountryID,
              this.Email, this.Phone, this.Address, this.DateOfBirth, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName,
                this.SecondName, this.ThirdName, this.LastName, this.Gender, this.NationalityCountryID,
               this.Email, this.Phone, this.Address, this.DateOfBirth, this.ImagePath);
        }

        public static clsPeople FindByID(int PersonID)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "",
                Address = "", ImagePath = "", NationalNo = "";
            short Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;

            bool IsFound = clsPeopleDataAccess.GetPersonInfoByPersonID(PersonID, ref NationalNo, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref Gender, ref NationalityCountryID,
                ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath);

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName,
                         Email, Phone, Address, DateOfBirth, NationalityCountryID, ImagePath, NationalNo, Gender);
            else
                return null;

        }

        public static clsPeople FindByNationalNo(string NationalNo)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "",
                Address = "", ImagePath = "";
            short Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            int PersonID = -1,NationalityCountryID = -1;

            bool IsFound = clsPeopleDataAccess.GetPersonInfoByNationalNo(ref PersonID, NationalNo, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref Gender, ref NationalityCountryID,
                ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath);
            if (IsFound)
                return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName,
                         Email, Phone, Address, DateOfBirth, NationalityCountryID, ImagePath, NationalNo, Gender);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();
            }
            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleDataAccess.DeletePerson(PersonID);
        }

        public static bool isPersonExist(int PersonID)
        {
            return clsPeopleDataAccess.IsPersonExist(PersonID);
        }

        public static bool isPersonExist(string NationalNo)
        {
            return clsPeopleDataAccess.IsPersonExist(NationalNo);
        }

    }

}
