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
    public class PacienteRepository : IPacienteRepository
    {
        private readonly IConfiguration _configuration;

        public PacienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Create(PacienteDto pacienteDto)
        {
            var sql = "SP_PacienteCreate";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(
                    sql,
                    new { Nombre = pacienteDto.Nombre, Apellido = pacienteDto.Apellido, Altura = pacienteDto.Altura, Peso = pacienteDto.Peso, FechaNacimiento = pacienteDto.FechaNacimiento },
                    commandType: CommandType.StoredProcedure
                    );
                return affectedRows;
            }
        }

        public async Task<List<PacienteDto>> GetAll()
        {
            var sql = "SP_PacienteGetAll";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<PacienteDto>(sql, null, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
