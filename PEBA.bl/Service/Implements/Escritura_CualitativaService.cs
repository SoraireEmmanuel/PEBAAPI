using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Escritura_CualitativaService:GenericService<Escritura_Cualitativa>, IEscritura_CualitativaService
    {
        public Escritura_CualitativaService(IEscritura_Cualitativa escritura_Cualitativa):base(escritura_Cualitativa)
        {

        }
    }
}
