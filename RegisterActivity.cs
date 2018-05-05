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
using MailedMixers.Activities;
using SQLite;

namespace MailedMixers
{

    [Activity(Label = "Register", MainLauncher = false)]
    public class RegisterActivity : Activity
    {
        EditText txtFirstName;
        EditText txtLastName;
        EditText txtEmail;
        EditText txtPassword;
        EditText txtPasswordConfirm;
        EditText txtDateofBirth;
        Button btnRegister;
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
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);

            btnRegister.Click += BtnRegister_Click;

        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {

            //Check that password and confirm password match <Taken from Katie's Recommendr Project>
            if (txtPasswordConfirm.Text.Equals(txtPassword.Text) == false)
            {
                Toast.MakeText(this, "Password and Confirm Password do not match, please try again.", ToastLength.Short).Show();
                txtPasswordConfirm.Text = string.Empty;
                txtPassword.Text = string.Empty;
                return;
            }

            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<LoginTable>();
                LoginTable tbl = new LoginTable();
                tbl.firstName = txtFirstName.Text;
                tbl.lastName = txtLastName.Text;
                tbl.email = txtEmail.Text;
                tbl.password = txtPassword.Text;
                tbl.dateOfBirth = txtDateofBirth.Text;
                db.Insert(tbl);
                Toast.MakeText(this, "Account Created Successfully!,", ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }

            StartActivity(typeof(ShippingActivity));

        }
    }
}