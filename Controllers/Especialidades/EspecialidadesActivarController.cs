using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
using Simulacro2.Services;
namespace Simulacro.Controllers.Simulacro
{
    public class EspecilidadesActivarController : ControllerBase
    {
        public readonly IEspecialidadesRepository _EspecilidadesRepository;
        public EspecilidadesActivarController(IEspecialidadesRepository especialidadesRepository)
        {
            _EspecilidadesRepository = especialidadesRepository;
        }

        [HttpPatch]
        [Route("api/Especialidades/{Id}")]
        public IActionResult ActivarEspecialidad(int Id)
        {
            _EspecilidadesRepository.ActivarEspecialidad(Id);
            return Ok("Se ha cambiado de estado");
        }


    }
}
