using PEBA.bl.Data;
using PEBA.bl.DTOs;
using PEBA.bl.Models;
using PEBA.bl.Repositories.Implements;
using PEBA.bl.Service.Implements;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System;
using System.Data.Entity;

namespace PEBA.API.Controllers
{
    public class ProtocoloFormController : ApiController
    {
        private AutoMapper.IMapper mapper;
        public ProtocoloFormController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

    }
}
