using ClinicaApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaMedicaApi.Services
{
    public interface IPacienteRepository
    {
        public Task<int> Create(PacienteDto pacienteDto);
        public Task<List<PacienteDto>> GetAll();
    }
}
