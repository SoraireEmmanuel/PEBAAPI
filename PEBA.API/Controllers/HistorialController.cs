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

    public class HistorialController : ApiController
    {
        private AutoMapper.IMapper mapper;
        public HistorialController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        /// <summary>
        /// Retorna la info de los protocolo de un paciente por ID del paciente.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/GetByPacienteId/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetByPacienteId(int id)
        {

            using (PEBAContext pEBAContext = new PEBAContext())
            {
                var model = await (from a in pEBAContext.Pacientes
                                   join b in pEBAContext.Protocolos on a.Id_Paciente equals b.Id_Paciente
                                   where( a.Id_Paciente==id)
                                   select new { Cod_Paciente = a.Cod_Paciente, Fecha_Protocolo = b.Fecha_Protocolo, Total = b.Total }).ToListAsync();  

                if (model == null)
                    return NotFound();
                var modelDTO = model.Select(x => mapper.Map<HistorialDTO>(x));//Esta linea no la puedo validar con el DTO
                return Ok(model);
            };
        }
        /// <summary>
        /// Retorna la informacion de los protocolos de todos los pacientes de un profesional.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/GetByProfesionalId/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetByProfesionalId(int id)
        {

            using (PEBAContext pEBAContext = new PEBAContext())
            {
                var model = await (from a in pEBAContext.Pacientes
                                   join b in pEBAContext.Protocolos on a.Id_Paciente equals b.Id_Paciente
                                   where(b.Id_Profesional==id)
                                   select new { Cod_Paciente = a.Cod_Paciente, Fecha_Protocolo = b.Fecha_Protocolo, Total = b.Total }).ToListAsync();

                if (model == null)
                    return NotFound();
                var modelDTO = model.Select(x => mapper.Map<HistorialDTO>(x));//Esta linea no la puedo validar con el DTO
                return Ok(model);
            };
        }

    }
}
