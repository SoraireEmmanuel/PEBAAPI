using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Escritura_Cuantitativa", Schema = "dbo")]
    public class Escritura_Cuantitativa
    {
        [Key]
        public int Id_Escritura_Cuantitativa { get; set; }
        public double EME { get; set; }
        public double ZETA { get; set; }
        public double Mano{ get; set; }
        public double Gente { get; set; }
        public double Esperanza { get; set; }
        public double Aclaracion { get; set; }
        public double Jo { get; set; }
        public double Guela { get; set; }
        public double Dirchole { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }

    }
}
