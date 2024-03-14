using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity4 : ContentPage
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public Activity4()
        {
            InitializeComponent();

            Employees = new ObservableCollection<Employee>();
  
            Employees.Add(new Employee
            {
                DisplayName = "Goku",
                Position = "Saiyan",
             
            });
            Employees.Add(new Employee
            {
                DisplayName = "Krillin",
                Position = "Human",
            
            });

            Employees.Add(new Employee
            {
                DisplayName = "Vegeta",
                Position = "Saiyan",
               
            });

            Employees.Add(new Employee
            {
                DisplayName = "Picollo",
                Position = "Namekian",
                
            });



            BindingContext = this;
        }

        private async void displayMsg(object sender, ToggledEventArgs e)
        {
            SwitchCell switchCell = (SwitchCell)sender;
            var employee = (Employee)switchCell.BindingContext;

            if (employee.Position == "Saiyan")
            {
                await DisplayAlert("Switch Toggled On", $"{employee.DisplayName} can turn Super Saiyan!", "Ok");
            }
            else
            {
                await DisplayAlert("Switch Toggled Off", $"{employee.DisplayName} can't turn Saiyan due to him not being a saiyan.", "Ok");
            }
        }
    }
}
