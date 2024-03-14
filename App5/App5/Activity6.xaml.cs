using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App5
{
    public partial class Activity6 : ContentPage
    {
        public ObservableCollection<Saiyan> Saiyans { get; set; }

        public Activity6()
        {
            InitializeComponent();

            Saiyans = new ObservableCollection<Saiyan>()
            {
                new Saiyan { Name = "Goku", PowerLevel = "Over 90000000000", ImageUrl = "https://wallpapersmug.com/download/1024x768/01e666/Ultra-Instinct-Dragon_Ball-goku.jpg" },
                new Saiyan { Name = "Vegeta", PowerLevel = "Over 900000000000", ImageUrl = "https://static1.thegamerimages.com/wordpress/wp-content/uploads/2017/12/Vegeta-blue.jpg" },
               
            };

            BindingContext = this;
        }
    }

    public class Saiyan
    {
        public string Name { get; set; }
        public string PowerLevel { get; set; }
        public string ImageUrl { get; set; }
    }
}
