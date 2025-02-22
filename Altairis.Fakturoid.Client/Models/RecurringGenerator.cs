namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Recurring invoice generator.
/// </summary>
public class RecurringGenerator {
    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Identifier in your application.
    /// </summary>
    public string CustomId { get; set; }

    /// <summary>
    /// Generator name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Generator is active or paused.
    /// </summary>
    /// <value>true (active), false (paused). Default: true</value>
    public bool Active { get; set; } = true;

    /// <summary>
    /// Issue invoice as a proforma.
    /// </summary>
    /// <value>Default: false</value>
    public bool Proforma { get; set; } = false;

    /// <summary>
    /// Show PayPal pay button on invoice.
    /// </summary>
    /// <value>Default: false</value>
    public bool Paypal { get; set; } = false;

    /// <summary>
    /// Show GoPay pay button on invoice.
    /// </summary>
    /// <value>Default: false</value>
    public bool Gopay { get; set; } = false;

    /// <summary>
    /// Start date.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// End date.
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Number of months until the next invoice.
    /// </summary>
    public int MonthsPeriod { get; set; }

    /// <summary>
    /// Next invoice date.
    /// </summary>
    public DateTime NextOccurrenceOn { get; set; }

    /// <summary>
    /// Issue an invoice on the last day of the month.
    /// </summary>
    /// <value>Default: false</value>
    public bool LastDayInMonth { get; set; } = false;

    /// <summary>
    /// Set CED at the end of last month.
    /// </summary>
    /// <value>Default: false</value>
    public bool TaxDateAtEndOfLastMonth { get; set; } = false;

    /// <summary>
    /// Number of days until the invoice is overdue.
    /// </summary>
    /// <value>Default: Inherit from account settings</value>
    public int Due { get; set; }

    /// <summary>
    /// Send invoice by email.
    /// </summary>
    /// <value>Default: false</value>
    public bool SendEmail { get; set; } = false;

    /// <summary>
    /// Subject ID.
    /// </summary>
    public int SubjectId { get; set; }

    /// <summary>
    /// Number format ID.
    /// </summary>
    /// <value>Default: Inherit from default account settings</value>
    public int NumberFormatId { get; set; }

    /// <summary>
    /// Text before invoice lines.
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// Text in invoice footer.
    /// </summary>
    public string FooterNote { get; set; }

    /// <summary>
    /// Display IBAN, BIC (SWIFT) and bank account number for legacy generators set without bank account ID.
    /// </summary>
    /// <value>Default: null</value>
    public FakturoidLegacyBankDetails LegacyBankDetails { get; set; }

    /// <summary>
    /// Bank account ID.
    /// </summary>
    /// <value>Default: Inherit from account settings</value>
    public int BankAccountId { get; set; }

    /// <summary>
    /// Controls IBAN visibility on the document webinvoice and PDF. IBAN must be valid to show.
    /// </summary>
    /// <value>Values: automatically, always. Default: automatically</value>
    public string IbanVisibility { get; set; }

    /// <summary>
    /// List of tags.
    /// </summary>
    public List<string> Tags { get; set; }

    /// <summary>
    /// Order number.
    /// </summary>
    public string OrderNumber { get; set; }

    /// <summary>
    /// Currency ISO code.
    /// </summary>
    /// <value>Default: Inherit from account settings</value>
    public string Currency { get; set; }

    /// <summary>
    /// Exchange rate.
    /// </summary>
    public decimal ExchangeRate { get; set; }

    /// <summary>
    /// Payment method.
    /// </summary>
    /// <value>Values: bank, cash, cod (cash on delivery), card, paypal, custom. Default: Inherit from account settings</value>
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Custom payment method (payment_method attribute must be set to custom, otherwise the custom_payment_method value is ignored and set to null).
    /// </summary>
    /// <value>String up to 20 characters. Default: Inherit from account settings if default account payment method is set to custom</value>
    public string CustomPaymentMethod { get; set; }

    /// <summary>
    /// Invoice language.
    /// </summary>
    /// <value>Values: cz, sk, en, de, fr, it, es, ru, pl, hu, ro. Default: Inherit from account settings</value>
    public string Language { get; set; }

    /// <summary>
    /// Calculate VAT from base or final amount.
    /// </summary>
    /// <value>Values: without_vat, from_total_with_vat. Default: Inherit from account settings</value>
    public string VatPriceMode { get; set; }

    /// <summary>
    /// Use reverse charge.
    /// </summary>
    /// <value>Default: false</value>
    public bool TransferredTaxLiability { get; set; } = false;

    /// <summary>
    /// Supply code for reverse charge.
    /// </summary>
    public int SupplyCode { get; set; }

    /// <summary>
    /// Use OSS mode on invoice.
    /// </summary>
    /// <value>Values: disabled, service, goods. Default: disabled</value>
    public string Oss { get; set; }

    /// <summary>
    /// Round total amount (VAT included).
    /// </summary>
    /// <value>Default: false</value>
    public bool RoundTotal { get; set; } = false;

    /// <summary>
    /// Total amount without VAT.
    /// </summary>
    public decimal Subtotal { get; set; }

    /// <summary>
    /// Total amount with VAT.
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// Total amount without VAT in the account currency.
    /// </summary>
    public decimal NativeSubtotal { get; set; }

    /// <summary>
    /// Total amount with VAT in the account currency.
    /// </summary>
    public decimal NativeTotal { get; set; }

    /// <summary>
    /// List of lines to invoice. You can use variables for inserting dates to your text.
    /// </summary>
    public List<FakturoidLine> Lines { get; set; }

    /// <summary>
    /// Generator HTML web address.
    /// </summary>
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Generator API address.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// API address of subject.
    /// </summary>
    public string SubjectUrl { get; set; }

    /// <summary>
    /// Date and time of generator creation.
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last generator update.
    /// </summary>
    public DateTimeOffset UpdatedAt { get; set; }
}
