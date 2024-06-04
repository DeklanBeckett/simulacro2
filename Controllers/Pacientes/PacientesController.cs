using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro.Services;
using Simulacro.Models;
namespace Simulacro.Controllers.Simulacro
{
    public class PacientesController : ControllerBase
    {
        public readonly IPacientesRepository _PacientesRepository;
        public PacientesController(IPacientesRepository PacientesRepository)
        {
            _PacientesRepository = PacientesRepository;
        }

        
        [HttpGet]
        [Route("api/Pacientes")]
        public IEnumerable<Paciente> ListarPacientes(){
            return _PacientesRepository.ListarPacientes();
        }

        [HttpGet]
        [Route("api/Pacientes/{Id}")]
        public IActionResult DetallesPaciente(int Id){
            
        var  paciente = _PacientesRepository.DetallesPaciente(Id);
        if(paciente == null){
        return NotFound("no se encontró");
        }
        return Ok(paciente);
    }
}}