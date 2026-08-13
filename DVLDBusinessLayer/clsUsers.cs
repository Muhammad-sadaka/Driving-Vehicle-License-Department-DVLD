using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsUsers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public clsPeople PersonInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public int Permissions { set; get; }

        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            this.Permissions = -1;
            Mode = enMode.AddNew;
        }

        private clsUsers(int UserID, int PersonID, string UserName, string Password, bool IsActive,int Permissions)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPeople.FindByID(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Permissions = Permissions;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive,this.Permissions);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUsersDataAccess.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive,this.Permissions);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();
            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsersDataAccess.DeleteUser(UserID);
        }

        public static clsUsers GetUserInfoByID(int UserID)
        {

            string UserName = "", Password = "";
            int  Permissions = -1;
            int PersonID = -1;
            bool IsActive = false;
            bool IsFound = clsUsersDataAccess.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password,
                ref IsActive, ref Permissions);
            if (IsFound)
                return new clsUsers(UserID, PersonID, UserName,Password, IsActive, Permissions);
            else
                return null;
        }

        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserID = -1;
            int Permissions = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUsersDataAccess.GetUserInfoByPersonID
                                (PersonID, ref UserID, ref UserName, ref Password, ref IsActive,ref Permissions);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUsers(UserID, UserID, UserName, Password, IsActive, Permissions);
            else
                return null;
        }
        public static clsUsers FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            int Permissions = -1;
            bool IsActive = false;

            bool IsFound = clsUsersDataAccess.GetUserInfoByUsernameAndPassword
                                (UserName, Password, ref UserID, ref PersonID, ref IsActive,ref Permissions);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive, Permissions);
            else
                return null;
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUsersDataAccess.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUsersDataAccess.IsUserExist(UserName);
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUsersDataAccess.IsUserExistByPersonID(PersonID);
        }

    }
}
