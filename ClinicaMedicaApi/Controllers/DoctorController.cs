using ClinicaApi.DTOs;
using ClinicaMedicaApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicaMedicaApi.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet("get_all")]
        public async Task<ActionResult<List<DoctorDto>>> GetAll()
        {
            var result = await _doctorRepository.GetAll();
            return result;
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create(DoctorDto doctorDto)
        {
            var result = await _doctorRepository.Create(doctorDto);
            return Ok();
        }
    }
}
