using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class TratamientosController : ControllerBase
    {
        public readonly  ITratamientosRepository _tratamientos;
        public TratamientosController(ITratamientosRepository tratamientos)
        {
            _tratamientos = tratamientos;
        }


        [HttpGet]
        [Route("api/Tratamientos")]
        public IEnumerable<Tratamiento> ListarTratamiento()
        {
            return _tratamientos.ListarTratamientos();
        }

        [HttpGet]
        [Route("api/Tratamientos/{Id}")]
        public IActionResult DetallesTratamiento(int Id)
        {

            var tratamiento = _tratamientos.DetallesTratamiento(Id);
            if (tratamiento == null)
            {
                return NotFound("no se encontró");
            }
            return Ok(tratamiento);
        }
    }
}