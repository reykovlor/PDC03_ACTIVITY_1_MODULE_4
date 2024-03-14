using System;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ActivityButton_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var buttonText = button.Text;

            switch (buttonText)
            {
                case "List Array":
                    await Navigation.PushAsync(new Activity1() { Title = buttonText });
                    break;
                case "Text Cell":
                    await Navigation.PushAsync(new Activity2() { Title = buttonText });
                    break;
                case "Image Cell":
                    await Navigation.PushAsync(new Activity3() { Title = buttonText });
                    break;
                case "Switch Cell":
                    await Navigation.PushAsync(new Activity4() { Title = buttonText });
                    break;
                case "Entry Cell":
                    await Navigation.PushAsync(new Activity5() { Title = buttonText });
                    break;
                 case "Collection View":
                    await Navigation.PushAsync(new Activity6() { Title = buttonText });
                    break;
                default:
                    break;
            }
        }
    }
}
