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
    public class CitasController : ControllerBase
    {
        public readonly ICitasRepository _citas;
        public CitasController(ICitasRepository citas)
        {
            _citas = citas;
        }

        [HttpGet]
        [Route("api/Citas")]
        public IEnumerable<Cita> ListarCitas()
        {
            return _citas.ListarCitas();
        }



        [HttpGet]
        [Route("api/Citas/{Id}")]
        public IActionResult DetallesCita(int Id)
        {

            var especialidad = _citas.DetallesCita(Id);
            if (especialidad == null)
            {
                return NotFound("no se encontró");
            }
            return Ok(especialidad);



        }
    }
}
