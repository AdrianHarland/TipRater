using Microsoft.EntityFrameworkCore;
using tp_backend.Infrastructure.Data.Entitites;

namespace tp_backend.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    // No-argument constructor for Moq
    public AppDbContext()
    {
    }
    
    public DbSet<VideoEntity> Video { get; set; }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //     modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    // }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    // #warning To protect potentially sensitive information in your connection string, 
    //         you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 
    //         for guidance on storing connection strings.
            optionsBuilder.UseMySQL("server=localhost;database=tp-backend;user=root;password=root");
    }
    }
    
