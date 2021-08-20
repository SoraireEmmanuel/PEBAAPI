using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PEBA.bl.DTOs
{
    public class HistorialDTO
    {

        public string Cod_Paciente { get; set; }
        public string Fecha_Protocolo { get; set; }
        public double Total { get; set; }
    }
}
