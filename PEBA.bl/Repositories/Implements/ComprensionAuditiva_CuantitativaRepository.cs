using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class ComprensionAuditiva_CuantitativaRepository:GenericRepository<ComprensionAuditiva_Cuantitativa>, IComprensionAuditiva_Cuantitativa
    {
        public ComprensionAuditiva_CuantitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
