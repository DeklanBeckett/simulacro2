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
    public class MedicosController : ControllerBase
    {
        public readonly IMedicosRepository _MedicosRepository;
        public MedicosController(IMedicosRepository MedicosRepository)
        {
            _MedicosRepository = MedicosRepository;
        }

        [HttpGet]
        [Route("api/Medicos")]
        public IEnumerable<Medico> ListarMedico()
        {
            return _MedicosRepository.ListarMedico();
        }



        [HttpGet]
        [Route("api/Medicos/{Id}")]
        public IActionResult DetallesMedico(int Id)
        {

            var medico = _MedicosRepository.DetallesMedico(Id);
            if (medico == null)
            {
                return NotFound("no se encontró");
            }
            return Ok(medico);



        }
    }
}
