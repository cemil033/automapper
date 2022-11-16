using AutoMapper;
using WebApplication5.Models;
using WebApplication5.Models.ViewModels;

namespace WebApplication5.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserSignViewModel>();

            CreateMap<User, UserSignViewModel>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ReverseMap();

        }
    }
}
