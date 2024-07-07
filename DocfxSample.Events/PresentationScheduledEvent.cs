namespace DocfxSample.Events;

/// <summary>
/// This event is raised whenever a new presentation has been scheduled
/// </summary>
public class PresentationScheduledEvent
{
    /// <summary>
    /// The presentations's ID
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// The time the presentation was created
    /// </summary>
    public DateTime CreationTime { get; init; }

    /// <summary>
    /// The time the presentation is scheduled to take place
    /// </summary>
    public DateTime ScheduleTime { get; init; }

    /// <summary>
    /// The title of the presentation
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// The name of the presentation's speaker
    /// </summary>
    public required string Speaker { get; init; }
}
