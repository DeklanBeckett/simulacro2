using Simulacro.Models;

namespace Simulacro.Services
{
    public interface IEspecialidadesRepository
    {
        IEnumerable<Especialidad> ListarEspecialidades();
        Especialidad DetallesEspecialidad(int Id);
        void CrearEspecialidad(Especialidad especialidad);
        void EliminarEspecialidad(int Id);
        void ActualizarEspecialidad(int Id, Especialidad especialidad);
        void ActivarEspecialidad(int Id);
    }
}
