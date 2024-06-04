using Simulacro.Services;
using Simulacro.Models;
using Microsoft.AspNetCore.Mvc;
namespace Simulacro.Controllers.Simulacro
{
    public class PacientesUpdateController : ControllerBase
    {
        public readonly IPacientesRepository _PacientesRepository;
        public PacientesUpdateController(IPacientesRepository PacientesRepository)
        {
            _PacientesRepository = PacientesRepository;
        }

        [HttpPut]
        [Route("api/Pacientes/{Id}")]
        public void ActualizarPaciente(int Id, [FromBody] Paciente paciente) => _PacientesRepository.ActualizarPaciente(Id, paciente);


    }
}

