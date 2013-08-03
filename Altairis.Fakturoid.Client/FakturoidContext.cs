using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// Class representing connection to Fakturoid API, holds authentication information etc.
    /// </summary>
    public class FakturoidContext {
        private const string DEFAULT_USER_AGENT = "C#/.NET API Client by Altairis (fakturoid@rider.cz)";
        private const string API_BASE_URL_FORMAT = "https://{0}.fakturoid.cz/api/v1/";

        // Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidContext"/> class.
        /// </summary>
        /// <param name="authenticationName">Name of the account used for authentication.</param>
        /// <param name="authenticationToken">The authentication token.</param>
        /// <param name="userAgent">The User-Agent HTTP header rawValue.</param>
        /// <exception cref="System.ArgumentNullException">
        /// authenticationName
        /// or
        /// authenticationToken
        /// or
        /// userAgent
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// Value cannot be empty or whitespace only string.;authenticationName
        /// or
        /// Value cannot be empty or whitespace only string.;authenticationToken
        /// or
        /// Value cannot be empty or whitespace only string.;userAgent
        /// </exception>
        public FakturoidContext(string authenticationName, string authenticationToken, string userAgent = DEFAULT_USER_AGENT) {
            if (authenticationName == null) throw new ArgumentNullException("authenticationName");
            if (string.IsNullOrWhiteSpace(authenticationName)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "authenticationName");
            if (authenticationToken == null) throw new ArgumentNullException("authenticationToken");
            if (string.IsNullOrWhiteSpace(authenticationToken)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "authenticationToken");
            if (userAgent == null) throw new ArgumentNullException("userAgent");
            if (string.IsNullOrWhiteSpace(userAgent)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "userAgent");

            // Configuration properties
            this.AuthenticationName = authenticationName;
            this.AuthenticationToken = authenticationToken;
            this.UserAgent = userAgent;

            // Proxies
            this.Events = new FakturoidEventsProxy(this);
            this.Todos = new FakturoidTodosProxy(this);
            this.Subjects = new FakturoidSubjectsProxy(this);
        }

        // Properties

        /// <summary>
        /// Gets the Fakturoid account name.
        /// </summary>
        /// <rawValue>
        /// The name of the Fakturoid account.
        /// </rawValue>
        public string AuthenticationName { get; private set; }

        /// <summary>
        /// Gets the Fakturoid authentication token.
        /// </summary>
        /// <rawValue>
        /// The Fakturoid authentication token.
        /// </rawValue>
        public string AuthenticationToken { get; private set; }

        /// <summary>
        /// Gets the User-Agent header used for HTTP requests.
        /// </summary>
        /// <rawValue>
        /// The User-Agent header rawValue.
        /// </rawValue>
        public string UserAgent { get; private set; }

        /// <summary>
        /// Proxy for working with events.
        /// </summary>
        public FakturoidEventsProxy Events { get; private set; }

        /// <summary>
        /// Proxy for working with todos.
        /// </summary>
        public FakturoidTodosProxy Todos { get; private set; }

        /// <summary>
        /// Proxy for working with subjects.
        /// </summary>
        public FakturoidSubjectsProxy Subjects { get; private set; }

        // Public methods

        /// <summary>
        /// Gets the account information.
        /// </summary>
        /// <returns>Instance of <see cref="JsonAccount"/> class containing the account information.</returns>
        public JsonAccount GetAccountInfo() {
            var c = this.GetHttpClient();
            var r = c.GetAsync("account.json").Result;
            r.EnsureSuccessStatusCode();
            return r.Content.ReadAsAsync<JsonAccount>().Result;
        }

        // Non-public helper methods

        /// <summary>
        /// Gets the <see cref="System.Net.Http.HttpClient"/> class, initialized for use with Fakturoid API.
        /// </summary>
        /// <returns>Instance of <see cref="System.Net.Http.HttpClient"/> class, initialized for use with Fakturoid API.</returns>
        internal HttpClient GetHttpClient() {
            // Get rawValue of authentication header
            var authHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes("X:" + this.AuthenticationToken));

            // Setup HTTP client
            var client = new HttpClient();
            client.BaseAddress = new Uri(string.Format(API_BASE_URL_FORMAT, this.AuthenticationName));
            client.DefaultRequestHeaders.Add("User-Agent", this.UserAgent);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);

            return client;
        }

    }
}
