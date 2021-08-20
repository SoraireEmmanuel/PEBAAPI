using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Denominacion_Cualitativa", Schema = "dbo")]
    public class Denominacion_Cualitativa
    {
        [Key]
        public int Id_Denominacion_Cualitativa { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
