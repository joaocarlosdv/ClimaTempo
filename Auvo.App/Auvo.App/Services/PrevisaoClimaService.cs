using AutoMapper;
using Auvo.App.Dtos;
using Auvo.App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auvo.App.Services
{
    public class PrevisaoClimaService
    {
        PrevisaoClimaRepository previsaoClimaRepository;
        IMapper mapper;

        public PrevisaoClimaService()
        {
            previsaoClimaRepository = new PrevisaoClimaRepository();
            mapper = (HttpContext.Current.Items["Mapper"] as IMapper);
        }

        public List<PrevisaoClimaDto> Listar()
        {
            return mapper.Map<List<PrevisaoClimaDto>>(previsaoClimaRepository.Listar());
        }

        public List<PrevisaoClimaDto> ListarPorCidadeId(int cidadeId)
        {
            return mapper.Map<List<PrevisaoClimaDto>>(previsaoClimaRepository.ListarPorCidadeId(cidadeId));
        }

        public List<PrevisaoClimaDto> ListarPorCidadeId(int cidadeId, DateTime dataInicial, int take)
        {
            return mapper.Map<List<PrevisaoClimaDto>>(previsaoClimaRepository.ListarPorCidadeId(cidadeId, dataInicial, take));
        }

        public List<PrevisaoClimaDto> ListarCidadesMaisQuentesDia(DateTime dataInicial, int quantidade)
        {
            return mapper.Map<List<PrevisaoClimaDto>>(previsaoClimaRepository.ListarCidadesMaisQuentesDia(dataInicial, quantidade));
        }

        public List<PrevisaoClimaDto> ListarCidadesMaisFriasDia(DateTime dataInicial, int quantidade)
        {
            return mapper.Map<List<PrevisaoClimaDto>>(previsaoClimaRepository.ListarCidadesMaisFriasDia(dataInicial, quantidade));
        }
    }
}