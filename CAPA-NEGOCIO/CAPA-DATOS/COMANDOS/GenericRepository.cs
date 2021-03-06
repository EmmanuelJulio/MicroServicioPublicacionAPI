﻿using CAPA_NEGOCIO.COMANDOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAPA_DATOS.COMANDOS
{
    public class GenericRepository : IGenericRepository
    {
        private readonly Contexto contexto;

        public GenericRepository(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public void Add<T>(T entity) where T : class
        {
            contexto.Add(entity);
           contexto.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }

        public IEnumerable<T> GetALL<T>() where T : class
        {
            DbSet<T> table = null;
            table = contexto.Set<T>();
            return table.ToList();
        }

        public T GetBy<T>(int id) where T : class
        {
            DbSet<T> table = contexto.Set<T>();
            return table.Find(id);
        }

        public T GetByCodigo<T>(string codigo) where T : class
        {
            DbSet<T> table = contexto.Set<T>();
            var tablelist = table.Find(codigo);
            return tablelist;
        }

        public void Update<T>(T entity) where T : class
        {
            contexto.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
