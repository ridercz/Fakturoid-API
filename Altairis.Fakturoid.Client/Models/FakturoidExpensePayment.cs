namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Expense payment data.
/// </summary>
public class FakturoidExpensePayment {

    /// <summary>
    /// Unique identifier in Fakturoid
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Payment date
    /// Default: Today
    /// </summary>
    public DateTime PaidOn { get; set; } = DateTime.Today;

    /// <summary>
    /// Currency ISO Code (same as expense currency)
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Paid amount in document currency
    /// Default: Remaining amount to pay
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Paid amount in account currency
    /// Default: Remaining amount to pay converted to account currency
    /// </summary>
    public decimal NativeAmount { get; set; }

    /// <summary>
    /// Mark document as paid?
    /// Default: true if the total paid amount becomes greater or equal to remaining amount to pay
    /// </summary>
    public bool MarkDocumentAsPaid { get; set; }

    /// <summary>
    /// Payment variable symbol
    /// Default: Expense variable symbol
    /// </summary>
    public string VariableSymbol { get; set; }

    /// <summary>
    /// Bank account ID
    /// Default: Expense bank account or default bank account
    /// </summary>
    public int BankAccountId { get; set; }

    /// <summary>
    /// The date and time of payment creation
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// The date and time of last payment update
    /// </summary>
    public DateTimeOffset UpdatedAt { get; set; }

}
