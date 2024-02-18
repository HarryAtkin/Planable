using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Planable
{
    class Logged_in
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

        public bool getLoggedIn()
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
