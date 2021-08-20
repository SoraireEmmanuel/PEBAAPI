using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Denominacion_CuantitativaService:GenericService<Denominacion_Cuantitativa>, IDenominacion_CuantitativaService
    {
        public Denominacion_CuantitativaService(IDenominacion_Cuantitativa denominacion_Cuantitativa):base(denominacion_Cuantitativa)
        {

        }
    }
}
