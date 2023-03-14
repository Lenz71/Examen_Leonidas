using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    internal class hospital
    {
        public int CodigoIngresoId { get; set; }

        public string NumHabitacion { get; set;}
        public string Cama { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
