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
    public class MedicosUpdateController : ControllerBase
    {
        public readonly IMedicosRepository _MedicosRepository;
        public MedicosUpdateController(IMedicosRepository MedicosRepository)
        {
            _MedicosRepository = MedicosRepository;
        }

        [HttpPut]
        [Route("api/Medicos/{Id}")]
        public void ActualizarMedico(int Id, [FromBody] Medico medico) => _MedicosRepository.ActualizarMedico(Id, medico);







    }
}
