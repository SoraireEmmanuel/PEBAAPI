using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Repeticion_Cualitativa", Schema = "dbo")]
    public class Repeticion_Cualitativa
    {
        [Key]
        public int Id_Repeticion_Cualitativa { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
