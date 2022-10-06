using Auvo.App.Models;
using System.Data.Entity.ModelConfiguration;

namespace Auvo.App.Configuratios
{
    public class CidadeConfiguration : EntityTypeConfiguration<Cidade>
    {
        public CidadeConfiguration()
        {
            ToTable("Cidade");
            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnName("nome");
            Property(x => x.EstadoId).HasColumnName("estadoId");
            HasRequired(x => x.Estado).WithMany().HasForeignKey(x => x.EstadoId).WillCascadeOnDelete(false);
        }
    }
}