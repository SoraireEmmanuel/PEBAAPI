using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class SintomasNeurologicosRepository:GenericRepository<SintomasNeurologicos>, ISintomasNeurologicos
    {
        public SintomasNeurologicosRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
