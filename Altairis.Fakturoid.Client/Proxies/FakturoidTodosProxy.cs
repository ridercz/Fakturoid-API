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
    public async Task<IEnumerable<FakturoidTodo>> SelectAsync(int page, DateTime? since = null) => page < 1 ? throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.") : await GetPagedEntitiesAsync<FakturoidTodo>("todos.json", page, new { since });

    /// <summary>
    /// Toggles the completion status of a todo task asynchronously.
    /// </summary>
    /// <param name="id">The ID of the todo task to toggle.</param>
    /// <returns>The updated <see cref="FakturoidTodo"/> instance.</returns>
    public async Task<FakturoidTodo> ToggleCompletion(int id) {
        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"todos/{id}/toggle_completion.json", null);
        r.EnsureFakturoidSuccess();
        return await r.Content.FakturoidReadAsAsync<FakturoidTodo>();
    }


}
