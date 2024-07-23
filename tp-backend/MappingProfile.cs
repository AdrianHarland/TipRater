using AutoMapper;
using tp_backend.DTOs;
using tp_backend.Infrastructure.Data.Entitites;

// using tp_backend.Models;

namespace tp_backend
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VideoEntity, VideoDto>();
        }
    }
}
