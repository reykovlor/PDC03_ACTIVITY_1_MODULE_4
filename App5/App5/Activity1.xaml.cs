using Xamarin.Forms;

namespace App5
{
    public partial class Activity1 : ContentPage
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
        
                await DisplayAlert("Cats", "Hope you learned about cats!", "OK");

                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
