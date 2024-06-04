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
    public class EspecilidadesDeleteController : ControllerBase
    {
        public readonly IEspecialidadesRepository _EspecilidadesRepository;
        public EspecilidadesDeleteController(IEspecialidadesRepository especialidadesRepository)
        {
            _EspecilidadesRepository = especialidadesRepository;
        }

        [HttpDelete]
        [Route("api/Especialidades/{Id}")]
        public IActionResult EliminarEspecialidad(int Id)
        {
            _EspecilidadesRepository.EliminarEspecialidad(Id);
            return Ok("Se ha cambiado de estado");
        }


    }
}
