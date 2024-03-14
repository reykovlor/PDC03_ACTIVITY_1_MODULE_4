using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Activity2()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Son Goku", Position = "Saiyan Warrior", Image = "https://www.pngall.com/wp-content/uploads/13/Goku-PNG-Picture.png" });
            employees.Add(new Employee { DisplayName = "Vegeta", Position = "Prince of Saiyans", Image = "" });
            employees.Add(new Employee { DisplayName = "Piccolo", Position = "Namekian Warrior", Image = "" });
            employees.Add(new Employee { DisplayName = "Bulma", Position = "Scientist", Image = "" });
            employees.Add(new Employee { DisplayName = "Gohan", Position = "Scholar and Warrior", Image = "" });
        }

        public void Menu_Delete(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var employee = menuItem?.BindingContext as Employee;
            if (employee != null)
            {
                DisplayAlert("Delete", $"Delete {employee.DisplayName} - {employee.Position}?", "Yes", "No");
            }
        }

        public void Menu_More(object sender, EventArgs e)
        {
            DisplayAlert("More", "Add More Dragon Ball character", "OK");
        }
    }
}
