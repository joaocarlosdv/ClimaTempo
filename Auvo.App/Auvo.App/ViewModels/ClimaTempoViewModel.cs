using Auvo.App.Dtos;
using System.Collections.Generic;

namespace Auvo.App.ViewModels
{
    public class ClimaTempoViewModel
    {
        public List<PrevisaoClimaDto> MaisQuentes { get; set; }
        public List<PrevisaoClimaDto> MaisFrias { get; set; }
        public List<CidadeDto> Cidades { get; set; }
    }
}