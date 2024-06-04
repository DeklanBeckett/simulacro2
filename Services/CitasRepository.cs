using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;
using Simulacro.Data;
using Microsoft.EntityFrameworkCore;
namespace Simulacro.Services
{

    public class CitasRepository : ICitasRepository
    {
        public readonly DataContext _context;
        public CitasRepository(DataContext context)
        {
            _context = context;
        }

    public void ActualizarCita(int id, Cita cita)
        {
            var citaUpdate = _context.Citas.FirstOrDefault(p => p.Id ==id);

            citaUpdate.MedicoId = cita.MedicoId;
            citaUpdate.PacienteId = cita.PacienteId;
            citaUpdate.Fecha = cita.Fecha;
            citaUpdate.Estado = cita.Estado;
            
            _context.Update(citaUpdate);
            _context.SaveChanges();
        }


        public void CrearCita(Cita cita)
        {

            cita.Estado = "Activo";
            _context.Citas.Add(cita);
            _context.SaveChanges();

        }

        public Cita DetallesCita(int Id)
        {

            return _context.Citas.Include(e=> e.Medicos).Include(e=> e. Pacientes).FirstOrDefault(b => b.Id == Id);
        }

        public void EliminarCita(int Id)
        {

            var eliminar = _context.Citas.Find(Id);
            eliminar.Estado = "Inactivo";
            _context.Citas.Update(eliminar);
            _context.SaveChanges();
        }



        public IEnumerable<Cita> ListarCitas()
        {
            return _context.Citas.Include(e => e.Medicos).Include(e => e.Pacientes).ToList();
        }

        public void ActivarCita(int Id)
        {
            var Activar = _context.Citas.Find(Id);
            Activar.Estado = "Activo";
            _context.Citas.Update(Activar);
            _context.SaveChanges();
        }

        public int ContarCitasPorPaciente(int pacienteId)
        {
            return _context.Citas.Count(c => c.PacienteId == pacienteId);
        }



    }
}


