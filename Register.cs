using System;
using System.Collections.Generic;
using System.IO;
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

    [Activity(Label = "Register", MainLauncher = true)]
    public class RegisterActivity : Activity
    {
        EditText txtFirstName;
        EditText txtLastName;
        EditText txtEmail;
        EditText txtPassword;
        EditText txtPasswordConfirm;
        EditText txtDateofBirth;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Register);

            txtFirstName = FindViewById<EditText>(Resource.Id.txtFirstName);
            txtLastName = FindViewById<EditText>(Resource.Id.txtLastName);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            txtPasswordConfirm = FindViewById<EditText>(Resource.Id.txtConfirmPassword);
            txtDateofBirth = FindViewById<EditText>(Resource.Id.txtDateofBirth);

            btnRegister.Click += BtnRegister_Click;

            private void BtnRegister_Click(object sender, EventArgs e)
            {
                try
                {
                    string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
                    var db = new SQLiteConnection(dpPath);
                    db.CreateTable<RegisterTable>();
                    RegisterTable tbl = new RegisterTable();
                    tbl.FirstName = txtFirstName.Text;
                    tbl.LastName = txtLastName.Text;
                    tbl.Email = txtEmail.Text;
                    tbl.Password = txtPassword.Text;
                    tbl.DateofBirth = txtDateofBirth.Text;
                    db.Insert(tbl);
                    Toast.MakeText(this, "Account Created Successfully!,", ToastLength.Short).Show();
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                }

            }
            
        }
    }
}