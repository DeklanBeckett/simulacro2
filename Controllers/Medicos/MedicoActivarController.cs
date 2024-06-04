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
    public class MedicosActivarController : ControllerBase
    {
        public readonly IMedicosRepository _MedicosRepository;
        public MedicosActivarController(IMedicosRepository MedicosRepository)
        {
            _MedicosRepository = MedicosRepository;
        }
        [HttpPatch]
        [Route("api/Medicos/{Id}")]

        public IActionResult ActivarMedico(int Id)
        {
            _MedicosRepository.ActivarMedico(Id);
            return Ok("se ha cambiado de estado");
        }
    }
}
