namespace DocfxSample.ClassLib;

public class PresentationClient : IPresentationClient
{
    public Task<IEnumerable<PresentationDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<PresentationDto> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<PresentationDto> Schedule(string title, string speaker, DateTime scheduledDate)
    {
        throw new NotImplementedException();
    }

    public Task<PresentationDto> Reschedule(Guid id, DateTime scheduledDate)
    {
        throw new NotImplementedException();
    }

    public Task<PresentationDto> Cancel(Guid id)
    {
        throw new NotImplementedException();
    }
}
