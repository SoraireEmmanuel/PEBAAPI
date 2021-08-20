using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Escritura_Cualitativa", Schema = "dbo")]
    public class Escritura_Cualitativa
    {
        [Key]
        public int Id_Escritura_Cualitativa { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
