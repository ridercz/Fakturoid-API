namespace Altairis.Fakturoid.Client.Proxies;

/// <summary>
/// Proxy class for working with number formats
/// </summary>
public class FakturoidNumberFormatsProxy : FakturoidEntityProxy {

    internal FakturoidNumberFormatsProxy(FakturoidContext context) : base(context) { }

    /// <summary>
    /// Gets asynchronously list of all number formats.
    /// </summary>
    /// <returns>List of <see cref="FakturoidNumberFormat"/> instances.</returns>
    public Task<IEnumerable<FakturoidNumberFormat>> SelectAsync() => GetUnpagedEntitiesAsync<FakturoidNumberFormat>("number_formats/invoices.json");

}
