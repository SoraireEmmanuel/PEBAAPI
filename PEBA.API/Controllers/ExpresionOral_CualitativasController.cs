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
    public class ExpresionOral_CualitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly ExpresionOral_CualitativaService expresionOral_CualitativaService = new ExpresionOral_CualitativaService(new ExpresionOral_CualitativaRepository(PEBAContext.Create()));
        public ExpresionOral_CualitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await expresionOral_CualitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<ExpresionOral_CualitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await expresionOral_CualitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<ExpresionOral_CualitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(ExpresionOral_CualitativaDTO expresionOral_CualitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<ExpresionOral_Cualitativa>(expresionOral_CualitativaDTO);
                model = await expresionOral_CualitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }


    }
}
