using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Planable
{
    class User_Logged_in
    {
        private bool loggedIn = false;
        private string? username = null;
        private string? password = null;

        public void logged_in(bool loggedIn, string username, string password)
        {
            this.loggedIn = loggedIn;
            this.username = username;
            this.password = password;
        }

        public bool get_is_logged_in()
        {
            return loggedIn;
        }

        public string getUsername()
        {
            if (username == null)
            {
                return "not logged in";
            }
            else
            {
                return username;
            }
            
        }

        //Should probable delete this method for security reasons
        public string getPassword()
        {
            if (password == null)
            {
                return "not logged in";
            }
            else
            {
                return password;
            }
        }
    }
}
