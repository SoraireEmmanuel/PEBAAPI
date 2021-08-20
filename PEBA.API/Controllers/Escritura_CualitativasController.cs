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
    public class Escritura_CualitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly Escritura_CualitativaService escritura_CualitativaService = new Escritura_CualitativaService(new Escritura_CualitativaRepository(PEBAContext.Create()));
        public Escritura_CualitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await escritura_CualitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<Escritura_CualitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await escritura_CualitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<Escritura_CualitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Escritura_CualitativaDTO escritura_CualitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Escritura_Cualitativa>(escritura_CualitativaDTO);
                model = await escritura_CualitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }
    }
}    
