using DocfxSample.ClassLib.Clients.Interfaces;
using DocfxSample.ClassLib.Models;

namespace DocfxSample.ClassLib.Clients;

/// <summary>
/// An HttpClient for using the presentation API
/// </summary>
/// <param name="baseUrl">The base URL of the API</param>
public class PresentationClient(string baseUrl) : IPresentationClient
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
