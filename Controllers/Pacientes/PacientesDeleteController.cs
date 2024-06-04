using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class PacientesDeleteController : ControllerBase
    {
        public readonly IPacientesRepository _PacientesRepository;
        public PacientesDeleteController(IPacientesRepository PacientesRepository)
        {
            _PacientesRepository = PacientesRepository;
        }
        
        [HttpDelete]
        [Route("api/Pacientes/{Id}")]
        public IActionResult Eliminarpaciente(int Id){
            _PacientesRepository.EliminarPaciente(Id);
            return Ok("Se ha cambiado el estado");
        }


        }
}
