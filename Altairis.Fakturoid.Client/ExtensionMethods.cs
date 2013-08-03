using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    internal static class ExtensionMethods {

        public static void EnsureFakturoidSuccess(this HttpResponseMessage r) {
            if (r == null) throw new ArgumentNullException("r");
            if (r.IsSuccessStatusCode) return;

            throw new FakturoidException(r);
        }

    }
}
