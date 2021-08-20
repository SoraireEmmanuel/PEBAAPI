using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PEBA.bl.Data;
using PEBA.bl.Service.Implements;
using PEBA.bl.Repositories.Implements;
using System.Threading.Tasks;
using PEBA.bl.DTOs;
using PEBA.bl.Models;
using System.Data.Entity;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;

namespace PEBA.API.Controllers
{
    public class ProfesionalesController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly ProfesionalService profesionalService = new ProfesionalService(new ProfesionalRepository(PEBAContext.Create()));

        public ProfesionalesController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var profesionales = await profesionalService.GetAll();
            var profesionalesDTO = profesionales.Select(x => mapper.Map<ProfesionalDTO>(x));
            return Ok(profesionalesDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var profesional = await profesionalService.GetById(id);
            if (profesional == null)
                return NotFound();

            var profesionalDTO = mapper.Map<ProfesionalDTO>(profesional);
            return Ok(profesionalDTO);
        }
        /// <summary>
        /// recupera el Id de un profesional pasandole la matricula
        /// </summary>
        /// <param name="profesionalDTO"></param>
        /// <returns></returns>
        [Route("api/GetIdProfesion/{matricula}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetByMatricula(string matricula)
        {
            using (PEBAContext pEBAContext = new PEBAContext())
            {         
                var model = await pEBAContext.Profesionals.Where(x => x.Matricula == matricula).ToListAsync();
                  if (model == null)
                      return NotFound();
                  var modelDTO = model.Select(x => mapper.Map<ProfesionalDTO>(x));

              //  string js = JsonConvert.SerializeObject(model); 
                
                return Ok(modelDTO);               
            };
     //       var profesional = await profesionalService.GetById(id);
     //       if (profesional == null)
     //           return NotFound();
     //
     //       var profesionalDTO = mapper.Map<ProfesionalDTO>(profesional);
     //       return Ok(profesionalDTO);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(ProfesionalDTO profesionalDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var model = mapper.Map<Profesional>(profesionalDTO);
                model = await profesionalService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        
    }
}
