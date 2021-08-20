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
    public class ExpresionOral_CuantitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly ExpresionOral_CuantitativaService expresionOral_CuantitativaService= new ExpresionOral_CuantitativaService(new ExpresionOral_CuantitativaRepository(PEBAContext.Create()));

        public ExpresionOral_CuantitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await expresionOral_CuantitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<ExpresionOral_CuantitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await expresionOral_CuantitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<ExpresionOral_CuantitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(ExpresionOral_CuantitativaDTO expresionOral_CuantitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<ExpresionOral_Cuantitativa>(expresionOral_CuantitativaDTO);
                model = await expresionOral_CuantitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }

    }
}
