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
    public class Denominacion_CuantitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly Denominacion_CuantitativaService denominacion_CuantitativaService = new Denominacion_CuantitativaService(new Denominacion_CuantitativaRepository(PEBAContext.Create()));

        public Denominacion_CuantitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await denominacion_CuantitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<Denominacion_CuantitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await denominacion_CuantitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<Denominacion_CuantitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Denominacion_CuantitativaDTO denominacion_CuantitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Denominacion_Cuantitativa>(denominacion_CuantitativaDTO);
                model = await denominacion_CuantitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }


    }
}
