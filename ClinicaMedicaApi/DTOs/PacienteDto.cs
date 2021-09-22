using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaApi.DTOs
{
    public class PacienteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
