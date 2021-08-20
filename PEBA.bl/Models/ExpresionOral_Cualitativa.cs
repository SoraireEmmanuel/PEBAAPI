using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("ExpresionOral_Cualitativa", Schema = "dbo")]
    public class ExpresionOral_Cualitativa
    {
        [Key]
        public int Id_ExpresionOral_Cualitativa { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
