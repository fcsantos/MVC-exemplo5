namespace Projeto.Domain
{
    public class Livro
    {
        public virtual int Id { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Genero { get; set; }
        public virtual string Sinopse { get; set; }
        public virtual int IdAutor { get; set; }

        public virtual Autor Autor { get; set; }
    }
}
