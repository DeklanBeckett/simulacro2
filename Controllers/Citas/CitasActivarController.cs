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
    public class CitasActivarController : ControllerBase
    {
        public readonly ICitasRepository _citas;
        public CitasActivarController(ICitasRepository citas)
        {
            _citas = citas;
        }

        [HttpPatch]
        [Route("api/Citas/{Id}")]
        public IActionResult ActivarCitas(int Id)
        {
            _citas.ActivarCita(Id);
            return Ok("Se ha cambiado de estado");
        }
    }
}
