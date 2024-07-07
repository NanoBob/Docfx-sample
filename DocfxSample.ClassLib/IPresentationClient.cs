
namespace DocfxSample.ClassLib;

public interface IPresentationClient
{
    Task<PresentationDto> Cancel(Guid id);
    Task<PresentationDto> Get(Guid id);
    Task<IEnumerable<PresentationDto>> GetAll();
    Task<PresentationDto> Reschedule(Guid id, DateTime scheduledDate);
    Task<PresentationDto> Schedule(string title, string speaker, DateTime scheduledDate);
}