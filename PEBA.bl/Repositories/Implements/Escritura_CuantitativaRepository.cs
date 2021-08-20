using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Escritura_CuantitativaRepository:GenericRepository<Escritura_Cuantitativa>, IEscritura_Cuantitativa
    {
        public Escritura_CuantitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
