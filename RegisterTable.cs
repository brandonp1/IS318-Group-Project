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
    class RegisterTable
    {
        [PrimaryKey, AutoIncrement, Column("_Email")]

        public string Email { get; set; }  

        [MaxLength(30)]

        public string FirstName { get; set; }

        [MaxLength(15)]

        public string LastName { get; set; }

        [MaxLength(15)]
        public string Password { get; set; }

        [MaxLength(15)]
        public string DateofBirth { get; set; }

        [MaxLength(10)]

}