using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Denominacion_CuantitativaRepository:GenericRepository<Denominacion_Cuantitativa>, IDenominacion_Cuantitativa
    {
        public Denominacion_CuantitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
