﻿using PEBA.bl.Data;
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
    public class Denominacion_CualitativasController : ApiController
    {
        private AutoMapper.IMapper mapper;
        private readonly Denominacion_CualitativaService denominacion_CualitativaService = new Denominacion_CualitativaService(new Denominacion_CualitativaRepository(PEBAContext.Create()));
        public Denominacion_CualitativasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var model = await denominacion_CualitativaService.GetAll();
            var modelDTO = model.Select(x => mapper.Map<Denominacion_CualitativaDTO>(x));
            return Ok(modelDTO);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var model = await denominacion_CualitativaService.GetById(id);
            if (model == null)
                return NotFound();
            var modeldto = mapper.Map<Denominacion_CualitativaDTO>(model);
            return Ok(modeldto);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Denominacion_CualitativaDTO denominacion_CualitativaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var model = mapper.Map<Denominacion_Cualitativa>(denominacion_CualitativaDTO);
                model = await denominacion_CualitativaService.Insert(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }



    }
}
