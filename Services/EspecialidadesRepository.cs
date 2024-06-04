using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;
using Simulacro.Data;
namespace Simulacro.Services
{

    public class EspecialidadesRepository : IEspecialidadesRepository
    {
        public readonly DataContext _context;
        public EspecialidadesRepository(DataContext context)
        {
            _context = context;
        }

        public void ActualizarEspecialidad(int Id, Especialidad especialidad)
        {
            _context.Especialidades.Find(Id);
            _context.Update(especialidad);
            _context.SaveChanges();
        }


        public void CrearEspecialidad(Especialidad especialidad)
        {

            especialidad.Estado = "Activo";
            _context.Especialidades.Add(especialidad);
            _context.SaveChanges();

        }

        public Especialidad DetallesEspecialidad(int Id)
        {

            return _context.Especialidades.FirstOrDefault(b => b.Id == Id);
        }

        public void EliminarEspecialidad(int Id)
        {

            var eliminar = _context.Especialidades.Find(Id);
            eliminar.Estado = "Inactivo";
            _context.Especialidades.Update(eliminar);
            _context.SaveChanges();
        }

       

        public IEnumerable<Especialidad> ListarEspecialidades()
        {
            return _context.Especialidades.ToList();
        }

        public void ActivarEspecialidad(int Id)
        {
            var Activar = _context.Especialidades.Find(Id);
            Activar.Estado = "Activo";
            _context.Especialidades.Update(Activar);
            _context.SaveChanges();
        }

    }
}


