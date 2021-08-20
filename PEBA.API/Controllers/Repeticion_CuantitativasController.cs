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
    public class Repeticion_CuantitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly Repeticion_CuantitativaService repeticion_CuantitativaService= new Repeticion_CuantitativaService(new Repeticion_CuantitativaRepository(PEBAContext.Create()));
        public Repeticion_CuantitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await repeticion_CuantitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<Repeticion_CuantitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await repeticion_CuantitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<Repeticion_CuantitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Repeticion_CuantitativaDTO repeticion_CuantitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Repeticion_Cuantitativa>(repeticion_CuantitativaDTO);
                model = await repeticion_CuantitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }
    }
}
