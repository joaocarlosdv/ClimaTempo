using Auvo.App.Models;
using System.Data.Entity.ModelConfiguration;

namespace Auvo.App.Configuratios
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            ToTable("Estado");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("id");
            Property(x => x.Nome).HasColumnName("nome");
            Property(x => x.UF).HasColumnName("uf");
        }
    }
}