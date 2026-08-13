using System;
using DVLDBusinessLayer;

namespace DVLD
{
    public static class clsCurrentUser
    {

        public static int UserID { get; set; }
        public static int PersonID { get; set; }
        public static string UserName { set; get; }
        public static string Password { set; get; }
        public static bool IsActive { set; get; }
        public static int Permissions { set; get; }

    }
}
