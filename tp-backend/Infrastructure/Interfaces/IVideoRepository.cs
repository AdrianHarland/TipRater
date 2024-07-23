using tp_backend.Infrastructure.Data.Entitites;

namespace tp_backend.Infrastructure;

// Interface responsible for holding methods that will work with the DB 
public interface IVideoRepository
{
    Task<IEnumerable<VideoEntity>> GetAllVideosAsync();
}