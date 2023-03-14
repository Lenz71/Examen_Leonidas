using CapaDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DBContext : DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string conexion = "Data Source=.;Database=Examen;Integrated Security=True";
            builder.UseSqlServer(conexion);
    
        }

        public DbSet<pacientes> Paciente { get; set; }
        public DbSet<medicos> Medico { get; set; }
        public DbSet<hospital> Hospitales { get; set; }
        public DbSet<medicopaciente> MedicosPacientes { get; set; }
    }

    }

