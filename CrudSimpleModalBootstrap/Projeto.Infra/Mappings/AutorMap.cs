using Projeto.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Mappings
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(250).IsRequired();
        }
    }
}
