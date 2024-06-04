using Simulacro.Models;

namespace Simulacro2.Services
{
    public interface IMedicosRepository
    {
        IEnumerable<Medico> ListarMedico();
        Medico DetallesMedico(int Id);
        void CrearMedico(Medico medico);
        void EliminarMedico(int Id);
        void ActualizarMedico(int Id, Medico medico);
        void ActivarMedico(int Id);
    }
}
