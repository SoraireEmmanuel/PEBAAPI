using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PEBA.bl.Models
{
    [Table("Repeticion_Cuantitativa", Schema = "dbo")]
    public class Repeticion_Cuantitativa
    {
        [Key]
        public int Id_Repeticion_Cuantitativa { get; set; }
        public double Sol { get; set; }
        public double Precio { get; set; }
        public double Pensamiento { get; set; }
        public double MuchoRuido { get; set; }
        public double ElHombreGuardo { get; set; }
        public double LaMujerRegalo { get; set; }
        public double Fo { get; set; }
        public double Treyo { get; set; }
        public double Almusipa { get; set; }
        public virtual ICollection<Protocolo> Protocolos { get; set; }
    }
}
