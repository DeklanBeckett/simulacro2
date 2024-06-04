using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace Simulacro.Services
{
    public interface ICitasRepository
    {

        IEnumerable<Cita> ListarCitas();
        Cita DetallesCita(int Id);
        void CrearCita(Cita cita);
        void EliminarCita(int Id);
        void ActualizarCita(int Id, Cita cita);
        void ActivarCita(int Id);
        int ContarCitasPorPaciente(int pacienteId);
    }
}
