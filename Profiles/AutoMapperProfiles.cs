
using AutoMapper;
using MovieSearchAPI.DomainModels;
using DataModels = MovieSearchAPI.DataModels;

namespace MovieSearchAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Movie, Movie>()
                .ReverseMap();
            CreateMap<DataModels.Genre, Genre>()
                .ReverseMap();
            CreateMap<DataModels.Language, Language>()
                .ReverseMap();
            //CreateMap<AddToList, DataModels.List>()
               // .AfterMap<CreateListAfterMap>();
        }
        
    }

        
}
