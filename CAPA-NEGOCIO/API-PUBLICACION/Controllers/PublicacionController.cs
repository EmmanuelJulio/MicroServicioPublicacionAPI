using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_APLICACION.SERVICIOS;
using CAPA_NEGOCIO.ENTIDADES;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_PUBLICACION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacionController : ControllerBase
    {
        private readonly IPublicacionService service;

        public PublicacionController(IPublicacionService service)
        {
            this.service = service;
        }
        [HttpPost]
        public IActionResult Post(PublicacionDTO comentario)
        {
            try
            {
                return new JsonResult(service.CrearPublicacion(comentario)) { StatusCode = 201 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}