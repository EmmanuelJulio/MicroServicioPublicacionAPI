using CAPA_NEGOCIO.COMANDOS;
using CAPA_NEGOCIO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_APLICACION.SERVICIOS
{
    public interface IComentarioService
    {
        Comentario CrearComentario(ComentarioDTO comentario);
    }
    public class ComentarioService :IComentarioService
    {
        private readonly IGenericRepository _repository;

        public ComentarioService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public Comentario CrearComentario(ComentarioDTO comentario)
        {
            var entity = new Comentario
            {
                Comentarios = comentario.Comentarios,
                Fecha = DateTime.Now
            };
            _repository.Add<Comentario>(entity);
            return entity;
        }
    }
}
