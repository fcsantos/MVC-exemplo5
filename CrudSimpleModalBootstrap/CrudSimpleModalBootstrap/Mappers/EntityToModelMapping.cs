using AutoMapper;
using CrudSimpleModalBootstrap.Models;
using Projeto.Domain;

namespace CrudSimpleModalBootstrap.Mappers
{
    public class EntityToModelMapping : Profile
    {
        public EntityToModelMapping()
        {
            CreateMap<Livro, LivroViewModel>()
                .ForMember(dest => dest.IdAutor, m => m.MapFrom(p => p.Autor.Id))
                .ForMember(dest => dest.NomeAutor, m => m.MapFrom(p => p.Autor.Nome));

            CreateMap<Autor, AutorViewModel>();
        }
    }
}
