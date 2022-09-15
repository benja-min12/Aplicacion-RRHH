using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_RRHH.Model
{
    public class Contract
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int nContract { get; set; }
        public string rut { get; set; }
        public string nameEmployee { get; set; }
        public string job { get; set; }
        public int salary { get; set; }
        public string proyect { get; set; }
        public string typeContract { get; set; }
        public string workingDay { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool isValid { get; set; }
        public string reason { get; set; }
        public DateTime dateFinish { get; set; }

        public Employee Employee { get; set; }

    }
}
