using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEBA.bl.DTOs
{
    public class SintomasNeurologicosDTO
    {
        public int Id_SintomasNeurologicos { get; set; }
        public string Alerta { get; set; }
        public string AlertaTipoAlteracion { get; set; }
        public string AlertaTipoAlteracionOtro { get; set; }
        public string EstadoEmocional { get; set; }
        public string EstadoEmocionalTipoAlteracion { get; set; }
        public string EstadoEmocionalTipoAlteracionOtro { get; set; }
        public string Fuerza { get; set; }
        public string FuerzaTipoAlteracion { get; set; }
        public string FuerzaTipoAlteracionOtro { get; set; }
        public string CondicionMotora { get; set; }
        public string CondicionMotoraTipoAlteracion { get; set; }
        public string CondicionMotoraTipoAlteracionOtro { get; set; }
        public string Sensibilidad { get; set; }
        public string SensibilidadTipoAlteracion { get; set; }
        public string SensibilidadTipoAlteracionOtro { get; set; }
        public string Vision { get; set; }
        public string VisionTipoAlteracion { get; set; }
        public string VisionTipoAlteracionOtro { get; set; }
        public string Audicion { get; set; }
        public string AudicionTipoAlteracion { get; set; }
        public string AudicionTipoAlteracionOtro { get; set; }
        public string AtencionEspacial { get; set; }
        public string AtencionEspacialTipoAlteracion { get; set; }
        public string AtencionEspacialTipoAlteracionOtro { get; set; }
        public string PraxiaManual { get; set; }
        public string PraxiaManualTipoAlteracion { get; set; }
        public string PraxiaManualTipoAlteracionOtro { get; set; }
        public string PraxiaOronguofaciales { get; set; }
        public string PraxiaOronguofacialesTipoAlteracion { get; set; }
        public string PraxiaOronguofacialesTipoAlteracionOtro { get; set; }
        public string Deglucion { get; set; }
        public string DeglucionTipoAlteracion { get; set; }
        public string DeglucionTipoAlteracionOtro { get; set; }
    }
}
