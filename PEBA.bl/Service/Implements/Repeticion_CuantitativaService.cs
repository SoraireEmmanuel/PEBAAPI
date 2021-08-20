using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Repeticion_CuantitativaService:GenericService<Repeticion_Cuantitativa>, IRepeticion_CuantitativaService
    {
        public Repeticion_CuantitativaService(IRepeticion_Cuantitativa repeticion_Cuantitativa):base(repeticion_Cuantitativa)
        {

        }
    }
}
