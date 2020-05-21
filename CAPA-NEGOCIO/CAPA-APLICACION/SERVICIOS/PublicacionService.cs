using CAPA_NEGOCIO.COMANDOS;
using CAPA_NEGOCIO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_APLICACION.SERVICIOS
{
    public interface IPublicacionService
    {
        object CrearPublicacion(PublicacionDTO comentario);
    }
    public class PublicacionService :IPublicacionService
    {
        private readonly IGenericRepository _repository;

        public PublicacionService(IGenericRepository repository)
        {
            _repository = repository;
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public object CrearPublicacion(PublicacionDTO comentario)
        {
            var entidad = new Publicacion()
            {
                ProductoID = comentario.ProductoID,
                
            };
            _repository.Add(entidad);
            return entidad;
        }
    }
}
