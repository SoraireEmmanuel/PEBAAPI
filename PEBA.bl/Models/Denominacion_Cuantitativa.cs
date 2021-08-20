using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Denominacion_Cuantitativa", Schema = "dbo")]
    public class Denominacion_Cuantitativa
    {
        [Key]
        public int Id_Denominacion_Cuantitativa { get; set; }
        public double LaminaViolin { get; set; }
        public double LaminaCama { get; set; }
        public double LaminaCome { get; set; }
        public double LaminaRema { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
