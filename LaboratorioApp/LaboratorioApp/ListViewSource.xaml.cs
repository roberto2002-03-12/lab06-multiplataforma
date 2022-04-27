using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaboratorioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Emilio Contreras" });
            employees.Add(new Employee { DisplayName = "Roberto Contreras" });
            employees.Add(new Employee { DisplayName = "Fabriciano Contreras" });
            employees.Add(new Employee { DisplayName = "Pablo Contreras" });
            employees.Add(new Employee { DisplayName = "Maissa Contreras" });
        }
    }
}