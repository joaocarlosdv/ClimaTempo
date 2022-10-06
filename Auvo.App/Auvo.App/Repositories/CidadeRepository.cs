using Auvo.App.Context;
using Auvo.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auvo.App.Repositories
{
    public class CidadeRepository
    {
        private AppDbContext db;

        public CidadeRepository()
        {
            db = new AppDbContext();
        }

        public List<Cidade> Listar()
        {
            return db.Cidade.ToList();
        }
    }
}