namespace DocfxSample.Events;

/// <summary>
/// This event is raised whenever a presentation has begun.
/// </summary>
public class PresentationStartedEvent
{
    /// <summary>
    /// The example's ID
    /// </summary>
    public Guid Id { get; init; }
}
