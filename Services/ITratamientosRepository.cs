using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace Simulacro.Services
{
    public interface ITratamientosRepository
    {

        IEnumerable<Tratamiento> ListarTratamientos();
        Tratamiento DetallesTratamiento(int Id);
        void CrearTratamiento(Tratamiento tratamiento);
        void EliminarTratamiento(int Id);
        void ActualizarTratamiento(int Id, Tratamiento tratamiento);
        void ActivarTratamiento(int Id);
    }
}
