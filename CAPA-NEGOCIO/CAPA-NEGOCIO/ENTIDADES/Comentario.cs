using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CAPA_NEGOCIO.ENTIDADES
{
   public class Comentario
    {
        [Key]
        private int id;
        private string comentarios;
        private DateTime fecha;
        //un comentario
        //legumbre
        public int Id { get => id; set => id = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
