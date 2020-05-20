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
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioService service;

        public ComentarioController(IComentarioService service)
        {
            this.service = service;
        }
        [HttpPost]
        public IActionResult Post(ComentarioDTO comentario)
        {
            try
            {
                return new JsonResult(service.CrearComentario(comentario)) { StatusCode = 201 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }


    }
}