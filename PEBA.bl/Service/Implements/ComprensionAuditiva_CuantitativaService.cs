using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class ComprensionAuditiva_CuantitativaService:GenericService<ComprensionAuditiva_Cuantitativa>, IComprensionAuditiva_CuantitativaService
    {
        public ComprensionAuditiva_CuantitativaService(IComprensionAuditiva_Cuantitativa comprensionAuditiva_Cuantitativa):base(comprensionAuditiva_Cuantitativa)
        {
                        
        }
    }
}
