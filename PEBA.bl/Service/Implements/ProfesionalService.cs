using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class ProfesionalService:GenericService<Profesional>, IProfesionalService
    {
        public ProfesionalService(IProfesional profesional):base(profesional)
        {

        }
    }
}
