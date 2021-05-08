using AutoMapper;

namespace Api.profile
{
    public class GithubDataProfile : Profile
    {
        public GithubDataProfile()
        {
            CreateMap<Models.GithubData, Models.GithubDataToReturn>()
            .ForMember(
                dest => dest.imgUrl,
                opt => opt.MapFrom(src => src.owner.avatar_url)
            )
            .ForMember(
                dest => dest.Title,
                opt => opt.MapFrom(src => src.full_name)
            )
            .ForMember(
                dest => dest.SubTitle,
                opt => opt.MapFrom(src => src.description)
            );
        }
    }
}