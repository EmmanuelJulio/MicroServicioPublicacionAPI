using CAPA_NEGOCIO.COMANDOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_APLICACION.SERVICIOS
{
   public interface IPublicacionService
    {

    }
   public class PublicacionService :IPublicacionService
    {
        private readonly IGenericRepository _repository;

        public PublicacionService(IGenericRepository repository)
        {
            _repository = repository;
        }
    }
}
