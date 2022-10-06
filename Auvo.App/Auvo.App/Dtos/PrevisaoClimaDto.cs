using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Auvo.App.Dtos
{
    public class PrevisaoClimaDto
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataPrevisao { get; set; }
        public string Clima { get; set; }
        public Decimal TemperaturaMinima { get; set; }
        public Decimal TemperaturaMaxima { get; set; }
        public CidadeDto Cidade { get; set; }

        public string DiaSemana
        {
            get
            {
                return DataPrevisao.ToString("dddd", new CultureInfo("pt-BR"));
            }
        }
    }
}