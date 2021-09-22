using ClinicaApi.DTOs;
using ClinicaMedicaApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaMedicaApi.Controllers
{
    [Route("api/paciente")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        [HttpGet("get_all")]
        public async Task<ActionResult<List<PacienteDto>>> GetAll()
        {
            var result = await _pacienteRepository.GetAll();
            return result;
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create(PacienteDto pacienteDto)
        {
            var result = await _pacienteRepository.Create(pacienteDto);
            return Ok();
        }
    }
}
