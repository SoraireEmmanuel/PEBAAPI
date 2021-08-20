using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PEBA.bl.Models;
using PEBA.bl.Repositories;
using System.Threading.Tasks;

namespace PEBA.bl.Service.Implements
{
    public class SintomasNeurologicosService:GenericService<SintomasNeurologicos>, ISintomasNeurologicosService
    {
        public SintomasNeurologicosService(ISintomasNeurologicos sintomasNeurologicos):base(sintomasNeurologicos)
        {

        }
    }
}
