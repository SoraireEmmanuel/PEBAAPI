using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class ExpresionOral_CuantitativaService:GenericService<ExpresionOral_Cuantitativa>, IExpresionOral_CuantitativaService
    {
        public ExpresionOral_CuantitativaService(IExpresionOral_Cuantitativa expresionOral_Cuantitativa):base(expresionOral_Cuantitativa)
        {
                
        }
    }
}
