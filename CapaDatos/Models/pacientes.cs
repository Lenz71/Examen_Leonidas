using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class pacientes
    {
        [Key]
        public int Codigo { get; set;}
        public string Nombre {  get; set; }
        public string Apellidos {get; set; }
        public string Direcion {   get; set;}
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int hospitalId { get; set; }
        [ForeignKey("hospitalId")]
        public hospital hospital{ get; set; }
    }
}
