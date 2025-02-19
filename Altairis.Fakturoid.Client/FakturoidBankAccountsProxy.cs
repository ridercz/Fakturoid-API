namespace Altairis.Fakturoid.Client;
/// <summary>
/// Proxy class form working with bank accounts
/// </summary>
public class FakturoidBankAccountsProxy : FakturoidEntityProxy {

    internal FakturoidBankAccountsProxy(FakturoidContext context) : base(context) { }

    /// <summary>
    /// Gets asynchronously list of all bank accounts.
    /// </summary>
    /// <returns>List of <see cref="FakturoidBankAccount"/> instances.</returns>
    public Task<IEnumerable<FakturoidBankAccount>> SelectAsync() => base.GetUnpagedEntitiesAsync<FakturoidBankAccount>("bank_accounts.json");

}
