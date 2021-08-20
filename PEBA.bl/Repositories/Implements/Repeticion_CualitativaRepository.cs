using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Repeticion_CualitativaRepository:GenericRepository<Repeticion_Cualitativa>, IRepeticion_Cualitativa
    {
        public Repeticion_CualitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
