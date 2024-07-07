using Microsoft.AspNetCore.Mvc;

namespace DocfxSample.Api.Controllers;

public record PresentationDto(Guid Id, string Title, string Speaker, DateTime ScheduledTime);
public record SchedulePresentationDto(string Title, string Speaker, DateTime ScheduledTime);

[ApiController]
[Route("[controller]")]
public class PresentationController(ILogger<PresentationController> logger) : ControllerBase
{
    [HttpGet("", Name = nameof(GetAll))]
    public IEnumerable<PresentationDto> GetAll()
    {
        logger.LogInformation($"Called {nameof(GetAll)}");
        throw new NotImplementedException();
    }

    [HttpGet("{id}", Name = nameof(GetById))]
    public IEnumerable<PresentationDto> GetById(Guid id)
    {
        logger.LogInformation($"Called {nameof(GetById)}");
        throw new NotImplementedException();
    }

    [HttpPost("", Name = nameof(Schedule))]
    public IEnumerable<PresentationDto> Schedule([FromBody] SchedulePresentationDto presentation)
    {
        logger.LogInformation($"Called {nameof(Schedule)}");
        throw new NotImplementedException();
    }

    [HttpPatch("{id}", Name = nameof(Start))]
    public IEnumerable<PresentationDto> Start(Guid id)
    {
        logger.LogInformation($"Called {nameof(Start)}");
        throw new NotImplementedException();
    }

    [HttpDelete("{id}", Name = nameof(Cancel))]
    public IEnumerable<PresentationDto> Cancel(Guid id)
    {
        logger.LogInformation($"Called {nameof(Cancel)}");
        throw new NotImplementedException();
    }
}
