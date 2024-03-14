using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity5 : ContentPage
    {
        public Activity5()
        {
            InitializeComponent();
        }

        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1Text = fname.Text;
            string entry2Text = lname.Text;
            string entry3Text = email.Text;
            DisplayAlert("Enter Values", $"Firstname: {entry1Text}\n Lastname: {entry2Text}\n Email: {entry3Text}\n are you sure you want to submit", "Ok", "Cancel");
        }
    }
}
