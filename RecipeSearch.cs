using Android.App;
using Android.Widget;
using Android.OS;
using System.IO;
using SQLite;
using Android.Views;

namespace MailedMixers
{
    [Activity(Label = "MailedMixers", MainLauncher = true)]
    public class RecipeSearch : Activity
    {
        string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");

        SearchView searchView;
        ListView lstView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            searchView = FindViewById<SearchView>(Resource.Id.searchView);
            lstView = FindViewById<ListView>(Resource.Id.lstView);

            //create recipe table and populate with recipes
            var db = new SQLiteConnection(dpPath);
            db.CreateTable<Recipe>();

            Recipe OldFashioned = new Recipe("Whiskey", "Sugar", "Bitters", "Orange Garnish");
            Recipe Martini = new Recipe("Gin", "Dry Vermouth", "Orange Bitters(Optional)");
            Recipe Margarita = new Recipe("Tequila", "Salt", "Cointreanu", "Lime Juice", "Lime Garnish");
            Recipe  WhiskeySour = new Recipe("Whiskey", "Sugar", "Lemon Juice");
            Recipe MoscowMule = new Recipe("Vodka", "Ginger Beer", "Lime Juice");
            Recipe Mimosa = new Recipe("Champagne", "Orange Juice");

            db.Insert(OldFashioned);
            db.Insert(Martini);
            db.Insert(Margarita);
            db.Insert(WhiskeySour);
            db.Insert(MoscowMule);
            db.Insert(Mimosa);
        
        }

          
  
    }
}

