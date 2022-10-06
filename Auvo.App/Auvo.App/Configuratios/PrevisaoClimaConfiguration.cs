using Auvo.App.Models;
using System.Data.Entity.ModelConfiguration;

namespace Auvo.App.Configuratios
{
    public class PrevisaoClimaConfiguration : EntityTypeConfiguration<PrevisaoClima>
    {
        public PrevisaoClimaConfiguration()
        {
            ToTable("PrevisaoClima");
            HasKey(x => x.Id);

            Property(x => x.CidadeId).HasColumnName("cidadeId");
            Property(x => x.DataPrevisao).HasColumnName("dataPrevisao");
            Property(x => x.Clima).HasColumnName("clima");
            Property(x => x.TemperaturaMaxima).HasColumnName("temperaturaMaxima");
            Property(x => x.TemperaturaMinima).HasColumnName("temperaturaMinima");
            HasRequired(x => x.Cidade).WithMany().HasForeignKey(x => x.CidadeId).WillCascadeOnDelete(false);
        }
    }
}