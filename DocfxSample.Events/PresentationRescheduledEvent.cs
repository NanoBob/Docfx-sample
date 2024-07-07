namespace DocfxSample.Events;

/// <summary>
/// This event is raised whenever a presentation has been rescheduled
/// </summary>
public class PresentationRescheduledEvent
{
    /// <summary>
    /// The example's ID
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// The time at which the presentation was previously scheduled for
    /// </summary>
    public DateTime PreviousStartTime { get; init; }

    /// <summary>
    /// The time at which the presentation is now scheduled for
    /// </summary>
    public DateTime NewStartTime { get; init; }

    /// <summary>
    /// The title of the presentation
    /// </summary>
    public required string Title { get; init; }
}
