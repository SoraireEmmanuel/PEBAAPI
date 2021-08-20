using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PEBA.bl.Data;
using PEBA.bl.DTOs;

namespace PEBA.API.Controllers
{
    [AllowAnonymous]
    public class AccountController : ApiController
    {
        /// <summary>
        /// Metodo encargado de realizar la autenticacion
        /// </summary>
        /// <param name="loginDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult login(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            using (PEBAContext pEBAContext = new PEBAContext())
            {
                var isCredentialValid =  pEBAContext.Profesionals.Where(x => x.Matricula== loginDTO.Matricula && 
                                                            x.PasswordCuenta==loginDTO.PasswordCuenta).ToList();

                if (isCredentialValid.Count==1)
                {
                    var token = TokenGenerator.GenerateTokenJwt(loginDTO.Matricula);
                    return Ok(token);
                }
                else
                    return Unauthorized();//Status code 401

            };

   
        }
    }
}
