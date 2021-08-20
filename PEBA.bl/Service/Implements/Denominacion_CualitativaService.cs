using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Denominacion_CualitativaService:GenericService<Denominacion_Cualitativa>, IDenominacion_CualitativaService
    {
        public Denominacion_CualitativaService(IDenominacion_Cualitativa denominacion_Cualitativa):base(denominacion_Cualitativa)
        {

        }
    }
}
