using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class TratamientosUpdateController : ControllerBase
    {
        public readonly ITratamientosRepository _tratamientos;
        public TratamientosUpdateController(ITratamientosRepository tratamientos)
        {
            _tratamientos = tratamientos;
        }


        [HttpPut]
        [Route("api/Tratamientos/{Id}")]
        public void ActualizarTratamiento(int Id, [FromBody] Tratamiento tratamiento) => _tratamientos.ActualizarTratamiento(Id, tratamiento);



    }
}
