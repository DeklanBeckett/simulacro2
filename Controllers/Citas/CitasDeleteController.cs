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
    public class CitasDeleteController : ControllerBase
    {
        public readonly ICitasRepository _citas;
        public CitasDeleteController(ICitasRepository citas)
        {
            _citas = citas;
        }

        [HttpDelete]
        [Route("api/Citas/{Id}")]
        public IActionResult EliminarCita(int Id)
        {
            _citas.EliminarCita(Id);
            return Ok("Se ha cambiado de estado");
        }
    }
}
