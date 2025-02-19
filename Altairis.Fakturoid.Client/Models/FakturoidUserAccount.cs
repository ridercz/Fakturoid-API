namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// User account information.
/// </summary>
public class FakturoidUserAccount {

    /// <summary>
    /// Account URL slug.
    /// Goes to https://app.fakturoid.cz/api/v3/accounts/{slug}/…
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// Account logo URL.
    /// </summary>
    public string Logo { get; set; }

    /// <summary>
    /// Account name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Account registration number.
    /// </summary>
    public string RegistrationNo { get; set; }

    /// <summary>
    /// Current user account permission.
    /// </summary>
    public string Permission { get; set; }

    /// <summary>
    /// List of allowed scopes for current user.
    /// Values: reports, expenses, invoices
    /// </summary>
    public string[] AllowedScope { get; set; }

}
