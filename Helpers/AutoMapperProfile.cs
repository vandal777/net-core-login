using AutoMapper;
using WebApi.Dtos;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Tool, ToolDto>();
            CreateMap<ToolDto, Tool>();
            CreateMap<Resource, ResourceDto>();
            CreateMap<ResourceDto, Resource>();
        }
    }
}