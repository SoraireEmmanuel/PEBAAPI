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
    public class ComprensionAuditiva_CuantitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly ComprensionAuditiva_CuantitativaService comprensionAuditiva_CuantitativaService = new ComprensionAuditiva_CuantitativaService(new ComprensionAuditiva_CuantitativaRepository(PEBAContext.Create()));

        public ComprensionAuditiva_CuantitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await comprensionAuditiva_CuantitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<ComprensionAuditiva_CuantitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await comprensionAuditiva_CuantitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<ComprensionAuditiva_CuantitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(ComprensionAuditiva_CuantitativaDTO comprensionAuditiva_CuantitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<ComprensionAuditiva_Cuantitativa>(comprensionAuditiva_CuantitativaDTO);
                model = await comprensionAuditiva_CuantitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }
    }
}
