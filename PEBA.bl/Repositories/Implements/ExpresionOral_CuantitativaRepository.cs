using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class ExpresionOral_CuantitativaRepository:GenericRepository<ExpresionOral_Cuantitativa>, IExpresionOral_Cuantitativa
    {
        public ExpresionOral_CuantitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
