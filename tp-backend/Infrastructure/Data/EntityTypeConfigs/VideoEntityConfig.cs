using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tp_backend.Infrastructure.Data.Entitites;


namespace tp_backend.Infrastructure.Data.EntityTypeConfigs;

public class VideoEntityConfig : IEntityTypeConfiguration<VideoEntity>
{
    public void Configure(EntityTypeBuilder<VideoEntity> builder)
    {
        builder.ToTable(nameof(VideoEntity));

        builder.Property(v => v.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(v => v.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(v => v.Embed)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(v => v.Link)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(v => v.Views)
            .HasDefaultValue(0);

        builder.Property(v => v.Votes)
            .HasDefaultValue(0);
        
        builder.Property(v => v.UploadDate)
            .ValueGeneratedOnAdd()
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}