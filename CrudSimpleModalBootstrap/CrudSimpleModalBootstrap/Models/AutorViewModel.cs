using Projeto.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudSimpleModalBootstrap.Models
{
    public class AutorViewModel
    {
        [Display(Name = "Codigo do Autor")]
        public virtual int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Digite o nome do Autor")]
        [MaxLength(250, ErrorMessage = "Nome do Autor está muito grande, favor abreviar")]
        public virtual string Nome { get; set; }

        public virtual ICollection<LivroViewModel> lstLivros { get; set; }
    }
}
