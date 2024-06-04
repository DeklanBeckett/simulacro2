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
    public class EspecilidadesController : ControllerBase
    {
        public readonly IEspecialidadesRepository _EspecilidadesRepository;
        public EspecilidadesController(IEspecialidadesRepository especialidadesRepository)
        {
            _EspecilidadesRepository = especialidadesRepository;
        }

        [HttpGet]
        [Route("api/Especialidades")]
        public IEnumerable<Especialidad> ListarEspecialidades()
        {
            return _EspecilidadesRepository.ListarEspecialidades();
        }



        [HttpGet]
        [Route("api/Especialidades/{Id}")]
        public IActionResult DetallesEspecialidad(int Id)
        {

            var especialidad = _EspecilidadesRepository.DetallesEspecialidad(Id);
            if (especialidad == null)
            {
                return NotFound("no se encontró");
            }
            return Ok(especialidad);



        }
    }
}
