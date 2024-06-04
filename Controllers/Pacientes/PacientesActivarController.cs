using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class PacientesActivarController : ControllerBase
    {
        public readonly IPacientesRepository _PacientesRepository;
        public PacientesActivarController(IPacientesRepository PacientesRepository)
        {
            _PacientesRepository = PacientesRepository;
        }

        [HttpPatch]
        [Route("api/Pacientes/{Id}")]
        public IActionResult ActivarPaciente(int Id)
        {
            _PacientesRepository.ActivarPaciente(Id);
            return Ok("Se ha cambiado el estado");
        }


    }
}
