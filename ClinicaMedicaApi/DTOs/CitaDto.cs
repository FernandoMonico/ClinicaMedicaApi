using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaApi.DTOs
{
    public class CitaDto
    {
        public int Id { get; set; }
        public DateTime FechaConsulta { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
    }
}
