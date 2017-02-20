using System.Collections.Generic;

namespace Projeto.Domain
{
    public class Autor
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
