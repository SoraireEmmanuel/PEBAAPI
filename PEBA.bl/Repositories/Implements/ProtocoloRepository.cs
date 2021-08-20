﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEBA.bl.Data;
using PEBA.bl.Models;

namespace PEBA.bl.Repositories.Implements
{
    public class ProtocoloRepository:GenericRepository<Protocolo>, IProtocolo
    {
        public ProtocoloRepository(PEBAContext pEBAContext):base(pEBAContext)
        {

        }
    }
}
