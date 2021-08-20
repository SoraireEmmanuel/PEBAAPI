using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Repeticion_CualitativaService:GenericService<Repeticion_Cualitativa>,IRepeticion_CualitativaService
    {
        public Repeticion_CualitativaService(IRepeticion_Cualitativa repeticion_Cualitativa):base(repeticion_Cualitativa)
        {

        }
    }
}
