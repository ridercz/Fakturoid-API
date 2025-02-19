namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Legacy bank account details
/// </summary>
public class FakturoidLegacyBankDetails {

    /// <summary>
    /// Bank account number
    /// </summary>
    public string BankAccount { get; set; }

    /// <summary>
    /// IBAN
    /// </summary>
    public string Iban { get; set; }

    /// <summary>
    /// BIC (for SWIFT payments)
    /// </summary>
    public string SwiftBic { get; set; }

}
