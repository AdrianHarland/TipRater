namespace tp_backend.Infrastructure.Data.Entitites;

public class VideoEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Embed { get; set; } = null!;

    public string Link { get; set; } = null!;
    
    public int? Views { get; set; }
    
    public int? Votes { get; set; }
    
    public DateTime UploadDate { get; set; } 
        //= DateTime.Now;
}