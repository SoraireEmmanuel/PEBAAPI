using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEBA.bl.DTOs
{
    public class ProtocoloDTO
    {
        public int Id_Protocolo { get; set; }
        public string Fecha_Protocolo { get; set; }
        public string ResumenClinico { get; set; }
        public double Total { get; set; }
        public string ConclusionesRecomendaciones { get; set; }
       
        public int Id_Paciente { get; set; }
        public PacienteDTO Paciente { get; set; }

        public int Id_Profesional { get; set; }
        public ProfesionalDTO Profesional { get; set; }
 
        public int Id_SintomasNeurologicos { get; set; }
        public SintomasNeurologicosDTO SintomasNeurologicos { get; set; }
   
        public int Id_ComprensionAuditiva_Cuantitativa { get; set; }
        public ComprensionAuditiva_CuantitativaDTO ComprensionAuditiva_Cuantitativa { get; set; }
       
        public int Id_ExpresionOral_Cuantitativa { get; set; }
        public ExpresionOral_CuantitativaDTO ExpresionOral_Cuantitativa { get; set; }
       
        public int Id_Repeticion_Cuantitativa { get; set; }
        public Repeticion_CuantitativaDTO Repeticion_Cuantitativa { get; set; }
       
        public int Id_Denominacion_Cuantitativa { get; set; }
        public Denominacion_CuantitativaDTO Denominacion_Cuantitativa { get; set; }
       
        public int Id_Lectura_Cuantitativa { get; set; }
        public Lectura_CuantitativaDTO Lectura_Cuantitativa { get; set; }
       
        public int Id_Escritura_Cuantitativa { get; set; }
        public Escritura_CuantitativaDTO Escritura_Cuantitativa { get; set; }
       
        public int Id_ComprensionAuditiva_Cualitativa { get; set; }
        public ComprensionAuditiva_CualitativaDTO ComprensionAuditiva_Cualitativa { get; set; }
       
        public int Id_ExpresionOral_Cualitativa { get; set; }
        public ExpresionOral_CualitativaDTO ExpresionOral_Cualitativa { get; set; }
       
        public int Id_Repeticion_Cualitativa { get; set; }
        public Repeticion_CualitativaDTO Repeticion_Cualitativa { get; set; }
       
        public int Id_Denominacion_Cualitativa { get; set; }
        public Denominacion_CualitativaDTO Denominacion_Cualitativa { get; set; }
       
        public int Id_Lectura_Cualitativa { get; set; }
        public Lectura_CualitativaDTO Lectura_Cualitativa { get; set; }
       
        public int Id_Escritura_Cualitativa { get; set; }
        public Escritura_CualitativaDTO Escritura_Cualitativa { get; set; }
    }
}
