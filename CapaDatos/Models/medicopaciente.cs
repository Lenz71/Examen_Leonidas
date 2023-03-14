using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    internal class medicopaciente
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }

        [ForeignKey("PacienteId")]
        public pacientes Pacientes { get; set; }

        [ForeignKey("MedicoId")]
        public medicos Medicos { get; set; }
    }
}
