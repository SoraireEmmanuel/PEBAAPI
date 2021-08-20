using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Lectura_CuantitativaRepository:GenericRepository<Lectura_Cuantitativa>,ILectura_Cuantitativa
    {
        public Lectura_CuantitativaRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
