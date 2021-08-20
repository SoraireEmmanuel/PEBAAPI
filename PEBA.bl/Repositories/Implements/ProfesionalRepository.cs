using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class ProfesionalRepository:GenericRepository<Profesional>, IProfesional
    {
        public ProfesionalRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
