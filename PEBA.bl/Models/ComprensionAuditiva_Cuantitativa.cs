using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("ComprensionAuditiva_Cuantitativa", Schema = "dbo")]
    public class ComprensionAuditiva_Cuantitativa
    {
        [Key]
        public int Id_ComprensionAuditiva_Cuantitativa { get; set; }
        public double SenialeLaOveja { get; set; }
        public double SenialeElPato { get; set; }
        public double ToqueseLaOreja { get; set; }
        public double SenialeElTecho { get; set; }
        public double  SenialeLaPuerta { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
