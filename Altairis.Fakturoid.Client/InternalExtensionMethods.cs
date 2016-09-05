using System;
using System.Net.Http;

namespace Altairis.Fakturoid.Client {
    internal static class InternalExtensionMethods {

        public static void EnsureFakturoidSuccess(this HttpResponseMessage r) {
            if (r == null) throw new ArgumentNullException(nameof(r));
            if (r.IsSuccessStatusCode) return;

            throw new FakturoidException(r);
        }

    }
}
