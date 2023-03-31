using AutoMapper;
using CustomersAPI.DTO;
using CustomersAPI.Models;
using System.Runtime;

namespace CustomersAPI.Configuration
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
