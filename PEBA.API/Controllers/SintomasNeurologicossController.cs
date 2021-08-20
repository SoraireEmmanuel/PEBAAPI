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
    public class SintomasNeurologicossController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly SintomasNeurologicosService sintomasNeurologicosService= new SintomasNeurologicosService(new SintomasNeurologicosRepository(PEBAContext.Create()));

        public SintomasNeurologicossController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await sintomasNeurologicosService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<SintomasNeurologicosDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await sintomasNeurologicosService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<SintomasNeurologicosDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(SintomasNeurologicosDTO sintomasNeurologicosDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<SintomasNeurologicos>(sintomasNeurologicosDTO);
                model = await sintomasNeurologicosService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }



    }
}
