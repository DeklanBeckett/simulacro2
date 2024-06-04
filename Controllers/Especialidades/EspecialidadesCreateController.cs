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
    public class EspecilidadesCreateController : ControllerBase
    {
        public readonly IEspecialidadesRepository _EspecilidadesRepository;
        public EspecilidadesCreateController(IEspecialidadesRepository especialidadesRepository)
        {
            _EspecilidadesRepository = especialidadesRepository;
        }

        [HttpPost]
        [Route("api/Especialidades")]
        public IActionResult CrearEspecialidad([FromBody] Especialidad especialidad)
        {

            _EspecilidadesRepository.CrearEspecialidad(especialidad);
            return Ok();
        }


    }
}
