namespace Altairis.Fakturoid.Client.Proxies;

/// <summary>
/// Proxy class for working with events
/// </summary>
public class FakturoidEventsProxy : FakturoidEntityProxy {

    internal FakturoidEventsProxy(FakturoidContext context) : base(context) { }

    /// <summary>
    /// Gets asynchronously list of all current events.
    /// </summary>
    /// <param name="since">The date since when events are to be selected.</param>
    /// <param name="subjectId">The ID of the subject to filter events by.</param>
    /// <returns>List of <see cref="FakturoidEvent"/> instances.</returns>
    /// <remarks>The result may contain duplicate entities, if they are modified between requests for pages. In current version of API, there is no way to solve this.</remarks>
    public Task<IEnumerable<FakturoidEvent>> SelectAsync(DateTimeOffset? since = null, int? subjectId = null) => GetAllPagedEntitiesAsync<FakturoidEvent>("events.json", new { since, subject_id = subjectId });

    /// <summary>
    /// Gets asynchronously list of current events, paged by 40.
    /// </summary>
    /// <param name="page">The page number.</param>
    /// <param name="since">The date since when events are to be selected.</param>
    /// <returns>
    /// List of <see cref="FakturoidEvent" /> instances.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
    public async Task<IEnumerable<FakturoidEvent>> SelectAsync(int page, DateTimeOffset? since = null) => page < 1
            ? throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.")
            : await GetPagedEntitiesAsync<FakturoidEvent>("events.json", page, new { since });

}
