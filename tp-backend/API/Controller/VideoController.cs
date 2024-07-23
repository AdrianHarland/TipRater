using Microsoft.AspNetCore.Mvc;
using tp_backend.Application.Interfaces;
using tp_backend.DTOs;

namespace tp_backend.API.Controller;

/// <summary>
/// The Video Controller
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class VideoController : ControllerBase
{
    private readonly IVideoServices _videoServices;

    public VideoController(IVideoServices videoServices)
    {
        _videoServices = videoServices;
    }

/// <summary>
/// Get all Videos 
/// </summary>
[HttpGet]
[ProducesResponseType(typeof(VideoDto), StatusCodes.Status200OK)]
public async Task<ActionResult<IEnumerable<VideoDto>>> GetAllVideosAsync()
{
    return Ok(await _videoServices.GetAllVideosAsync());
}

//Get/ID: Video


    
}