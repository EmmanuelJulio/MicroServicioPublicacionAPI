using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_APLICACION.SERVICIOS;
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
    }
}