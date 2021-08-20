using PEBA.bl.Data;
using PEBA.bl.DTOs;
using PEBA.bl.Models;
using PEBA.bl.Repositories.Implements;
using PEBA.bl.Service.Implements;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System;

namespace PEBA.API.Controllers
{
    public class ProtocolosController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly ProtocoloService protocoloService= new ProtocoloService(new ProtocoloRepository(PEBAContext.Create()));

        public ProtocolosController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await protocoloService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<ProtocoloDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await protocoloService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<ProtocoloDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(ProtocoloDTO protocoloDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Protocolo>(protocoloDTO);
                model = await protocoloService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }
    }
}
