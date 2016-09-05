using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// Class representing connection to Fakturoid API, holds authentication information etc.
    /// </summary>
    public class FakturoidContext {
        private const string DEFAULT_USER_AGENT = "C#/.NET API Client v2 by Altairis (fakturoid@rider.cz)";
        private const string API_BASE_URL_FORMAT = "https://app.fakturoid.cz/api/v2/accounts/{0}/";

        // Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidContext" /> class.
        /// </summary>
        /// <param name="accountName">Account name (accountName).</param>
        /// <param name="emailAddress">The email address od user being authenticated.</param>
        /// <param name="authenticationToken">The authentication token.</param>
        /// <param name="userAgent">The User-Agent HTTP header value.</param>
        /// <exception cref="ArgumentNullException">accountName
        /// or
        /// authenticationToken
        /// or
        /// userAgent</exception>
        /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.;accountName
        /// or
        /// Value cannot be empty or whitespace only string.;authenticationToken
        /// or
        /// Value cannot be empty or whitespace only string.;userAgent</exception>
        public FakturoidContext(string accountName, string emailAddress, string authenticationToken, string userAgent = DEFAULT_USER_AGENT) {
            if (accountName == null) throw new ArgumentNullException(nameof(accountName));
            if (string.IsNullOrWhiteSpace(accountName)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(accountName));
            if (emailAddress == null) throw new ArgumentNullException(nameof(emailAddress));
            if (string.IsNullOrWhiteSpace(emailAddress)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(emailAddress));
            if (authenticationToken == null) throw new ArgumentNullException(nameof(authenticationToken));
            if (string.IsNullOrWhiteSpace(authenticationToken)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(authenticationToken));
            if (userAgent == null) throw new ArgumentNullException(nameof(userAgent));
            if (string.IsNullOrWhiteSpace(userAgent)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(userAgent));

            // Configuration properties
            this.AccountName = accountName;
            this.EmailAddress = emailAddress;
            this.AuthenticationToken = authenticationToken;
            this.UserAgent = userAgent;

            // Proxies
            this.Events = new FakturoidEventsProxy(this);
            this.Todos = new FakturoidTodosProxy(this);
            this.Subjects = new FakturoidSubjectsProxy(this);
            this.Invoices = new FakturoidInvoicesProxy(this);
            this.BankAccounts = new FakturoidBankAccountsProxy(this);
        }

        // Properties

        /// <summary>
        /// Gets the Fakturoid account name.
        /// </summary>
        /// <value>
        /// The name of the Fakturoid account.
        /// </value>
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets the Fakturoid account email address.
        /// </summary>
        /// <value>
        /// The email address associated with Fakturoid account being used.
        /// </value>
        public string EmailAddress { get; private set; }

        /// <summary>
        /// Gets the Fakturoid authentication token.
        /// </summary>
        /// <value>
        /// The Fakturoid authentication token.
        /// </value>
        public string AuthenticationToken { get; private set; }

        /// <summary>
        /// Gets the User-Agent header used for HTTP requests.
        /// </summary>
        /// <value>
        /// The User-Agent header value.
        /// </value>
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

        /// <summary>
        /// Proxy for working with invoices
        /// </summary>
        public FakturoidInvoicesProxy Invoices { get; private set; }

        /// <summary>
        /// Proxy for working with bank accounts.
        /// </summary>
        public FakturoidBankAccountsProxy BankAccounts { get; private set; }

        // Public methods

        /// <summary>
        /// Gets the account information.
        /// </summary>
        /// <returns>Instance of <see cref="JsonAccount"/> class containing the account information.</returns>
        public JsonAccount GetAccountInfo() {
            var c = this.GetHttpClient();
            var r = c.GetAsync("account.json").Result;
            r.EnsureFakturoidSuccess();
            return r.Content.ReadAsAsync<JsonAccount>().Result;
        }

        // Non-public helper methods

        /// <summary>
        /// Gets the <see cref="System.Net.Http.HttpClient"/> class, initialized for use with Fakturoid API.
        /// </summary>
        /// <returns>Instance of <see cref="System.Net.Http.HttpClient"/> class, initialized for use with Fakturoid API.</returns>
        internal HttpClient GetHttpClient() {
            // Get value of authentication header
            var authHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(":", this.EmailAddress, this.AuthenticationToken)));

            // Setup HTTP client
            var client = new HttpClient();
            client.BaseAddress = new Uri(string.Format(API_BASE_URL_FORMAT, this.AccountName));
            client.DefaultRequestHeaders.Add("User-Agent", this.UserAgent);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);

            return client;
        }

    }
}
