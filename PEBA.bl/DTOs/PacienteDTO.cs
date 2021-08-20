using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PEBA.bl.DTOs
{
    public class PacienteDTO
    {

        public int Id_Paciente { get; set; }
        public string Cod_Paciente { get; set; }
        public string Iniciales { get; set; }
        public string FechaNacimiento { get; set; }
        public string Lengua { get; set; }
        public string Dominancia { get; set; }
        public string Estudios { get; set; }
        public int Id_Profesional { get; set; }
        public ProfesionalDTO Profesional { get; set; }
    }
}
