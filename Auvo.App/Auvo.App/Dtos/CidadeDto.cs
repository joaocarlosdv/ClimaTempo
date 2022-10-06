using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auvo.App.Dtos
{
    public class CidadeDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public virtual EstadoDto Estado { get; set; }
    }
}