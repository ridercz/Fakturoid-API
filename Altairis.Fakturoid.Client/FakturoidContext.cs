global using Altairis.Fakturoid.Client.Models;
using System.Net.Http.Headers;
using System.Text;

namespace Altairis.Fakturoid.Client;

/// <summary>
/// Class representing connection to Fakturoid API, holds authentication information etc.
/// </summary>
public class FakturoidContext {
    private const string DEFAULT_USER_AGENT = "C#/.NET API Client v3 by Altairis (fakturoid@rider.cz)";
    private const string API_BASE_URL_FORMAT = "https://app.fakturoid.cz/api/v3/accounts/{0}/";
    private const string ACCESS_TOKEN_URL = "https://app.fakturoid.cz/api/v3/oauth/token";
    private const float ACCESS_TOKEN_REFRESH_MARGIN = 0.66f; // Refresh access token in 2/3 of its lifetime
    private string accessTokenType;
    private string accessTokenValue;
    private DateTime accessTokenRefresh;

    // Constructor
    /// <summary>
    /// Initializes a new instance of the <see cref="FakturoidContext" /> class.
    /// </summary>
    /// <param name="accountName">Account name (accountName).</param>
    /// <param name="clientId">The client ID for OAuth 2 Client Credentials Flow.</param>
    /// <param name="clientSecret">The client secret for OAuth 2 Client Credentials Flow.</param>
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
    public FakturoidContext(string accountName, string clientId, string clientSecret, string userAgent = DEFAULT_USER_AGENT) {
        if (accountName == null) throw new ArgumentNullException(nameof(accountName));
        if (string.IsNullOrWhiteSpace(accountName)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(accountName));
        if (clientId == null) throw new ArgumentNullException(nameof(clientId));
        if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(clientId));
        if (clientSecret == null) throw new ArgumentNullException(nameof(clientSecret));
        if (string.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(clientSecret));
        if (userAgent == null) throw new ArgumentNullException(nameof(userAgent));
        if (string.IsNullOrWhiteSpace(userAgent)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(userAgent));

        // Configuration properties
        this.AccountName = accountName;
        this.ClientId = clientId;
        this.ClientSecret = clientSecret;
        this.UserAgent = userAgent;

        // Proxies
        //this.Events = new FakturoidEventsProxy(this);
        //this.Todos = new FakturoidTodosProxy(this);
        //this.Subjects = new FakturoidSubjectsProxy(this);
        //this.Invoices = new FakturoidInvoicesProxy(this);
        //this.Expenses = new FakturoidExpensesProxy(this);
        //this.BankAccounts = new FakturoidBankAccountsProxy(this);
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
    public string ClientId { get; private set; }

    /// <summary>
    /// Gets the Fakturoid authentication token.
    /// </summary>
    /// <value>
    /// The Fakturoid authentication token.
    /// </value>
    public string ClientSecret { get; private set; }

    /// <summary>
    /// Gets the User-Agent header used for HTTP requests.
    /// </summary>
    /// <value>
    /// The User-Agent header value.
    /// </value>
    public string UserAgent { get; private set; }

    // Proxies

    // Public methods

    /// <summary>
    /// Gets the account information.
    /// </summary>
    /// <returns>Instance of <see cref="FakturoidAccount"/> class containing the account information.</returns>
    public async Task<FakturoidAccount> GetAccountInfoAsync() {
        var c = this.GetHttpClient();
        var r = await c.GetAsync("account.json");
        r.EnsureFakturoidSuccess();
        return await r.Content.FakturoidReadAsAsync<FakturoidAccount>();
    }

    // Non-public methods

    /// <summary>
    /// Gets the <see cref="System.Net.Http.HttpClient"/> class, initialized for use with Fakturoid API.
    /// </summary>
    /// <param name="forceTokenRefresh">If set to <c>true</c>, forces the refresh of the access token.</param>
    /// <returns>Instance of <see cref="System.Net.Http.HttpClient"/> class, initialized for use with Fakturoid API.</returns>
    internal HttpClient GetHttpClient(bool forceTokenRefresh = false) {
        // Setup HTTP client
        var baseAddress = new Uri(string.Format(API_BASE_URL_FORMAT, this.AccountName));
        var client = new HttpClient { BaseAddress = baseAddress };

        // Set default headers
        client.DefaultRequestHeaders.Add("User-Agent", this.UserAgent);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // Get authentication token if needed
        if (forceTokenRefresh || this.accessTokenType is null || this.accessTokenValue is null || this.accessTokenRefresh > DateTime.Now) this.GetAccessToken(client);

        // Set authentication header
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(this.accessTokenType, this.accessTokenValue);
        return client;
    }

    /// <summary>
    /// Retrieves and sets the access token for the Fakturoid API.
    /// </summary>
    /// <param name="client">The <see cref="HttpClient"/> instance used to make the request.</param>
    /// <exception cref="HttpRequestException">Thrown when the request to get the access token fails.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the response content cannot be read as <see cref="FakturoidAccessToken"/>.</exception>
    private void GetAccessToken(HttpClient client) {
        // Prepare request body
        var body = new { grant_type = "client_credentials" };

        // Add authentication header
        var authHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(":", this.ClientId, this.ClientSecret)));
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);

        // Send request
        var response = client.FakturoidPostAsJsonAsync(ACCESS_TOKEN_URL, body).Result;
        response.EnsureSuccessStatusCode();

        // Parse response
        var token = response.Content.FakturoidReadAsAsync<FakturoidAccessToken>().Result;
        this.accessTokenType = token.TokenType;
        this.accessTokenValue = token.AccessToken;
        this.accessTokenRefresh = DateTime.Now.AddSeconds(token.ExpiresIn * ACCESS_TOKEN_REFRESH_MARGIN);
    }

}
