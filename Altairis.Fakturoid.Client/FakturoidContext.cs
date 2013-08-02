using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    public class FakturoidContext {
        private const string DEFAULT_USER_AGENT = "C#/.NET API Client by Altairis (fakturoid@rider.cz)";

        public string AuthenticationName { get; private set; }

        public string AuthenticationToken { get; private set; }

        public string UserAgent { get; private set; }

        public FakturoidAccount Account { get; private set; }

        private FakturoidContext() { }

        public static FakturoidContext Create(string authenticationName, string authenticationToken, string userAgent = DEFAULT_USER_AGENT) {
            if (authenticationName == null) throw new ArgumentNullException("authenticationName");
            if (string.IsNullOrWhiteSpace(authenticationName)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "authenticationName");
            if (authenticationToken == null) throw new ArgumentNullException("authenticationToken");
            if (string.IsNullOrWhiteSpace(authenticationToken)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "authenticationToken");
            if (userAgent == null) throw new ArgumentNullException("userAgent");
            if (string.IsNullOrWhiteSpace(userAgent)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "userAgent");

            var context = new FakturoidContext {
                AuthenticationName = authenticationName,
                AuthenticationToken = authenticationToken,
                UserAgent = userAgent
            };

            context.Account = new FakturoidAccount(context);

            return context;
        }
        
    }
}
