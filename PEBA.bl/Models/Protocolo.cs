using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PEBA.bl.Models
{
    [Table("Protocolo", Schema = "dbo")]
    public class Protocolo
    {
        [Key]
        public int Id_Protocolo { get; set; }
        public string Fecha_Protocolo { get; set; }
        public string ResumenClinico { get; set; }
        public double Total { get; set; }
        public string ConclusionesRecomendaciones { get; set; }
        [ForeignKey("Paciente")]
        public int Id_Paciente { get; set; }
        public Paciente Paciente { get; set; }
        [ForeignKey("Profesional")]
        public int Id_Profesional { get; set; }
        public Profesional Profesional { get; set; }
        [ForeignKey("SintomasNeurologicos")]
        public int Id_SintomasNeurologicos { get; set; }
        public SintomasNeurologicos SintomasNeurologicos { get; set; }
        [ForeignKey("ComprensionAuditiva_Cuantitativa")]
        public int Id_ComprensionAuditiva_Cuantitativa { get; set; }
        public ComprensionAuditiva_Cuantitativa ComprensionAuditiva_Cuantitativa { get; set; }
        [ForeignKey("ExpresionOral_Cuantitativa")]
        public int Id_ExpresionOral_Cuantitativa { get; set; }
        public ExpresionOral_Cuantitativa ExpresionOral_Cuantitativa { get; set; }
        [ForeignKey("Repeticion_Cuantitativa")]
        public int Id_Repeticion_Cuantitativa { get; set; }
        public Repeticion_Cuantitativa Repeticion_Cuantitativa { get; set; }
        [ForeignKey("Denominacion_Cuantitativa")]
        public int Id_Denominacion_Cuantitativa { get; set; }
        public Denominacion_Cuantitativa Denominacion_Cuantitativa { get; set; }
        [ForeignKey("Lectura_Cuantitativa")]
        public int Id_Lectura_Cuantitativa { get; set; }
        public Lectura_Cuantitativa Lectura_Cuantitativa { get; set; }
        [ForeignKey("Escritura_Cuantitativa")]
        public int Id_Escritura_Cuantitativa { get; set; }
        public Escritura_Cuantitativa Escritura_Cuantitativa { get; set; }
        [ForeignKey("ComprensionAuditiva_Cualitativa")]
        public int Id_ComprensionAuditiva_Cualitativa { get; set; }
        public ComprensionAuditiva_Cualitativa ComprensionAuditiva_Cualitativa { get; set; }
        [ForeignKey("ExpresionOral_Cualitativa")]
        public int Id_ExpresionOral_Cualitativa { get; set; }
        public ExpresionOral_Cualitativa ExpresionOral_Cualitativa { get; set; }
        [ForeignKey("Repeticion_Cualitativa")]
        public int Id_Repeticion_Cualitativa { get; set; }
        public Repeticion_Cualitativa Repeticion_Cualitativa { get; set; }
        [ForeignKey("Denominacion_Cualitativa")]
        public int Id_Denominacion_Cualitativa { get; set; }
        public Denominacion_Cualitativa Denominacion_Cualitativa { get; set; }
        [ForeignKey("Lectura_Cualitativa")]
        public int Id_Lectura_Cualitativa { get; set; }
        public Lectura_Cualitativa Lectura_Cualitativa { get; set; }
        [ForeignKey("Escritura_Cualitativa")]
        public int Id_Escritura_Cualitativa { get; set; }
        public Escritura_Cualitativa Escritura_Cualitativa { get; set; }

    }
}
