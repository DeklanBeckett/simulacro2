using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class TratamientosCreateController : ControllerBase
    {
        public readonly ITratamientosRepository _tratamientos;
        public TratamientosCreateController(ITratamientosRepository tratamientos)
        {
            _tratamientos = tratamientos;
        }
        [HttpPost]
        [Route("api/Tratamientos")]
        public IActionResult CrearTratamiento([FromBody] Tratamiento tratamiento)
        {
            _tratamientos.CrearTratamiento(tratamiento);
            return Ok();
        }


    }
}
