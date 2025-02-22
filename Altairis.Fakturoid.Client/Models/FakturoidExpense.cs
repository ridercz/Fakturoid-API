namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Expense data.
/// </summary>
public class FakturoidExpense {

    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Identifier in your application.
    /// </summary>
    public string CustomId { get; set; }

    /// <summary>
    /// Expense number. Default: Calculate new number automatically.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Original expense number.
    /// </summary>
    public string OriginalNumber { get; set; }

    /// <summary>
    /// Variable symbol.
    /// </summary>
    public string VariableSymbol { get; set; }

    /// <summary>
    /// Subject company name.
    /// </summary>
    public string SupplierName { get; set; }

    /// <summary>
    /// Subject address street.
    /// </summary>
    public string SupplierStreet { get; set; }

    /// <summary>
    /// Subject address city.
    /// </summary>
    public string SupplierCity { get; set; }

    /// <summary>
    /// Subject address postal code.
    /// </summary>
    public string SupplierZip { get; set; }

    /// <summary>
    /// Subject address country (ISO Code).
    /// </summary>
    public string SupplierCountry { get; set; }

    /// <summary>
    /// Subject registration number (IČO).
    /// </summary>
    public string SupplierRegistrationNo { get; set; }

    /// <summary>
    /// Subject VAT number (DIČ).
    /// </summary>
    public string SupplierVatNo { get; set; }

    /// <summary>
    /// Subject SK DIČ (only for Slovakia, does not start with country code).
    /// </summary>
    public string SupplierLocalVatNo { get; set; }

    /// <summary>
    /// Subject ID.
    /// </summary>
    public int SubjectId { get; set; }

    /// <summary>
    /// Current state of the expense. Values: open, overdue, paid.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Type of expense document. Values: invoice, bill (Receipt), other. Default: invoice.
    /// </summary>
    public string DocumentType { get; set; }

    /// <summary>
    /// Date of issue.
    /// </summary>
    public DateTime IssuedOn { get; set; }

    /// <summary>
    /// Chargeable event date.
    /// </summary>
    public DateTime TaxableFulfillmentDue { get; set; }

    /// <summary>
    /// Date when you received the expense from your supplier.
    /// </summary>
    public DateTime ReceivedOn { get; set; }

    /// <summary>
    /// Date when the expense becomes overdue.
    /// </summary>
    public DateTime DueOn { get; set; }

    /// <summary>
    /// Remind the upcoming due date with a Todo. Default: true.
    /// </summary>
    public bool RemindDueDate { get; set; }

    /// <summary>
    /// Date when the expense was marked as paid.
    /// </summary>
    public DateTime PaidOn { get; set; }

    /// <summary>
    /// Date and time when the expense was locked.
    /// </summary>
    public DateTime LockedAt { get; set; }

    /// <summary>
    /// Expense description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Private note.
    /// </summary>
    public string PrivateNote { get; set; }

    /// <summary>
    /// List of tags.
    /// </summary>
    public List<string> Tags { get; set; }

    /// <summary>
    /// Supplier bank account number. Default: Inherit from supplier subject.
    /// </summary>
    public string BankAccount { get; set; }

    /// <summary>
    /// Supplier bank account IBAN. Default: Inherit from supplier subject.
    /// </summary>
    public string Iban { get; set; }

    /// <summary>
    /// Supplier bank account BIC (for SWIFT payments). Default: Inherit from supplier subject.
    /// </summary>
    public string SwiftBic { get; set; }

    /// <summary>
    /// Payment method. Values: bank, cash, cod (cash on delivery), card, paypal, custom. Default: bank.
    /// </summary>
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Custom payment method (payment_method attribute must be set to custom, otherwise the custom_payment_method value is ignored and set to null). Value: String up to 20 characters.
    /// </summary>
    public string CustomPaymentMethod { get; set; }

    /// <summary>
    /// Currency ISO Code. Default: Inherit from account settings.
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Exchange rate (required if expense currency differs from account currency).
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Self-assesment of VAT? Default: false.
    /// </summary>
    public bool TransferredTaxLiability { get; set; }

    /// <summary>
    /// Supply code for statement about expenses in reverse charge.
    /// </summary>
    public string SupplyCode { get; set; }

    /// <summary>
    /// Calculate VAT from base or final amount. Values: without_vat, from_total_with_vat. Default: without_vat.
    /// </summary>
    public string VatPriceMode { get; set; }

    /// <summary>
    /// Proportional VAT deduction (percent). Default: 100.
    /// </summary>
    public int? ProportionalVatDeduction { get; set; }

    /// <summary>
    /// Tax deductible. Default: true.
    /// </summary>
    public bool TaxDeductible { get; set; }

    /// <summary>
    /// Total without VAT.
    /// </summary>
    public decimal? Subtotal { get; set; }

    /// <summary>
    /// Total with VAT.
    /// </summary>
    public decimal? Total { get; set; }

    /// <summary>
    /// Total without VAT in the account currency.
    /// </summary>
    public decimal? NativeSubtotal { get; set; }

    /// <summary>
    /// Total with VAT in the account currency.
    /// </summary>
    public decimal? NativeTotal { get; set; }

    /// <summary>
    /// List of lines to expense.
    /// </summary>
    public List<FakturoidLine> Lines { get; set; }

    /// <summary>
    /// VAT rates summary.
    /// </summary>
    public List<FakturoidVatRateSummary> VatRatesSummary { get; set; }

    /// <summary>
    /// List of payments.
    /// </summary>
    public List<FakturoidExpensePayment> Payments { get; set; }

    /// <summary>
    /// List of attachments.
    /// </summary>
    public List<FakturoidAttachment> Attachments { get; set; }

    /// <summary>
    /// Expense HTML web address.
    /// </summary>
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Expense API address.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Subject API address.
    /// </summary>
    public string SubjectUrl { get; set; }

    /// <summary>
    /// Date and time of expense creation.
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last expense update.
    /// </summary>
    public DateTimeOffset UpdatedAt { get; set; }
}
