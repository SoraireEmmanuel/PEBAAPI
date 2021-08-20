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
    public class Lectura_CuantitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly Lectura_CuantitativaService lectura_CuantitativaService= new Lectura_CuantitativaService(new Lectura_CuantitativaRepository(PEBAContext.Create()));

        public Lectura_CuantitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await lectura_CuantitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<Lectura_CuantitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await lectura_CuantitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<Lectura_CuantitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Lectura_CuantitativaDTO lectura_CuantitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Lectura_Cuantitativa>(lectura_CuantitativaDTO);
                model = await lectura_CuantitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }

    }
}
