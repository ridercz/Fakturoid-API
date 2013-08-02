using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Altairis.Fakturoid.Client {
    public class FakturoidAccount : FakturoidEntity {

        internal FakturoidAccount(FakturoidContext context) : base(context) { }

        public JsonAccount Select() {
            var c = this.GetHttpClient();
            var r = c.GetAsync("account.json").Result;
            r.EnsureSuccessStatusCode();
            return r.Content.ReadAsAsync<JsonAccount>().Result;
        }

    }
}
