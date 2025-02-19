namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// User
/// </summary>
public class FakturoidUser {

    /// <summary>
    /// Unique identifier in Fakturoid
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// User full name
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// User email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// User avatar URL
    /// </summary>
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Default account slug (Only on the /user.json endpoint)
    /// </summary>
    public string DefaultAccount { get; set; }

    /// <summary>
    /// User permission for the current account
    /// </summary>
    public string Permission { get; set; }

    /// <summary>
    /// List of allowed scopes. Values: reports, expenses, invoices
    /// </summary>
    public List<string> AllowedScope { get; set; }

    /// <summary>
    /// List of accounts the user has access to (Only on the /user.json endpoint)
    /// </summary>
    public List<FakturoidUserAccount> Accounts { get; set; }

}
