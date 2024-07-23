using Microsoft.EntityFrameworkCore;
using tp_backend.Infrastructure.Data;
using tp_backend.Infrastructure.Data.Entitites;

namespace tp_backend.Infrastructure.Repository;

public class VideoRepository : IVideoRepository
{
    private readonly AppDbContext _context;

    public VideoRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<VideoEntity>> GetAllVideosAsync()
    {
        return await _context.Video.ToListAsync();
    }
}