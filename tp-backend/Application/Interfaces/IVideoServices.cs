using tp_backend.DTOs;

namespace tp_backend.Application.Interfaces;

// Interface responsible for holding methods that will work with the API
public interface IVideoServices
{
 Task<IEnumerable<VideoDto>> GetAllVideosAsync();
}