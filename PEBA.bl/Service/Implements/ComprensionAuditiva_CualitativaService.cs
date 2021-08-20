using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class ComprensionAuditiva_CualitativaService:GenericService<ComprensionAuditiva_Cualitativa>, IComprensionAuditiva_CualitativaService
    {
        public ComprensionAuditiva_CualitativaService(IComprensionAuditiva_Cualitativa comprensionAuditiva_Cualitativa):base(comprensionAuditiva_Cualitativa)
        {

        }
    }
}
