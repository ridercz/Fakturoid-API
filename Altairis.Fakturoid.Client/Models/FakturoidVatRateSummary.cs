namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// VAT rate summary.
/// </summary>
public class FakturoidVatRateSummary {
    /// <summary>
    /// VAT rate.
    /// </summary>
    public decimal VatRate { get; set; }

    /// <summary>
    /// Base total.
    /// </summary>
    public decimal Base { get; set; }

    /// <summary>
    /// VAT total.
    /// </summary>
    public decimal Vat { get; set; }

    /// <summary>
    /// Currency.
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Base total in account currency.
    /// </summary>
    public decimal NativeBase { get; set; }

    /// <summary>
    /// VAT total in account currency.
    /// </summary>
    public decimal NativeVat { get; set; }

    /// <summary>
    /// Account currency.
    /// </summary>
    public string NativeCurrency { get; set; }
}
