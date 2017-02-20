using Projeto.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Mappings
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");

            HasKey(x => x.Id);

            Property(x => x.Titulo).HasMaxLength(150).IsRequired();
            Property(x => x.Genero).HasMaxLength(50).IsRequired();
            Property(x => x.Sinopse).HasMaxLength(250).IsOptional();

            HasRequired(x => x.Autor);
        }
    }
}
