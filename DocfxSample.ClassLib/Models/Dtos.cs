namespace DocfxSample.ClassLib.Models;

/// <summary>
/// Represents a scheduled presentation
/// </summary>
/// <param name="Id"></param>
/// <param name="Title"></param>
/// <param name="Speaker"></param>
/// <param name="ScheduledTime"></param>
public record PresentationDto(Guid Id, string Title, string Speaker, DateTime ScheduledTime);

/// <summary>
/// Represents a request for scheduling a new presentation
/// </summary>
/// <param name="Title"></param>
/// <param name="Speaker"></param>
/// <param name="ScheduledTime"></param>
public record SchedulePresentationDto(string Title, string Speaker, DateTime ScheduledTime);
