using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auvo.App.Models
{
    public class PrevisaoClima
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public Decimal TemperaturaMinima { get; set; }
        public Decimal TemperaturaMaxima { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}