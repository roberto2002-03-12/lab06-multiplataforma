using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorioApp
{
    public class Police
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }
}
