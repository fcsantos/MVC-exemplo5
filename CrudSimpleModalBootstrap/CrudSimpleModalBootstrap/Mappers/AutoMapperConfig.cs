using AutoMapper;

namespace CrudSimpleModalBootstrap.Mappers
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(
                m =>
                {
                    m.AddProfile<EntityToModelMapping>();
                    m.AddProfile<ModelToEntityMapping>();
                }
            );
        }
    }
}
