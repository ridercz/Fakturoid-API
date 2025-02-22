namespace Altairis.Fakturoid.Client.Models;

/// <summary>  
/// Paid advance  
/// </summary>  
public class FakturoidInvoicePaidAdvance {
    /// <summary>  
    /// Tax document ID.  
    /// </summary>  
    public int Id { get; set; }

    /// <summary>  
    /// Document number.  
    /// </summary>  
    public string Number { get; set; }

    /// <summary>  
    /// Variable symbol.  
    /// </summary>  
    public string VariableSymbol { get; set; }

    /// <summary>  
    /// Date of payment.  
    /// </summary>  
    public DateTime PaidOn { get; set; }

    /// <summary>  
    /// VAT rate.  
    /// </summary>  
    public decimal? VatRate { get; set; }

    /// <summary>  
    /// Price for given VAT rate.  
    /// </summary>  
    public decimal? Price { get; set; }

    /// <summary>  
    /// VAT for given VAT rate.  
    /// </summary>  
    public decimal? Vat { get; set; }
}
