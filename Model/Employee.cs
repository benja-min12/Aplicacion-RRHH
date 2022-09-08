using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_RRHH.Model
{
    public class Employee
    {
        public int id { get; set; }
        public int rut { get; set; }
        public string dv { get; set;}
        public string name { get; set; }
        public string lastnameP { get; set; }
        public string lastnameM { get; set; }
        public string nationality { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string title { get; set; }
        public string dateBirth { get; set; } 
        public string phone { get; set; }
        
        public ICollection<Contract> contracts { get; set; }

    }
}
