using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Models;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class Lectura_CuantitativaService:GenericService<Lectura_Cuantitativa>, ILectura_CuantitativaService
    {
        public Lectura_CuantitativaService(ILectura_Cuantitativa lectura_Cuantitativa):base(lectura_Cuantitativa)
        {

        }
    }
}
