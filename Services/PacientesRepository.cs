using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;
using Simulacro.Data;
namespace Simulacro.Services
{

    public class PacientesRepository : IPacientesRepository
    {
        public readonly DataContext _context;
        public PacientesRepository(DataContext context)
        {
            _context = context;
        }

        public void ActualizarPaciente(int Id, Paciente paciente)
        {
            _context.Pacientes.Find(Id);
            _context.Update(paciente);
            _context.SaveChanges();
        }

        
        public void CrearPaciente(Paciente paciente)
        {
            
            paciente.Estado = "Activo";
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            
        }

        public Paciente DetallesPaciente(int Id)
        {

            return _context.Pacientes.FirstOrDefault(b => b.Id == Id);
        }

        public void EliminarPaciente(int Id)
        {
            
            var eliminar = _context.Pacientes.Find(Id);
            eliminar.Estado = "Inactivo";
            _context.Pacientes.Update(eliminar);
            _context.SaveChanges();
        }

        public IEnumerable<Paciente> ListarPacientes()
        {
            return _context.Pacientes.ToList();
        }
        public void ActivarPaciente(int Id)
        {

            var Activar = _context.Pacientes.Find(Id);
            Activar.Estado = "Activo";
            _context.Pacientes.Update(Activar);
            _context.SaveChanges();
        }


    }
}
