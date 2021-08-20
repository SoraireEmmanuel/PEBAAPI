    using System;
using AutoMapper;
using PEBA.bl.Models;
using PEBA.bl.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEBA.bl.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Paciente, HistorialDTO>();//get
                cfg.CreateMap<HistorialDTO, Paciente >();
                cfg.CreateMap<Protocolo, HistorialDTO>();//get
                cfg.CreateMap<HistorialDTO, Protocolo>();//get

                cfg.CreateMap<Profesional, ProfesionalDTO>();//get
                cfg.CreateMap<ProfesionalDTO, Profesional>();//post-put

                cfg.CreateMap<Paciente, PacienteDTO>();//get
                cfg.CreateMap<PacienteDTO, Paciente>();//post-put

                cfg.CreateMap<ComprensionAuditiva_Cualitativa, ComprensionAuditiva_CualitativaDTO>();//get
                cfg.CreateMap<ComprensionAuditiva_CualitativaDTO, ComprensionAuditiva_Cualitativa>();//post-put

                cfg.CreateMap<ComprensionAuditiva_Cuantitativa, ComprensionAuditiva_CuantitativaDTO>();//get
                cfg.CreateMap<ComprensionAuditiva_CuantitativaDTO, ComprensionAuditiva_Cuantitativa>();//post-put

                cfg.CreateMap<Denominacion_Cualitativa, Denominacion_CualitativaDTO>();//get
                cfg.CreateMap<Denominacion_CualitativaDTO, Denominacion_Cualitativa>();//post-put

                cfg.CreateMap<Denominacion_Cuantitativa, Denominacion_CuantitativaDTO>();//get
                cfg.CreateMap<Denominacion_CuantitativaDTO, Denominacion_Cuantitativa>();//post-put

                cfg.CreateMap<Escritura_Cualitativa, Escritura_CualitativaDTO>();//get
                cfg.CreateMap<Escritura_CualitativaDTO, Escritura_Cualitativa>();//post-put

                cfg.CreateMap<Escritura_Cuantitativa, Escritura_CuantitativaDTO>();//get
                cfg.CreateMap<Escritura_CuantitativaDTO, Escritura_Cuantitativa>();//post-put

                cfg.CreateMap<ExpresionOral_Cualitativa, ExpresionOral_CualitativaDTO>();//get
                cfg.CreateMap<ExpresionOral_CualitativaDTO, ExpresionOral_Cualitativa>();//post-put

                cfg.CreateMap<ExpresionOral_Cuantitativa, ExpresionOral_CuantitativaDTO>();//get
                cfg.CreateMap<ExpresionOral_CuantitativaDTO, ExpresionOral_Cuantitativa>();//post-put

                cfg.CreateMap<Lectura_Cualitativa, Lectura_CualitativaDTO>();//get
                cfg.CreateMap<Lectura_CualitativaDTO, Lectura_Cualitativa>();//post-put

                cfg.CreateMap<Lectura_Cuantitativa, Lectura_CuantitativaDTO>();//get
                cfg.CreateMap<Lectura_CuantitativaDTO, Lectura_Cuantitativa>();//post-put

                cfg.CreateMap<Protocolo, ProtocoloDTO>();//get
                cfg.CreateMap<ProtocoloDTO, Protocolo>();//post-put

                cfg.CreateMap<Repeticion_Cualitativa, Repeticion_CualitativaDTO>();//get
                cfg.CreateMap<Repeticion_CualitativaDTO, Repeticion_Cualitativa>();//post-put

                cfg.CreateMap<Repeticion_Cuantitativa, Repeticion_CuantitativaDTO>();//get
                cfg.CreateMap<Repeticion_CuantitativaDTO, Repeticion_Cuantitativa>();//post-put

                cfg.CreateMap<SintomasNeurologicos, SintomasNeurologicosDTO>();//get
                cfg.CreateMap<SintomasNeurologicosDTO, SintomasNeurologicos>();//post-put

            });
        }
    }
}
