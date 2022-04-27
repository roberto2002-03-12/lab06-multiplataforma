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
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<PoliceState> _listPolice = new ObservableCollection<PoliceState>();
        public ObservableCollection<PoliceState> ListPolice { get { return _listPolice; } }
        public ListViewGroup()
        {
            InitializeComponent();
            GroupPolice.ItemsSource = _listPolice;

            _listPolice.Add(new PoliceState("Texas", new[] { new Police
            {
                FirstName = "John",
                LastName = "Smith Klem"
            },
            new Police
            {
                FirstName = "Kevin",
                LastName = "Sanchez Lopez"
            },
            new Police
            {
                FirstName = "Donald",
                LastName = "Williams Miller"
            }
            }));

            _listPolice.Add(new PoliceState("California", new[] { new Police
            {
                FirstName = "Jason",
                LastName = "Johnson Brown"
            },
            new Police
            {
                FirstName = "Caroline",
                LastName = "Miller Gonzales"
            },
            new Police
            {
                FirstName = "Edward",
                LastName = "Davis Contreras"
            }
            }));

            _listPolice.Add(new PoliceState("New York", new[] { new Police
            {
                FirstName = "Alex",
                LastName = "Jason Slush"
            },
            new Police
            {
                FirstName = "Alexis",
                LastName = "Fronter Guetta"
            }
            }));

        }

    }
}