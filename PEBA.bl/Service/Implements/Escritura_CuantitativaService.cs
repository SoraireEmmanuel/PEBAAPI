using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Escritura_CuantitativaService:GenericService<Escritura_Cuantitativa>, IEscritura_CuantitativaService
    {
        public Escritura_CuantitativaService(IEscritura_Cuantitativa escritura_Cuantitativa):base(escritura_Cuantitativa)
        {

        }
    }
}
