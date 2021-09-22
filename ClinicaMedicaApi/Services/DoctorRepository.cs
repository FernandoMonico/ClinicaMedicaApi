using ClinicaApi.DTOs;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaMedicaApi.Services
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly IConfiguration _configuration;

        public DoctorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Create(DoctorDto doctorDto)
        {
            var sql = "SP_DoctorCreate";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(
                    sql,
                    new { Nombre = doctorDto.Nombre, Apellido = doctorDto.Apellido, Especialidad = doctorDto.Especialidad },
                    commandType: CommandType.StoredProcedure
                    );
                return affectedRows;
            }
        }

        public async Task<List<DoctorDto>> GetAll()
        {
            var sql = "SP_DoctorGetAll";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<DoctorDto>(sql, null, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
