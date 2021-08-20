using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table  ("ComprensionAuditiva_Cualitativa", Schema = "dbo")]
    public class ComprensionAuditiva_Cualitativa
    {
        [Key]
        public int Id_ComprensionAuditiva_Cualitativa { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
