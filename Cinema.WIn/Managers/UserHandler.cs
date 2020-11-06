using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Win
{
    public static class UserHandler
    {
        private static UserModel _user = null;

        public static void SetCurrentUser(UserModel user)
        {
            _user = user;
        }

        public static Privilegies GetPrivilegies()
        {
            return _user.Privilege;
        }

        public static string GetUsername()
        {
            return _user.Username;
        }
    }
}
