namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Invoice payment data.
/// </summary>
public class FakturoidInvoicePayment {

    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Payment date.
    /// Default: Today
    /// </summary>
    public DateTime PaidOn { get; set; } = DateTime.Today;

    /// <summary>
    /// Currency ISO Code (same as invoice currency).
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Paid amount in document currency.
    /// Default: Remaining amount to pay
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Paid amount in account currency.
    /// Default: Remaining amount to pay converted to account currency
    /// </summary>
    public decimal NativeAmount { get; set; }

    /// <summary>
    /// Mark document as paid?
    /// Default: true if the total paid amount becomes greater or equal to remaining amount to pay
    /// </summary>
    public bool MarkDocumentAsPaid { get; set; }

    /// <summary>
    /// Issue a followup document with payment.
    /// Only for proformas and mark_document_as_paid must be true.
    /// Values: final_invoice_paid, final_invoice, tax_document, none
    /// </summary>
    public string ProformaFollowupDocument { get; set; }

    /// <summary>
    /// Send thank-you email?
    /// mark_document_as_paid must be true
    /// Default: Inherit from account settings
    /// </summary>
    public bool SendThankYouEmail { get; set; }

    /// <summary>
    /// Payment variable symbol.
    /// Default: Invoice variable symbol
    /// </summary>
    public string VariableSymbol { get; set; }

    /// <summary>
    /// Bank account ID.
    /// Default: Invoice bank account or default bank account
    /// </summary>
    public int BankAccountId { get; set; }

    /// <summary>
    /// Tax document ID (if present).
    /// </summary>
    public int TaxDocumentId { get; set; }

    /// <summary>
    /// The date and time of payment creation.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The date and time of last payment update.
    /// </summary>
    public DateTime UpdatedAt { get; set; }

}
