using Auvo.App.Context;
using Auvo.App.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Auvo.App.Repositories
{
    public class PrevisaoClimaRepository
    {
        private AppDbContext db;

        public PrevisaoClimaRepository()
        {
            db = new AppDbContext();
        }

        public List<PrevisaoClima> Listar()
        {
            return db.PrevisaoClima.ToList();
        }

        public List<PrevisaoClima> ListarPorCidadeId(int cidadeId)
        {
            return db.PrevisaoClima
                .Where(x=>x.CidadeId == cidadeId)
                .ToList();
        }

        public List<PrevisaoClima> ListarPorCidadeId(int cidadeId, DateTime dataInicial, int take)
        {
            return db.PrevisaoClima
                .Where(x => x.CidadeId == cidadeId && x.DataPrevisao >= dataInicial)
                .OrderBy(x=>x.DataPrevisao)
                .Take(take)
                .ToList();
        }

        public List<PrevisaoClima> ListarCidadesMaisQuentesDia(DateTime dataInicial, int quantidade)
        {
            return db.PrevisaoClima
                .Where(x => x.DataPrevisao == dataInicial.Date)
                .OrderByDescending(x => x.TemperaturaMaxima)
                .Take(quantidade)
                .ToList();
        }

        public List<PrevisaoClima> ListarCidadesMaisFriasDia(DateTime dataInicial, int quantidade)
        {
            return db.PrevisaoClima
                .Where(x => x.DataPrevisao == dataInicial.Date)
                .OrderBy(x => x.TemperaturaMinima)
                .Take(quantidade)
                .ToList();
        }
    }
}