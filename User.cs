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

namespace Test
{
    class User
    {
        //-----------------Properties---------------------
        private string username;
        public string UserName
        {
            get { return username; }
            set { username = value;  }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //----------------------Methods-----------------------
        public Boolean verifyPassword(String input)
        {
            if (input.Equals(password))
                return true;
            else
                return false;
        }

        public string verifyPassword()
        {
            return password;
        }
        public Boolean verifyUsername(String input)
        {
            if (input.Equals(username))
                return true;
            else
                return false;
        }

        public string verifyUsername()
        {
            return username;
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