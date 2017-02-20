using Projeto.Domain;
using System.ComponentModel.DataAnnotations;
namespace CrudSimpleModalBootstrap.Models
{
    public  class LivroViewModel
    {
        public virtual int Id { get; set; }

        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "Titulo o nome do Livro")]
        [MaxLength(150, ErrorMessage = "Titulo do Livro está muito grande, favor abreviar")]
        public virtual string Titulo { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "Genero do Livro")]
        [MaxLength(50, ErrorMessage = "Genero do Livro está muito grande, favor abreviar")]
        public virtual string Genero { get; set; }

        [Display(Name = "Sinopse")]
        [Required(ErrorMessage = "Sinopse do Livro")]
        [MaxLength(250, ErrorMessage = "Sinopse do Livro está muito grande, favor abreviar")]
        public virtual string Sinopse { get; set; }      

        public virtual int IdAutor { get; set; }

        public virtual string NomeAutor { get; set; }

        public virtual AutorViewModel Autor { get; set; }
    }
}