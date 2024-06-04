using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class TratamientosActivarController : ControllerBase
    {
        public readonly ITratamientosRepository _tratamientos;
        public TratamientosActivarController(ITratamientosRepository tratamientos)
        {
            _tratamientos = tratamientos;
        }


        [HttpPatch]
        [Route("api/Tratamientos/{Id}")]
        public IActionResult ActivarTratamiento(int Id)
        {
            _tratamientos.ActivarTratamiento(Id);
            return Ok();
        }



    }
}
