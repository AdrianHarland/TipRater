using AutoMapper;
using tp_backend.Application.Interfaces;
using tp_backend.DTOs;
using tp_backend.Infrastructure;

namespace tp_backend.Application.Services;

public class VideoService : IVideoServices
{

    private readonly IVideoRepository _videoRepository;
    private readonly IMapper _mapper;

    public VideoService(
        IVideoRepository videoRepository,
        IMapper mapper)
    {
        _videoRepository = videoRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<VideoDto>> GetAllVideosAsync()
    {
        var allVideos = await _videoRepository.GetAllVideosAsync();
        return _mapper.Map<List<VideoDto>>(allVideos);
    }
}