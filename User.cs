using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace MailedMixers
{
    class User
    {
        //-----------------Properties---------------------
        [PrimaryKey, AutoIncrement]
        public int UserID
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        
        public string FirstName
        {
            get;
            set;
        }
        
        public string LastName
        {
            get;
            set;
        }
        
        public DateTime Birthday
        {
            get;
            set;
        }
        
        public string Address
        {
            get;
            set;
        }
        
        public string City
        {
            get;
            set;
        }
        
        public string State
        {
            get;
            set;
        }
        
        public string PhoneNumber
        {
            get;
            set;
        }
        
        public string Email
        {
            get;
            set;
        }

        //----------------------Methods-----------------------
        public Boolean verifyPassword(String input)
        {
            if (input.Equals(Password))
                return true;
            else
                return false;
        }

        public string verifyPassword()
        {
            return Password;
        }
        public Boolean verifyUsername(String input)
        {
            if (input.Equals(UserName))
                return true;
            else
                return false;
        }

        public string verifyUsername()
        {
            return UserName;
        }

        public User login()
        {
            //functionality
            return this;
        }

        public void logout()
        {
            //functionality
        }
    }
}