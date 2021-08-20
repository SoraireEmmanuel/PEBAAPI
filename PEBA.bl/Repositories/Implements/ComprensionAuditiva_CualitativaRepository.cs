using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class ComprensionAuditiva_CualitativaRepository : GenericRepository<ComprensionAuditiva_Cualitativa>, IComprensionAuditiva_Cualitativa
    {
        public ComprensionAuditiva_CualitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
