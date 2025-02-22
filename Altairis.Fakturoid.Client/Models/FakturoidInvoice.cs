namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Invoice data.
/// </summary>
public class FakturoidInvoice {
    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Identifier in your application.
    /// </summary>
    public string CustomId { get; set; }

    /// <summary>
    /// Type of document.
    /// Values: partial_proforma, proforma, correction, tax_document, final_invoice, invoice
    /// </summary>
    public string DocumentType { get; set; }

    /// <summary>
    /// What to issue after a proforma is paid.
    /// Values: final_invoice_paid, final_invoice, tax_document, none
    /// </summary>
    public string ProformaFollowupDocument { get; set; }

    /// <summary>
    /// Required only when creating a final invoice from tax documents.
    /// </summary>
    public List<int> TaxDocumentIds { get; set; }

    /// <summary>
    /// ID of the invoice being corrected.
    /// </summary>
    public int? CorrectionId { get; set; }

    /// <summary>
    /// Document number.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// ID of a number format.
    /// </summary>
    public int? NumberFormatId { get; set; }

    /// <summary>
    /// Variable symbol.
    /// </summary>
    public string VariableSymbol { get; set; }

    /// <summary>
    /// Name of your company.
    /// </summary>
    public string YourName { get; set; }

    /// <summary>
    /// Your address street.
    /// </summary>
    public string YourStreet { get; set; }

    /// <summary>
    /// Your address city.
    /// </summary>
    public string YourCity { get; set; }

    /// <summary>
    /// Your address postal code.
    /// </summary>
    public string YourZip { get; set; }

    /// <summary>
    /// Your address country (ISO code).
    /// </summary>
    public string YourCountry { get; set; }

    /// <summary>
    /// Your registration number (IČO).
    /// </summary>
    public string YourRegistrationNo { get; set; }

    /// <summary>
    /// Your VAT number (DIČ).
    /// </summary>
    public string YourVatNo { get; set; }

    /// <summary>
    /// Your SK DIČ (only for Slovakia, does not start with country code).
    /// </summary>
    public string YourLocalVatNo { get; set; }

    /// <summary>
    /// Subject company name.
    /// </summary>
    public string ClientName { get; set; }

    /// <summary>
    /// Subject address street.
    /// </summary>
    public string ClientStreet { get; set; }

    /// <summary>
    /// Subject address city.
    /// </summary>
    public string ClientCity { get; set; }

    /// <summary>
    /// Subject address postal code.
    /// </summary>
    public string ClientZip { get; set; }

    /// <summary>
    /// Subject address country (ISO code).
    /// </summary>
    public string ClientCountry { get; set; }

    /// <summary>
    /// Enable delivery address.
    /// </summary>
    public bool ClientHasDeliveryAddress { get; set; }

    /// <summary>
    /// Subject company delivery name.
    /// </summary>
    public string ClientDeliveryName { get; set; }

    /// <summary>
    /// Subject delivery address street.
    /// </summary>
    public string ClientDeliveryStreet { get; set; }

    /// <summary>
    /// Subject delivery address city.
    /// </summary>
    public string ClientDeliveryCity { get; set; }

    /// <summary>
    /// Subject delivery address postal code.
    /// </summary>
    public string ClientDeliveryZip { get; set; }

    /// <summary>
    /// Subject delivery address country (ISO code).
    /// </summary>
    public string ClientDeliveryCountry { get; set; }

    /// <summary>
    /// Subject registration number.
    /// </summary>
    public string ClientRegistrationNo { get; set; }

    /// <summary>
    /// Subject VAT number.
    /// </summary>
    public string ClientVatNo { get; set; }

    /// <summary>
    /// Subject SK DIČ (only for Slovakia, does not start with country code).
    /// </summary>
    public string ClientLocalVatNo { get; set; }

    /// <summary>
    /// Subject ID.
    /// </summary>
    public int SubjectId { get; set; }

    /// <summary>
    /// Subject identifier in your application.
    /// </summary>
    public string SubjectCustomId { get; set; }

    /// <summary>
    /// Generator ID from which the document was generated.
    /// </summary>
    public int? GeneratorId { get; set; }

    /// <summary>
    /// ID of related document.
    /// </summary>
    public int? RelatedId { get; set; }

    /// <summary>
    /// Enable PayPal payment button on invoice.
    /// </summary>
    public bool Paypal { get; set; }

    /// <summary>
    /// Enable GoPay payment button on invoice.
    /// </summary>
    public bool Gopay { get; set; }

    /// <summary>
    /// Token string for the webinvoice URL.
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// Current state of the document.
    /// Values: open, sent, overdue, paid, cancelled, uncollectible
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Order number in your application.
    /// </summary>
    public string OrderNumber { get; set; }

    /// <summary>
    /// Date of issue.
    /// </summary>
    public DateTime IssuedOn { get; set; }

    /// <summary>
    /// Chargeable event date.
    /// </summary>
    public string TaxableFulfillmentDue { get; set; }

    /// <summary>
    /// Number of days until the invoice becomes overdue.
    /// </summary>
    public int? Due { get; set; }

    /// <summary>
    /// Date when the invoice becomes overdue.
    /// </summary>
    public DateTime DueOn { get; set; }

    /// <summary>
    /// Date and time of sending the document via email.
    /// </summary>
    public DateTime SentAt { get; set; }

    /// <summary>
    /// Date when the document was marked as paid.
    /// </summary>
    public DateTime PaidOn { get; set; }

    /// <summary>
    /// Date and time of sending a reminder.
    /// </summary>
    public DateTime ReminderSentAt { get; set; }

    /// <summary>
    /// Date and time when the invoice was cancelled (only for non-VAT-payers).
    /// </summary>
    public DateTime CancelledAt { get; set; }

    /// <summary>
    /// Date and time when an invoice was marked as uncollectible.
    /// </summary>
    public DateTime UncollectibleAt { get; set; }

    /// <summary>
    /// Date and time when the document was locked.
    /// </summary>
    public DateTime LockedAt { get; set; }

    /// <summary>
    /// Date when the client visited the webinvoice.
    /// </summary>
    public DateTime WebinvoiceSeenOn { get; set; }

    /// <summary>
    /// Text before lines.
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// Invoice footer.
    /// </summary>
    public string FooterNote { get; set; }

    /// <summary>
    /// Private note.
    /// </summary>
    public string PrivateNote { get; set; }

    /// <summary>
    /// List of tags.
    /// </summary>
    public List<string> Tags { get; set; }

    /// <summary>
    /// Bank account ID (used only on create action).
    /// </summary>
    public int? BankAccountId { get; set; }

    /// <summary>
    /// Bank account number.
    /// </summary>
    public string BankAccount { get; set; }

    /// <summary>
    /// IBAN.
    /// </summary>
    public string Iban { get; set; }

    /// <summary>
    /// BIC (for SWIFT payments).
    /// </summary>
    public string SwiftBic { get; set; }

    /// <summary>
    /// Controls IBAN visibility on the document webinvoice and PDF.
    /// Values: automatically, always
    /// </summary>
    public string IbanVisibility { get; set; }

    /// <summary>
    /// Show „Do not pay, …“ on document webinvoice and PDF.
    /// </summary>
    public bool ShowAlreadyPaidNoteInPdf { get; set; }

    /// <summary>
    /// Payment method.
    /// Values: bank, cash, cod, card, paypal, custom
    /// </summary>
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Custom payment method.
    /// </summary>
    public string CustomPaymentMethod { get; set; }

    /// <summary>
    /// Hide bank account on webinvoice and PDF.
    /// </summary>
    public bool HideBankAccount { get; set; }

    /// <summary>
    /// Currency ISO code.
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Exchange rate (required if document currency differs from account currency).
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Language of the document.
    /// Values: cz, sk, en, de, fr, it, es, ru, pl, hu, ro
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Use reverse charge.
    /// </summary>
    public bool TransferredTaxLiability { get; set; }

    /// <summary>
    /// Supply code for statement about invoices in reverse charge.
    /// </summary>
    public string SupplyCode { get; set; }

    /// <summary>
    /// Use OSS mode.
    /// Values: disabled, service, goods
    /// </summary>
    public string Oss { get; set; }

    /// <summary>
    /// Calculate VAT from base or final amount.
    /// Values: without_vat, from_total_with_vat
    /// </summary>
    public string VatPriceMode { get; set; }

    /// <summary>
    /// Round total amount (VAT included).
    /// </summary>
    public bool RoundTotal { get; set; }

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
    /// Remaining amount to pay (VAT included).
    /// </summary>
    public decimal? RemainingAmount { get; set; }

    /// <summary>
    /// Remaining amount to pay in the account currency (VAT included).
    /// </summary>
    public decimal? RemainingNativeAmount { get; set; }

    /// <summary>
    /// List of lines to invoice.
    /// </summary>
    public List<FakturoidLine> Lines { get; set; }

    /// <summary>
    /// VAT rates summary.
    /// </summary>
    public List<FakturoidVatRateSummary> VatRatesSummary { get; set; }

    /// <summary>
    /// List of paid advances (if final invoice).
    /// </summary>
    public List<FakturoidInvoicePaidAdvance> PaidAdvances { get; set; }

    /// <summary>
    /// List of payments.
    /// </summary>
    public List<FakturoidInvoicePayment> Payments { get; set; }

    /// <summary>
    /// List of attachments.
    /// </summary>
    public List<FakturoidAttachment> Attachments { get; set; }

    /// <summary>
    /// Document HTML web address.
    /// </summary>
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Webinvoice web address.
    /// </summary>
    public string PublicHtmlUrl { get; set; }

    /// <summary>
    /// Document API address.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// PDF download address.
    /// </summary>
    public string PdfUrl { get; set; }

    /// <summary>
    /// Subject API address.
    /// </summary>
    public string SubjectUrl { get; set; }

    /// <summary>
    /// Date and time of document creation.
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last document update.
    /// </summary>
    public DateTimeOffset UpdatedAt { get; set; }
}