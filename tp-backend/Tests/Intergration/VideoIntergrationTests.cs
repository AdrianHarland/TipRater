using NUnit.Framework;
using FluentAssertions;
using System.Text.Json;
using tp_backend.Application.Interfaces;
using tp_backend.Infrastructure.Data;
using tp_backend.Infrastructure.Data.Entitites;
using JsonSerializerOptions = System.Text.Json.JsonSerializerOptions;


namespace tp_backend.Tests.Intergration;


[TestFixture]
public class VideoIntergrationTests
{
    private ServiceProvider _serviceProvider;
    private AppDbContext _dbContext;
    private IVideoServices _videoService;

    [SetUp]
    public void SetUp()
    {
        // Get the service provider from the global setup
        _serviceProvider = TestSetup.ServiceProvider;

        // Resolve services from the service provider
        _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
        _videoService = _serviceProvider.GetRequiredService<IVideoServices>();

        // Ensure database is clean before each test
        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();
    }

    [Test]
    public async Task GetAllVideosAsync_Returns()
    {
        //Arrange
        var video1 = new VideoEntity
        {
            Name = "test1",
            Link = "http.test.com",
            Views = 25,
            Votes = 44
        };
        var video2 = new VideoEntity
        {
            Name = "test2",
            Link = "http.testttttt.com",
            Views = 25444444,
            Votes = 44620
        };
        _dbContext.Video.Add(video1);
        _dbContext.Video.Add(video2);
        await _dbContext.SaveChangesAsync();
        
        //Act
        var result = await _videoService.GetAllVideosAsync();

        //Assert
        result.Should().HaveCount(2);
        // result.Should().BeEquivalentTo("video2",[1]);
    }
}