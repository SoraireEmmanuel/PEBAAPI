using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Repeticion_CuantitativaRepository:GenericRepository<Repeticion_Cuantitativa>,IRepeticion_Cuantitativa
    {
        public Repeticion_CuantitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
