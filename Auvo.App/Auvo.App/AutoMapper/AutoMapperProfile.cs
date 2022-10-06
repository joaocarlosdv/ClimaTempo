using AutoMapper;
using Auvo.App.Dtos;
using Auvo.App.Models;

namespace Auvo.App.AutoMapper
{
    public static class AutoMapperProfile
    {
        public static IMapper CreateConfig()
        {
            var config = new MapperConfiguration(map => 
            { 
                map.CreateMap<Estado, EstadoDto>();
                map.CreateMap<Cidade, CidadeDto>();
                map.CreateMap<PrevisaoClima, PrevisaoClimaDto>();
            }).CreateMapper();

            return config;
        }        
    }
}