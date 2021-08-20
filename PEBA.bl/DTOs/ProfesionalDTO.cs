using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PEBA.bl.DTOs
{
    public class ProfesionalDTO
    {
        public int Id_Profesional { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Profesion { get; set; }
        public string PasswordCuenta { get; set; }
        public string Matricula { get; set; }
        public string Mail { get; set; }
        public bool Terminosycondicioes { get; set; }
    }
}
