namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Access token
/// </summary>
internal class FakturoidAccessToken {

    /// <summary>
    /// Gets or sets the access token.
    /// </summary>
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets the type of the token.
    /// </summary>
    public string TokenType { get; set; }

    /// <summary>
    /// Gets or sets the expiration time in seconds.
    /// </summary>
    public int ExpiresIn { get; set; }

}
