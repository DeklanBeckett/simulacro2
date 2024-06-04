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
    public class EspecilidadesUpdateController : ControllerBase
    {
        public readonly IEspecialidadesRepository _EspecilidadesRepository;
        public EspecilidadesUpdateController(IEspecialidadesRepository especialidadesRepository)
        {
            _EspecilidadesRepository = especialidadesRepository;
        }


        [HttpPut]
        [Route("api/Especialidades/{Id}")]
        public void EditarEspecialidad(int Id, [FromBody] Especialidad especialidad) => _EspecilidadesRepository.ActualizarEspecialidad(Id, especialidad);

    }
}
