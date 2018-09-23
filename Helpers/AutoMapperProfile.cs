using AutoMapper;
using WebApi.Dtos;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserEntity, UserDto>();
            CreateMap<UserDto, UserEntity>();
            CreateMap<ToolEntity, ToolDto>();
            CreateMap<ToolDto, ToolEntity>();
            CreateMap<ResourceEntity, ResourceDto>();
            CreateMap<ResourceDto, ResourceEntity>();
        }
    }
}