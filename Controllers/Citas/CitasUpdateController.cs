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
    public class CitasUpdateController : ControllerBase
    {
        public readonly ICitasRepository _citas;
        public CitasUpdateController(ICitasRepository citas)
        {
            _citas = citas;
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarPaciente(int id, [FromBody] Cita cita)
        {
            try
            {
                _citas.ActualizarCita(id, cita);
                return Ok("La cita se ha actualizado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest("Error al actualizar la cita: " + ex.Message);
            }
        }
}
}