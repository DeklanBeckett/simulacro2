using Microsoft.AspNetCore.Mvc;
using Simulacro.Models;
using Simulacro.Services;


namespace Simulacro.Controllers.Simulacro
{
    public class CantidadCitasPacienteController : ControllerBase
    {
        public readonly ICitasRepository _citas;
        public CantidadCitasPacienteController(ICitasRepository citas)
        {
            _citas = citas;
        }



        [HttpGet("{pacienteId}")]
        public ActionResult<int> ContarCitasPaciente(int pacienteId)
        {
            var Citas = _citas.ContarCitasPorPaciente(pacienteId);
            return Ok(new { pacienteId, Citas });
        }



    }
}
