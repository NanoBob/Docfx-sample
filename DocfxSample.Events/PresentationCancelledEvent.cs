namespace DocfxSample.Events;

/// <summary>
/// This event is raised whenever a presentation has bee cancelled
/// </summary>
public class PresentationCancelledEvent
{
    /// <summary>
    /// The example's ID
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// The time at which the presentation was cancelled
    /// </summary>
    public DateTime CancellationTime { get; init; }
}
