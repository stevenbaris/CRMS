using AutoMapper;
using ProductAPI.DTO;
using ProductAPI.Models;

namespace ProductAPI.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<ApplicationUser, RegisterDTO>().ReverseMap()
            .ForMember(dest => dest.UserName, t2 => t2.MapFrom(src => src.Email));


            
        }
    }
}
