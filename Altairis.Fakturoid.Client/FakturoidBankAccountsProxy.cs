using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Altairis.Fakturoid.Client {
    /// <summary>
    /// Proxy class form working with bank accounts
    /// </summary>
    public class FakturoidBankAccountsProxy : FakturoidEntityProxy {

        internal FakturoidBankAccountsProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets list of all bank accounts.
        /// </summary>
        /// <returns>List of <see cref="JsonBankAccount"/> instances.</returns>
        public IEnumerable<JsonBankAccount> Select() {
            return base.GetUnpagedEntities<JsonBankAccount>("bank_accounts.json");
        }

    }
}
