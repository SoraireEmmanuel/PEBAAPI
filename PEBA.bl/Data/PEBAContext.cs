using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PEBA.bl.Models;

namespace PEBA.bl.Data
{
    public class PEBAContext : DbContext
    {
        private static PEBAContext pEBAContext = null;
        public PEBAContext()
             :base("PEBAContext")
        {
            
        }
        public DbSet<Profesional> Profesionals { get; set; }
        public DbSet<ComprensionAuditiva_Cualitativa> ComprensionAuditiva_Cualitativas  { get; set; }
        public DbSet<ComprensionAuditiva_Cuantitativa> ComprensionAuditiva_Cuantitativas { get; set; }
        public DbSet<Denominacion_Cuantitativa> Denominacion_Cuantitativas{ get; set; }
        public DbSet<Denominacion_Cualitativa> Denominacion_Cualitativas{ get; set; }
        public DbSet<Escritura_Cualitativa> Escritura_Cualitativas{ get; set; }
        public DbSet<Escritura_Cuantitativa> Escritura_Cuantitativas{ get; set; }
        public DbSet<ExpresionOral_Cualitativa> ExpresionOral_Cualitativas{ get; set; }
        public DbSet<ExpresionOral_Cuantitativa> ExpresionOral_Cuantitativas{ get; set; }
        public DbSet<Lectura_Cualitativa> Lectura_Cualitativas{ get; set; }
        public DbSet<Lectura_Cuantitativa> Lectura_Cuantitativas{ get; set; }
        public DbSet<Paciente> Pacientes{ get; set; }
        public DbSet<Repeticion_Cualitativa> Repeticion_Cualitativas{ get; set; }
        public DbSet<Repeticion_Cuantitativa> Repeticion_Cuantitativas{ get; set; }
        public DbSet<SintomasNeurologicos> SintomasNeurologicos{ get; set; }
        public DbSet<Protocolo> Protocolos { get; set; }
        public static PEBAContext Create()
        {
    

            return new PEBAContext();
        }
    }
}
