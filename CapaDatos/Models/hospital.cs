using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class hospital
    {
        [Key]
        public int CodigoIngresoId { get; set; }

        public string NumHabitacion { get; set;}
        public string Cama { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
