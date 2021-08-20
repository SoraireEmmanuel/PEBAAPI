using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PEBA.bl.Service.Implements;
using PEBA.bl.Repositories.Implements;
using PEBA.bl.Data;
using System.Threading.Tasks;
using PEBA.bl.DTOs;
using PEBA.bl.Models;

namespace PEBA.API.Controllers
{

    public class ComprensionAuditiva_CualitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly ComprensionAuditiva_CualitativaService comprensionAuditiva_CualitativaService = new ComprensionAuditiva_CualitativaService(new ComprensionAuditiva_CualitativaRepository(PEBAContext.Create()));

        public ComprensionAuditiva_CualitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var ComprensionAuditiva_Cualitativa = await comprensionAuditiva_CualitativaService.GetAll();
            var ComprensionAuditiva_CualitativaDTO = ComprensionAuditiva_Cualitativa.Select(x => mapper.Map<ComprensionAuditiva_CualitativaDTO>(x));
            return Ok(ComprensionAuditiva_CualitativaDTO);
        }
       [HttpGet]
       public async Task<IHttpActionResult> GetById(int id)
        {
            var ComprensionAuditiva_Cualitativa = await comprensionAuditiva_CualitativaService.GetById(id);
            if (ComprensionAuditiva_Cualitativa== null)
                return NotFound();
            var ComprensionAuditiva_CualitativaDTO = mapper.Map<ComprensionAuditiva_CualitativaDTO>(ComprensionAuditiva_Cualitativa);
            return Ok(ComprensionAuditiva_CualitativaDTO);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(ComprensionAuditiva_CualitativaDTO comprensionAuditiva_CualitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<ComprensionAuditiva_Cualitativa>(comprensionAuditiva_CualitativaDTO);
                model = await comprensionAuditiva_CualitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }
    }
}

