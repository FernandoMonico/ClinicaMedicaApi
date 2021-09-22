using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaApi.DTOs
{
    public class ConsultaDto
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public int CitaId { get; set; }
    }
}
