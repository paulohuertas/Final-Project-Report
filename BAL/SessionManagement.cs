using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public static class SessionManagement
    {
        private static int _userId;
        private static string _username;
        private static string _password;

        public static string Username
        {
            get
            {
                return SessionManagement._username;
            }
            set
            {
                SessionManagement._username = value;
            }
        }

        public static string Password
        {
            get
            {
                return SessionManagement._password;
            }
            set
            {
                SessionManagement._password = value;
            }
        }

        public static int UserId
        {
            get
            {
                return SessionManagement._userId;
            }
            set
            {
                SessionManagement._userId = value;
            }
        }
    }

}
