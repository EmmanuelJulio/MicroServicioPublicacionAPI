using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIO.COMANDOS
{
   public interface IGenericRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        IEnumerable<T> GetALL<T>() where T : class;

        T GetBy<T>(int id) where T : class;

        T GetByCodigo<T>(string codigo) where T : class;
    }
}
