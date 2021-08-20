using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Profesional", Schema = "dbo")]
    public class Profesional
    {
        [Key]
        public int Id_Profesional { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Profesion { get; set; }
        public string PasswordCuenta { get; set; }
        public string Matricula { get; set; }
        public string Mail { get; set; }
        public bool Terminosycondicioes { get; set; }

        public virtual ICollection <Paciente> Pacientes { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }


}
