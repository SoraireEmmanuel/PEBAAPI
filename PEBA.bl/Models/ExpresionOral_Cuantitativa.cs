using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("ExpresionOral_Cuantitativa", Schema = "dbo")]
    public class ExpresionOral_Cuantitativa
    {
        [Key]
        public int Id_ExpresionOral_Cuantitativa { get; set; }
        public double DigaSuNombre { get; set; }
        public double EnQueCiudadNacio { get; set; }
        public double LaminaElParque { get; set; }
        public double LaminaConsultaMedica { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }

    }
}
