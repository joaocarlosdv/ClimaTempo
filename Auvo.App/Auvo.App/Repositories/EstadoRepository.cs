using Auvo.App.Context;
using Auvo.App.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Auvo.App.Repositories
{
    public class EstadoRepository
    {
        private AppDbContext db;

        public EstadoRepository()
        {
            db = new AppDbContext();
        }

        public List<Estado> Listar()
        {
            return db.Estado.ToList();
        }
    }
}