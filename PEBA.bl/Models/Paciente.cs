using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Paciente", Schema = "dbo")]
    public class Paciente
    {
        [Key]
        public int Id_Paciente { get; set; }
        public string Cod_Paciente { get; set; }
        public string Iniciales { get; set; }
        public string FechaNacimiento { get; set; }
        public string Lengua { get; set; }
        public string Dominancia { get; set; }
        public string Estudios { get; set; }
        [ForeignKey("Profesional")]
        public int Id_Profesional { get; set; }

        public Profesional Profesional{get; set;}
        public virtual ICollection<Protocolo> Protocolos { get; set; }


    }
}
