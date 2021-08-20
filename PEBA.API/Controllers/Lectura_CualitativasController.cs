using PEBA.bl.Data;
using System;
using PEBA.bl.DTOs;
using PEBA.bl.Models;
using PEBA.bl.Repositories.Implements;
using PEBA.bl.Service.Implements;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace PEBA.API.Controllers
{
    public class Lectura_CualitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly Lectura_CualitativaService lectura_CualitativaService = new Lectura_CualitativaService(new Lectura_CualitativaRepository(PEBAContext.Create()));
        public Lectura_CualitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await lectura_CualitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<Lectura_CualitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await lectura_CualitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<Lectura_CualitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Lectura_CualitativaDTO lectura_CualitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Lectura_Cualitativa>(lectura_CualitativaDTO);
                model = await lectura_CualitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }
    }
}
