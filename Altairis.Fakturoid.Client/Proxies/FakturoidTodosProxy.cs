namespace Altairis.Fakturoid.Client.Proxies;

/// <summary>
/// Proxy class for working with todo tasks.
/// </summary>
public class FakturoidTodosProxy : FakturoidEntityProxy {

    internal FakturoidTodosProxy(FakturoidContext context) : base(context) { }

    /// <summary>
    /// Gets asynchronously list of all current todos.
    /// </summary>
    /// <param name="since">The date since when todos are to be selected.</param>
    /// <returns>List of <see cref="FakturoidTodo"/> instances.</returns>
    /// <remarks>The result may contain duplicate entities, if they are modified between requests for pages. In current version of API, there is no way to solve rhis.</remarks>
    public Task<IEnumerable<FakturoidTodo>> SelectAsync(DateTime? since = null) => GetAllPagedEntitiesAsync<FakturoidTodo>("todos.json", new { since });

    /// <summary>
    /// Gets asynchronously paged list of current todos
    /// </summary>
    /// <param name="page">The page number.</param>
    /// <param name="since">The date since when todos are to be selected.</param>
    /// <returns>
    /// List of <see cref="FakturoidTodo" /> instances.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
    public async Task<IEnumerable<FakturoidTodo>> SelectAsync(int page, DateTime? since = null) {
        return page < 1
            ? throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.")
            : await GetPagedEntitiesAsync<FakturoidTodo>("todos.json", page, new { since });
    }

}
