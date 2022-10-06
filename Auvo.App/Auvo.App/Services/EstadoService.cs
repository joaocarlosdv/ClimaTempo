using AutoMapper;
using Auvo.App.Dtos;
using Auvo.App.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auvo.App.Services
{
    public class EstadoService
    {
        EstadoRepository estadoRepositoy;
        IMapper mapper;

        public EstadoService()
        {
            estadoRepositoy = new EstadoRepository();
            mapper = (HttpContext.Current.Items["Mapper"] as IMapper);
        }        

        public List<EstadoDto> Listar()
        {
            return mapper.Map<List<EstadoDto>>(estadoRepositoy.Listar().OrderBy(x=>x.Nome));
        }
    }
}