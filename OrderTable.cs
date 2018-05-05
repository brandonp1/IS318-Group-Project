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
    class OrderTable
    {
        [PrimaryKey, AutoIncrement, Column("_OrderID")]
        public int orderid { get; set; }
        [MaxLength(25)]

        public string name { get; set; }
        public string billingAddress { get; set; }
        public string creditCardNum { get; set; }
        public string expirDate { get; set; }
        public string cvc { get; set; }
        public string shippingAddress { get; set; }
    }
}