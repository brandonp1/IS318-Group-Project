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

namespace MailedMixers.Activities
{
    [Activity(Label = "ShippingActivity")]
    public class ShippingActivity : Activity
    {
        EditText txtName;
        EditText txtBAdress;
        EditText txtCreditNum;
        EditText txtCreditExpir;
        EditText txtCVC;
        CheckBox cbSame;
        EditText txtShippingAdr;
        Button btnSubmit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.Shipping);

            txtName = FindViewById<EditText>(Resource.Id.txtName);
            txtBAdress = FindViewById<EditText>(Resource.Id.txtBAddress);
            txtCreditNum = FindViewById<EditText>(Resource.Id.txtCreditNum);
            txtCreditExpir = FindViewById<EditText>(Resource.Id.txtCreditEpir);
            txtCVC = FindViewById<EditText>(Resource.Id.txtCVC);
            txtShippingAdr = FindViewById<EditText>(Resource.Id.txtShippingAdr);
            cbSame = FindViewById<CheckBox>(Resource.Id.cbSame);
            btnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);

            cbSame.CheckedChange += CbSame_CheckedChange;               

            btnSubmit.Click += BtnSubmit_Click;
        }

        private void CbSame_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (cbSame.Checked)
                txtShippingAdr.Text = txtBAdress.Text;
            else
                txtShippingAdr.Text = string.Empty;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(txtName.Text == string.Empty || txtBAdress.Text ==string.Empty || txtCreditNum.Text == string.Empty || 
                txtCreditExpir.Text == string.Empty || txtCVC.Text == string.Empty || txtShippingAdr.Text == string.Empty)
            {
                Toast.MakeText(this, "Missing Required Field", ToastLength.Short).Show();
                return;
            }

            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<OrderTable>();
                OrderTable tbl = new OrderTable();
                tbl.name = txtName.Text;
                tbl.billingAddress = txtBAdress.Text;
                tbl.creditCardNum = txtCreditNum.Text;
                tbl.expirDate = txtCreditExpir.Text;
                tbl.cvc = txtCVC.Text;
                tbl.shippingAddress = txtShippingAdr.Text;
                db.Insert(tbl);
                Toast.MakeText(this, "Order Submitted Successfully!", ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }

            StartActivity(typeof(LoginActivity));
        }
    }
}