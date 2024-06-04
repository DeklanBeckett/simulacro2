using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class PacientesCreateController : ControllerBase
    {
        public readonly IPacientesRepository _PacientesRepository;
        public PacientesCreateController(IPacientesRepository PacientesRepository)
        {
            _PacientesRepository = PacientesRepository;
        }
        
        [HttpPost]
        [Route("api/Pacientes")]
        public IActionResult CrearPaciente([FromBody] Paciente paciente){
            _PacientesRepository.CrearPaciente(paciente);
            return Ok();
        }
        
    }
}