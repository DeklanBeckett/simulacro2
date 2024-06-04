using Simulacro.Models;
using Simulacro.Data;
using Simulacro2.Services;
using Microsoft.EntityFrameworkCore;
namespace Simulacro.Services
{

    public class MedicosRepository : IMedicosRepository
    {
        public readonly DataContext _context;
        public MedicosRepository(DataContext context)
        {
            _context = context;
        }

        public void ActualizarMedico(int Id, Medico medico)
        {
            _context.Medicos.Find(Id);
            _context.Update(medico);
            _context.SaveChanges();
        }


        public void CrearMedico(Medico medico)
        {
            
            medico.Estado = "Activo";
            _context.Medicos.Add(medico);
            _context.SaveChanges();

        }

        

        public Medico DetallesMedico(int Id)
        {

            return _context.Medicos.Include( e=> e.Especialidades).FirstOrDefault(b => b.Id == Id);
        }

        public void EliminarMedico(int Id)
        {

            var eliminar = _context.Medicos.Find(Id);
            eliminar.Estado = "Inactivo";
            _context.Medicos.Update(eliminar);
            _context.SaveChanges();
        }

        public IEnumerable<Medico> ListarMedico()
        {
            return _context.Medicos.Include(e => e.Especialidades).ToList();
        }

        public void ActivarMedico(int Id)
        {
            var Activar = _context.Medicos.Find(Id);
            Activar.Estado = "Activo";
            _context.Medicos.Update(Activar);
            _context.SaveChanges();
        }

    }
}
