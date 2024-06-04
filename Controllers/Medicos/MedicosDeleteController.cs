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
    public class MedicosDeleteController : ControllerBase
    {
        public readonly IMedicosRepository _MedicosRepository;
        public MedicosDeleteController(IMedicosRepository MedicosRepository)
        {
            _MedicosRepository = MedicosRepository;
        }
        [HttpDelete]
        [Route("api/Medicos/{Id}")]

        public IActionResult EliminarMedico(int Id)
        {
            _MedicosRepository.EliminarMedico(Id);
            return Ok("se ha cambiado de estado");
        }
    }
}
