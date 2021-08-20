using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class PacienteRepository:GenericRepository<Paciente>, IPaciente
    {
        
        public PacienteRepository(PEBAContext pEBAContext):base(pEBAContext)
        {
        
        }

    }
}
