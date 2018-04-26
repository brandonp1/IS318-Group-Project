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
    class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int recipeID { get; set; }

        public string recipeName { get; set; }

        public List<Ingredient> ingredientList = new List<Ingredient>();

        public double price { get; set; }

        public void addIngredient(Ingredient newItem)
        {
            ingredientList.Add(newItem);
        }

        public List<Ingredient> getIngredients()
        {
            return ingredientList;
        }

    }
}
