using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity3 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Activity3()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee
            {
                DisplayName = "Son Goku",
                Position = "Saiyan Warrior",
                Image = "https://i.pinimg.com/736x/f9/f2/86/f9f28607ea72c03987bb2f571bb838b4.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Vegeta",
                Position = "Prince of Saiyans",
                Image = "https://upload.wikimedia.org/wikipedia/pt/a/ac/Vegeta.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Piccolo",
                Position = "Namekian Warrior",
                Image = "https://images4.alphacoders.com/922/922319.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Bulma",
                Position = "Scientist",
                Image = "https://carboncostume.com/wordpress/wp-content/uploads/2015/10/bulma.jpg"
            });

            employees.Add(new Employee
            {
                DisplayName = "Gohan",
                Position = "Scholar and Warrior",
                Image = "https://static0.cbrimages.com/wordpress/wp-content/uploads/2023/10/gohan-saiyan-beast.jpg"
            });
        }
    }
}
