using AutoMapper;
using EntityPractice.Controllers.Resources;
using EntityPractice.Models;

namespace EntityPractice.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}