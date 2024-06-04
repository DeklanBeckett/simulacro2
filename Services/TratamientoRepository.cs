using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;
using Simulacro.Data;
using Microsoft.EntityFrameworkCore;
namespace Simulacro.Services
{

    public class TratamientoRepository : ITratamientosRepository
    {
        public readonly DataContext _context;
        public TratamientoRepository(DataContext context)
        {
            _context = context;
        }

        

        public void ActualizarTratamiento(int Id, Tratamiento tratamiento)
        {
            _context.Tratamientos.Find(Id);
            _context.Update(tratamiento);
            _context.SaveChanges();
        }


        public void CrearTratamiento(Tratamiento tratamiento)
        {

            tratamiento.Estado = "Activo";
            _context.Tratamientos.Add(tratamiento);
            _context.SaveChanges();

        }

        public Tratamiento DetallesTratamiento(int Id)
        {

            return _context.Tratamientos.Include(e=> e.Citas).FirstOrDefault(b => b.Id == Id);
        }

        public void EliminarTratamiento(int Id)
        {

            var eliminar = _context.Tratamientos.Find(Id);
            eliminar.Estado = "Inactivo";
            _context.Tratamientos.Update(eliminar);
            _context.SaveChanges();
        }

        public IEnumerable<Tratamiento> ListarTratamientos()
        {
            return _context.Tratamientos.Include(e => e.Citas).ToList();
        }

        public void ActivarTratamiento(int Id)
        {

            var Activar = _context.Tratamientos.Find(Id);
            Activar.Estado = "Activo";
            _context.Tratamientos.Update(Activar);
            _context.SaveChanges();
        }



    }
}
