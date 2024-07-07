using DocfxSample.ClassLib.Models;

namespace DocfxSample.ClassLib.Clients.Interfaces;

public interface IPresentationClient
{
    /// <summary>
    /// Returns details for a single presentation by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<PresentationDto> Get(Guid id);

    /// <summary>
    /// Returns all presentations
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<PresentationDto>> GetAll();

    /// <summary>
    /// Schedules a new presentation
    /// </summary>
    /// <param name="title"></param>
    /// <param name="speaker"></param>
    /// <param name="scheduledDate"></param>
    /// <returns></returns>
    Task<PresentationDto> Schedule(string title, string speaker, DateTime scheduledDate);

    /// <summary>
    /// Cancels a presentation
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<PresentationDto> Cancel(Guid id);

    /// <summary>
    /// Changes a presentation's scheduled date
    /// </summary>
    /// <param name="id"></param>
    /// <param name="scheduledDate"></param>
    /// <returns></returns>
    Task<PresentationDto> Reschedule(Guid id, DateTime scheduledDate);
}