using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using tp_backend.Application.Interfaces;
using tp_backend.Application.Services;
using tp_backend.Infrastructure;
using tp_backend.Infrastructure.Data;
using tp_backend.Infrastructure.Repository;

namespace tp_backend.Tests;

public class TestSetup
{
    public static ServiceProvider ServiceProvider { get; private set; }

    [OneTimeSetUp]
    public void GlobalSetup()
    {
        var services = new ServiceCollection();

        // Configure in-memory database
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("TestDb"));
//test
        // Register services and repositories
        services.AddScoped<IVideoServices, VideoService>();
        services.AddScoped<IVideoRepository, VideoRepository>();

        ServiceProvider = services.BuildServiceProvider();

        // Ensure database is created
        var dbContext = ServiceProvider.GetRequiredService<AppDbContext>();
        dbContext.Database.EnsureCreated();
    }

    [OneTimeTearDown]
    public void GlobalTeardown()
    {
        
        // Clean up resources
        if (ServiceProvider == null) return;

        // Clean up resources
        var dbContext = ServiceProvider.GetRequiredService<AppDbContext>();
        dbContext.Database.EnsureDeleted();
        dbContext.Dispose();
        ServiceProvider.Dispose();
    }
}
