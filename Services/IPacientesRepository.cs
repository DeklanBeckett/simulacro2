using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace Simulacro.Services
{
    public interface IPacientesRepository
        {
        
            IEnumerable<Paciente> ListarPacientes();
            Paciente DetallesPaciente(int Id);
            void CrearPaciente(Paciente paciente);
            void EliminarPaciente(int Id);
            void ActualizarPaciente(int Id,Paciente paciente);
            void ActivarPaciente(int Id);
        }
}
