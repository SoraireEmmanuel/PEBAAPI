using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class ExpresionOral_CualitativaService:GenericService<ExpresionOral_Cualitativa>, IExpresionOral_CualitativaService
    {
        public ExpresionOral_CualitativaService(IExpresionOral_Cualitativa expresionOral_Cualitativa):base(expresionOral_Cualitativa)
        {

        }
    }
}
