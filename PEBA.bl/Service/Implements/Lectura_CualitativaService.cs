using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Lectura_CualitativaService:GenericService<Lectura_Cualitativa>, ILectura_CualitativaService
    {
        public Lectura_CualitativaService(ILectura_Cualitativa lectura_Cualitativa):base(lectura_Cualitativa)
        {

        }
    }
}
