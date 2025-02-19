namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Generator
/// </summary>
public class FakturoidGenerator {

    /// <summary>
    /// Unique identifier in Fakturoid
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Identifier in your application
    /// </summary>
    public string CustomId { get; set; }

    /// <summary>
    /// Template name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Issue invoice as a proforma
    /// Default: false
    /// </summary>
    public bool Proforma { get; set; } = false;

    /// <summary>
    /// Show PayPal pay button on invoice
    /// Default: false
    /// </summary>
    public bool Paypal { get; set; } = false;

    /// <summary>
    /// Show GoPay pay button on invoice
    /// Default: false
    /// </summary>
    public bool Gopay { get; set; } = false;

    /// <summary>
    /// Set CED at the end of last month
    /// Default: false
    /// </summary>
    public bool TaxDateAtEndOfLastMonth { get; set; } = false;

    /// <summary>
    /// Number of days until the invoice is overdue
    /// Default: Inherit from account settings
    /// </summary>
    public int Due { get; set; }

    /// <summary>
    /// Subject ID
    /// </summary>
    public int SubjectId { get; set; }

    /// <summary>
    /// Number format ID
    /// Default: Inherit from default account settings
    /// </summary>
    public int NumberFormatId { get; set; }

    /// <summary>
    /// Text before invoice lines
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// Text in invoice footer
    /// </summary>
    public string FooterNote { get; set; }

    /// <summary>
    /// Display IBAN, BIC (SWIFT) and bank account number for legacy templates set without bank account ID
    /// Default: null
    /// </summary>
    public object LegacyBankDetails { get; set; } = null;

    /// <summary>
    /// Bank account ID
    /// Default: Inherit from account settings
    /// </summary>
    public int BankAccountId { get; set; }

    /// <summary>
    /// Controls IBAN visibility on the document webinvoice and PDF. IBAN must be valid to show
    /// Values: automatically, always
    /// Default: automatically
    /// </summary>
    public string IbanVisibility { get; set; } = "automatically";

    /// <summary>
    /// List of tags
    /// </summary>
    public List<string> Tags { get; set; }

    /// <summary>
    /// Order number
    /// </summary>
    public string OrderNumber { get; set; }

    /// <summary>
    /// Currency ISO code
    /// Default: Inherit from account settings
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Exchange rate
    /// </summary>
    public decimal ExchangeRate { get; set; }

    /// <summary>
    /// Payment method
    /// Values: bank, cash, cod (cash on delivery), card, paypal, custom
    /// Default: Inherit from account settings
    /// </summary>
    public string PaymentMethod { get; set; }

    /// <summary>
    /// Custom payment method (payment_method attribute must be set to custom, otherwise the custom_payment_method value is ignored and set to null)
    /// Value: String up to 20 characters
    /// Default: Inherit from account settings if default account payment method is set to custom
    /// </summary>
    public string CustomPaymentMethod { get; set; }

    /// <summary>
    /// Invoice language
    /// Values: cz, sk, en, de, fr, it, es, ru, pl, hu, ro
    /// Default: Inherit from account settings
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Calculate VAT from base or final amount, more info in a table below
    /// Values: without_vat, from_total_with_vat
    /// Default: Inherit from account settings
    /// </summary>
    public string VatPriceMode { get; set; }

    /// <summary>
    /// Use reverse charge
    /// Default: false
    /// </summary>
    public bool TransferredTaxLiability { get; set; } = false;

    /// <summary>
    /// Supply code for reverse charge
    /// List of codes
    /// </summary>
    public int SupplyCode { get; set; }

    /// <summary>
    /// Use OSS mode on invoice
    /// Values: disabled, service, goods
    /// Default: disabled
    /// </summary>
    public string Oss { get; set; } = "disabled";

    /// <summary>
    /// Round total amount (VAT included)
    /// Default: false
    /// </summary>
    public bool RoundTotal { get; set; } = false;

    /// <summary>
    /// Total amount without VAT
    /// </summary>
    public decimal Subtotal { get; set; }

    /// <summary>
    /// Total amount with VAT
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// Total amount without VAT in the account currency
    /// </summary>
    public decimal NativeSubtotal { get; set; }

    /// <summary>
    /// Total amount with VAT in the account currency
    /// </summary>
    public decimal NativeTotal { get; set; }

    /// <summary>
    /// List of lines to invoice
    /// </summary>
    public List<FakturoidLine> Lines { get; set; }

    /// <summary>
    /// Template HTML web address
    /// </summary>
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Template API address
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// API address of subject
    /// </summary>
    public string SubjectUrl { get; set; }

    /// <summary>
    /// Date and time of template creation
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last template update
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
