using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Programada5
{

    public class Empleado : Persona
    {
        public decimal Sueldo { get; set; }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - AnioNacimiento;
            }
        }
    }
}
   

