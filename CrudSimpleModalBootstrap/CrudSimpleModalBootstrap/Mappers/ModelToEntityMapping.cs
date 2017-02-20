using AutoMapper;
using CrudSimpleModalBootstrap.Models;
using Projeto.Domain;

namespace CrudSimpleModalBootstrap.Mappers
{
    public class ModelToEntityMapping : Profile
    {
        public ModelToEntityMapping()
        {
            CreateMap<AutorViewModel, Autor>();
            CreateMap<LivroViewModel, Livro>();
        }
    }
}
