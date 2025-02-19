namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Bank account data.
/// </summary>
public class FakturoidBankAccount {

    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Account name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Currency.
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Account number.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// IBAN code.
    /// </summary>
    public string Iban { get; set; }

    /// <summary>
    /// BIC (for SWIFT payments).
    /// </summary>
    public string SwiftBic { get; set; }

    /// <summary>
    /// Pairing of incoming payments.
    /// </summary>
    public bool Pairing { get; set; }

    /// <summary>
    /// Pairing of outgoing payments.
    /// </summary>
    public bool ExpensePairing { get; set; }

    /// <summary>
    /// Small amount settlement when matching payments.
    /// </summary>
    public bool PaymentAdjustment { get; set; }

    /// <summary>
    /// Default bank account.
    /// </summary>
    public bool Default { get; set; }

    /// <summary>
    /// Date and time of bank account creation.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last bank account update.
    /// </summary>
    public DateTime UpdatedAt { get; set; }

}
