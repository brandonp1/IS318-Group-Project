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
    class LoginTable
    {
        [PrimaryKey, AutoIncrement, Column("_UserID")]
        public int userid { get; set; }
        [MaxLength(25)]
        public string email { get; set; }
        [MaxLength(30)]
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }

    }
}