using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsCountries
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; }

        public clsCountries()
        {
            this.CountryID = 0;
            this.CountryName = "";
        }
        public clsCountries(int CountryID,string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }
        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }

        public static clsCountries FindConuntryByID(int CountryID)
        {
            //return clsCountriesDataAccess.GetCountryInfoByID(CountryID);

            string CountryName = "";

            if (clsCountriesDataAccess.GetCountryInfoByID(CountryID, ref CountryName))

                return new clsCountries(CountryID, CountryName);
            else
                return null;

        }

        public static clsCountries FindConuntryByName(string CountryName)
        {
            int ID = -1;

            if (clsCountriesDataAccess.GetCountryInfoByName(CountryName, ref ID))

                return new clsCountries(ID,CountryName);
            else
                return null;

        }



    }
}
