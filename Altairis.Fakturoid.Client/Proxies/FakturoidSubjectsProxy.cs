namespace Altairis.Fakturoid.Client.Proxies;

/// <summary>
/// Proxy class for working with subjects/contacts.
/// </summary>
public class FakturoidSubjectsProxy : FakturoidEntityProxy {

    internal FakturoidSubjectsProxy(FakturoidContext context) : base(context) { }

    /// <summary>
    /// Gets asynchronously list of all subjects.
    /// </summary>
    /// <param name="customId">The custom identifier used for filtering.</param>
    /// <param name="createdSince">List only subjects created since certain date.</param>
    /// <param name="updatedSince">List only subjects updated since certain date.</param>
    /// <returns>
    /// List of <see cref="FakturoidSubject" /> instances.
    /// </returns>
    public Task<IEnumerable<FakturoidSubject>> SelectAsync(DateTime? createdSince = default, DateTimeOffset? updatedSince = default, string customId = null) => this.GetAllPagedEntitiesAsync<FakturoidSubject>("subjects.json", new { since = createdSince, updated_since = updatedSince, custom_id = customId });

    /// <summary>
    /// Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note.
    /// </summary>
    /// <param name="query">Search string.</param>
    /// <returns>Collection of search results.</returns>
    /// <exception cref="ArgumentOutOfRangeException">page;Value must be greater than zero.</exception>
    public Task<IEnumerable<FakturoidSubject>> SearchAsync(string query) => this.GetAllPagedEntitiesAsync<FakturoidSubject>("subjects/search.json", new { query });

    /// <summary>
    /// Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note with pagination.
    /// </summary>
    /// <param name="query">Search string.</param>
    /// <param name="page">The page number.</param>
    /// <returns>Collection of search results.</returns>
    /// <exception cref="ArgumentOutOfRangeException">page;Value must be greater than zero.</exception>
    public async Task<IEnumerable<FakturoidSubject>> SearchAsync(int page, string query) => page < 1 ? throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.") : await this.GetPagedEntitiesAsync<FakturoidSubject>("subjects/search.json", page, new { query });

    /// <summary>
    /// Gets asynchronously paged list of subjects
    /// </summary>
    /// <param name="page">The page number.</param>
    /// <param name="createdSince">List only subjects created since certain date.</param>
    /// <param name="updatedSince">List only subjects updated since certain date.</param>
    /// <param name="customId">The custom identifier used for filtering.</param>
    /// <returns>List of <see cref="FakturoidSubject"/> instances.</returns>
    /// <exception cref="ArgumentOutOfRangeException">page;Value must be greater than zero.</exception>
    public async Task<IEnumerable<FakturoidSubject>> SelectAsync(int page, DateTime? createdSince = default, DateTimeOffset? updatedSince = default, string customId = null) => page < 1 ? throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.") : await this.GetPagedEntitiesAsync<FakturoidSubject>("subjects.json", page, new { since = createdSince, updated_since = updatedSince, custom_id = customId });

    /// <summary>
    /// Selects asynchronously single subject with specified ID.
    /// </summary>
    /// <param name="id">The subject id.</param>
    /// <returns>Instance of <see cref="FakturoidSubject"/> class.</returns>
    /// <exception cref="ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
    public async Task<FakturoidSubject> SelectSingleAsync(int id) => id < 1 ? throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.") : await this.GetSingleEntityAsync<FakturoidSubject>(string.Format("subjects/{0}.json", id));

    /// <summary>
    /// Creates asynchronously the specified new subject.
    /// </summary>
    /// <param name="entity">The new subject.</param>
    /// <returns>ID of newly created subject.</returns>
    /// <exception cref="ArgumentNullException">entity</exception>
    public async Task<int> CreateAsync(FakturoidSubject entity) => entity == null ? throw new ArgumentNullException(nameof(entity)) : await this.CreateEntityAsync("subjects.json", entity);

    /// <summary>
    /// Updates asynchronously the specified subject.
    /// </summary>
    /// <param name="entity">The subject to update.</param>
    /// <returns>Instance of <see cref="FakturoidSubject"/> class with modified entity.</returns>
    /// <exception cref="ArgumentNullException">entity</exception>
    public async Task<FakturoidSubject> UpdateAsync(FakturoidSubject entity) => entity == null ? throw new ArgumentNullException(nameof(entity)) : await this.UpdateSingleEntityAsync(string.Format("subjects/{0}.json", entity.Id), entity);

    /// <summary>
    /// Deletes asynchronously with specified id.
    /// </summary>
    /// <param name="id">The contact id.</param>
    /// <exception cref="ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
    public Task DeleteAsync(int id) => id < 1 ? throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.") : this.DeleteSingleEntityAsync(string.Format("subjects/{0}.json", id));

}
