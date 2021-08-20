using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Lectura_Cuantitativa", Schema = "dbo")]
    public class Lectura_Cuantitativa
    {
        [Key]
        public int Id_Lectura_Cuantitativa { get; set; }
        public double Mono { get; set; }
        public double Arco { get; set; }
        public double Casa { get; set; }
        public double Grito { get; set; }
        public double Estatua { get; set; }
        public double Comunidad { get; set; }
        public double Ne { get; set; }
        public double Cho { get; set; }
        public double Bleja { get; set; }
        public double Tudipro { get; set; }
        public double SaqueLaMano { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
