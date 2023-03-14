using CapaDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Medico

    {
        public void Insertar(medicosDTO medicos)
        {
            using (DBContext dB = new())
            {
                medicos Medico = new medicos();

                Medico.Nombre = medicos.Nombre;
                Medico.Apellidos = medicos.Apellidos;
                Medico.Telefono = medicos.Telefono;
                Medico.Especialidad = medicos.Especialidad;
                dB.Medico.Add(Medico);
            }

        }
        public void Actualizar(medicosDTO medico)
        {
            using (DBContext dB = new())
            {
                medicos Medico = new medicos();
                Medico.Codigo = medico.Codigo;
                Medico.Nombre = medico.Nombre;
                Medico.Apellidos = medico.Apellidos;
                Medico.Telefono = medico.Telefono;
                Medico.Especialidad = medico.Especialidad;

                dB.Medico.Update(Medico);
            }
        }
            public void Eliminar(int id)
            {
                using (DBContext dB = new())
                {
                    var medicoDb = dB.Medico.Find(id);
                    dB.Medico.Remove(medicoDb);
                }
         
            }
            public List<medicos> Mostrar()
            {
                using (DBContext dB = new())
                {
                    return dB.Medico.ToList();
                }
            }
        }

    }


