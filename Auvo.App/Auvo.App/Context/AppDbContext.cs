using Auvo.App.Configuratios;
using Auvo.App.Models;
using System.Configuration;
using System.Data.Entity;

namespace Auvo.App.Context
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext() : base("Data Source=DESKTOP-DFE5OOJ\\SQLEXPRESS;Initial Catalog=ClimaTempoSimples;Persist Security Info=True;User ID=sa;Password=123; Min Pool Size=5;Max Pool Size=500; Connect Timeout=10") 
        //public AppDbContext() : base(ConfigurationManager.ConnectionStrings["conn"].ConnectionString)
        //public AppDbContext() : base("name=conn")
        { }

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