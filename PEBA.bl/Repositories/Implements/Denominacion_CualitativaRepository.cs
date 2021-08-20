using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Denominacion_CualitativaRepository:GenericRepository<Denominacion_Cualitativa>, IDenominacion_Cualitativa

    {
        public Denominacion_CualitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
