using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class Lectura_CualitativaRepository:GenericRepository<Lectura_Cualitativa>,ILectura_Cualitativa
    {
        public Lectura_CualitativaRepository(PEBAContext pEBA):base(pEBA)
        {

        }
    }
}
