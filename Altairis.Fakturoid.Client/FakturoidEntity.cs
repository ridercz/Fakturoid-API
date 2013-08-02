using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    public abstract class FakturoidEntity {
        private const string API_BASE_URL_FORMAT = "https://{0}.fakturoid.cz/api/v1/";

        protected FakturoidEntity(FakturoidContext context) {
            if (context == null) throw new ArgumentNullException("context");
            this.Context = context;
        }
        
        protected FakturoidContext Context { get; private set; }

        protected HttpClient GetHttpClient() {
            // Get value of authentication header
            var authHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes("X:" + this.Context.AuthenticationToken));

            // Setup HTTP client
            var client = new HttpClient();
            client.BaseAddress = new Uri(string.Format(API_BASE_URL_FORMAT, this.Context.AuthenticationName));
            client.DefaultRequestHeaders.Add("User-Agent", this.Context.UserAgent);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);

            return client;
        }

    }
}
