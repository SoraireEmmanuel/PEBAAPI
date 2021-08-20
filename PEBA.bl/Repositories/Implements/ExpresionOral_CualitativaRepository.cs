using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class ExpresionOral_CualitativaRepository:GenericRepository<ExpresionOral_Cualitativa>, IExpresionOral_Cualitativa
    {
        public ExpresionOral_CualitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
