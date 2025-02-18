using System.Collections.Generic;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    /// <summary>
    /// Proxy class form working with bank accounts
    /// </summary>
    public class FakturoidBankAccountsProxy : FakturoidEntityProxy {

        internal FakturoidBankAccountsProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets asynchronously list of all bank accounts.
        /// </summary>
        /// <returns>List of <see cref="JsonBankAccount"/> instances.</returns>
        public Task<IEnumerable<JsonBankAccount>> SelectAsync() => base.GetUnpagedEntitiesAsync<JsonBankAccount>("bank_accounts.json");

    }
}
