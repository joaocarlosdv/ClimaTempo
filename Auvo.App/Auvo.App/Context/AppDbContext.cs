using Auvo.App.Configuratios;
using Auvo.App.Models;
using System.Configuration;
using System.Data.Entity;

namespace Auvo.App.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString)
        {         
        }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new CidadeConfiguration());
            modelBuilder.Configurations.Add(new PrevisaoClimaConfiguration());
        }

        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClima { get; set; }
    }
}