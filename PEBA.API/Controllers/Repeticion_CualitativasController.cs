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
    public class Repeticion_CualitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly Repeticion_CualitativaService repeticion_CualitativaService = new Repeticion_CualitativaService(new Repeticion_CualitativaRepository(PEBAContext.Create()));

        public Repeticion_CualitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await repeticion_CualitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<Repeticion_CualitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await repeticion_CualitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<Repeticion_CualitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Repeticion_CualitativaDTO repeticion_CualitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Repeticion_Cualitativa>(repeticion_CualitativaDTO);
                model = await repeticion_CualitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }


    }
}
