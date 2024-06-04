using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class TratamientosDeleteController : ControllerBase
    {
        public readonly ITratamientosRepository _tratamientos;
        public TratamientosDeleteController(ITratamientosRepository tratamientos)
        {
            _tratamientos = tratamientos;
        }


        [HttpDelete]
        [Route("api/Tratamientos/{Id}")]
        public IActionResult EliminarTratamiento(int Id)
        {
            _tratamientos.EliminarTratamiento(Id);
            return Ok();
        }



    }
}
