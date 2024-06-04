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
    public class CitasCreateController : ControllerBase
    {
        public readonly ICitasRepository _citas;
        public CitasCreateController(ICitasRepository citas)
        {
            _citas = citas;
        }

        [HttpPost]
        [Route("api/Citas")]
        public IActionResult CrearCitas([FromBody] Cita cita)
        {

            _citas.CrearCita(cita);
            return Ok();
        }
    }
}
