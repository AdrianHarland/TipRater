namespace tp_backend.DTOs;

public record VideoDto
(
    int Id,
    string Name,
    string Embed, 
    string Link, 
    int Votes,
    int Views,
    DateTime UploadDate
);