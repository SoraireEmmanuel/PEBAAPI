using PEBA.bl.Data;
using PEBA.bl.DTOs;
using PEBA.bl.Models;
using PEBA.bl.Repositories.Implements;
using PEBA.bl.Service.Implements;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System;
using System.Data.Entity;

namespace PEBA.API.Controllers
{
    public class PacientesController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly PacienteService pacienteService= new PacienteService(new PacienteRepository(PEBAContext.Create()));
       
        public PacientesController()
        {
            
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await pacienteService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<PacienteDTO>(x));
            
            return Ok(modelDTO);
        }
        /// <summary>
        /// Prueba de consulta sin usar los services ni los repositories
        /// </summary>
        /// <param name="pacienteDTO"></param>
        /// <returns></returns>
        [Route("api/GetByProfesional/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetByProfesional(int id)
        {

            using (PEBAContext pEBAContext = new PEBAContext())
            {
                var model = await pEBAContext.Pacientes.Where(x => x.Id_Profesional == id).ToListAsync();
                if (model == null)
                    return NotFound();
                var modelDTO = model.Select(x => mapper.Map<PacienteDTO>(x));
                return Ok(modelDTO);
            };           
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(PacienteDTO pacienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Paciente>(pacienteDTO);
                model = await pacienteService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }



    }
}
