﻿using CAPA_NEGOCIO.ENTIDADES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_DATOS
{
   public class Contexto :DbContext
    {
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }

        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones)
        {

        }
    }
}
