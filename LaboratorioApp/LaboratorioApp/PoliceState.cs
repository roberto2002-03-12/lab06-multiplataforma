using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace LaboratorioApp
{
    public class PoliceState : ObservableCollection<Police>
    {
        public string State { get; set; }

        //Sirve para poder agregar grupos sin cuerpos, es decir crear un grupo sin datos adentro
        //en mi caso no lo voy a usar así que lo comento
        //public PoliceState(string state) : base() { State = state; }

        //Sirve para poder hacer que State sea la palabra clave de un grupo
        //IEnumerable se utiliza para poder declarar colecciones dentro del grupo en la cual
        //en este caso es Police que viene a ser una clase y se la declara en la variable source
        //base sirve para poder acceder a esta clase y declarar las variables
        public PoliceState(string state, IEnumerable<Police> source)
            : base(source)
        {
            State = state;
        }

    }
}
