using System;
using System.Collections.Generic;
using System.Text;

namespace CAPA_NEGOCIO.ENTIDADES
{
   public class ComentarioDTO
    {

        private string comentarios;
        private DateTime fecha;

       
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
