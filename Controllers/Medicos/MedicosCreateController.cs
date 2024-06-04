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
    public class MedicosCreateController : ControllerBase
    {
        public readonly IMedicosRepository _MedicosRepository;
        public MedicosCreateController(IMedicosRepository MedicosRepository)
        {
            _MedicosRepository = MedicosRepository;
        }


        [HttpPost]
        [Route("api/Medicos")]
        public IActionResult CrearMedico([FromBody] Medico medico)
        {   

            
            _MedicosRepository.CrearMedico(medico);
            return Ok();
        }




    }
}

