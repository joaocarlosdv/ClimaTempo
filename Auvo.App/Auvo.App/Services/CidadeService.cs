using AutoMapper;
using Auvo.App.Dtos;
using Auvo.App.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auvo.App.Services
{
    public class CidadeService
    {
        CidadeRepository cidadeRepositoy;
        IMapper mapper;

        public CidadeService()
        {
            cidadeRepositoy = new CidadeRepository();
            mapper = (HttpContext.Current.Items["Mapper"] as IMapper);
        }

        public List<CidadeDto> Listar()
        {
            return mapper.Map<List<CidadeDto>>(cidadeRepositoy.Listar().OrderBy(x=>x.Estado.Nome).ThenBy(x=>x.Nome));
        }
    }
}