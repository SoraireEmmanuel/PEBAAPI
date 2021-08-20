using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Lectura_Cualitativa", Schema = "dbo")]
    public class Lectura_Cualitativa
    {
        [Key]
        public int Id_Lectura_Cualitativa { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
