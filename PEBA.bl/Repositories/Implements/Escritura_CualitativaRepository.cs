using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Escritura_CualitativaRepository:GenericRepository<Escritura_Cualitativa>, IEscritura_Cualitativa
    {
        public Escritura_CualitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
