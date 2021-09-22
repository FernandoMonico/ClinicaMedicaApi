using ClinicaApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaMedicaApi.Services
{
    public interface IDoctorRepository
    {
        public Task<int> Create(DoctorDto doctorDto);
        public Task<List<DoctorDto>> GetAll();
    }
}
