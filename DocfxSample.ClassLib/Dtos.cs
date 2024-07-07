namespace DocfxSample.ClassLib;

public record PresentationDto(Guid Id, string Title, string Speaker, DateTime ScheduledTime);
public record SchedulePresentationDto(string Title, string Speaker, DateTime ScheduledTime);
