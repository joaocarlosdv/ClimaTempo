﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auvo.App.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}