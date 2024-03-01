using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planable
{
    class User
    {
        private string? email;
        private string? username;
        private string? password;
        private string? dob;
        private double budget;



        public void user(string email, string username, string password, string dob)
        {
            this.email = email;
            this.username = username;
            this.password = password;
            this.dob = dob;
        }
        public void changeEmail(string email)
        {
            this.email = email;
        }
        public void changePassword(string password)
        {
            this.password = password;
        }
        public void changeUsername(string username)
        {
            this.username = username;
        }
        public string getEmail()
        {
            return email;
        }
        public string getUsername()
        {
            return username;
        }
        public string getDOB()
        {
            return dob;
        }
        public virtual bool checkAdmin()
        {
            return false;
        }

        public void user_data()
        {

        }

    }



    class Admin_User : User
    {
        private string? admin_username;
        private string? admin_password;

        public void admin_user(string email, string dob, string admin_username, string admin_password)
        {
            this.admin_username = admin_username;
            this.admin_password = admin_password;
            user(email, admin_username, admin_password, dob);
            this.admin_username = admin_username;
            this.admin_password = admin_password;
        }
        public override bool checkAdmin()
        {
            return true;
        }
    }
}
