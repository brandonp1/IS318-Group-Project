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
    class Cart
    {
        [PrimaryKey, AutoIncrement]
        public int cartID { get; set; }

        public DateTime orderDate { get; set; }

        public List<Recipe> recipeList = new List<Recipe>();

        public double orderTotal { get; set; }

        public string shippingStatus { get; set; }

        public void AddToCart(Recipe newItem)
        {
            recipeList.Add(newItem);
        }

        public void RemoveRecipe(Recipe item)
        {
            recipeList.Remove(item);
        }

        public List<Recipe> getRecipesInCart()
        {
            return recipeList;
        }

        public void calculateTotal()
        {
            orderTotal = 0;

            foreach(Recipe x in recipeList){
                orderTotal = orderTotal + x.price;
            }
        }
    }
}
