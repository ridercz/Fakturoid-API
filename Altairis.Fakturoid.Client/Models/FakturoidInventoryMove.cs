namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Inventory move.
/// </summary>
public class FakturoidInventoryMove {

    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Move direction. Values: in, out.
    /// </summary>
    public string Direction { get; set; }

    /// <summary>
    /// Move date.
    /// </summary>
    public DateTime MovedOn { get; set; }

    /// <summary>
    /// Item quantity in move.
    /// </summary>
    public decimal QuantityChange { get; set; }

    /// <summary>
    /// Purchase price per unit (without VAT).
    /// </summary>
    public decimal PurchasePrice { get; set; }

    /// <summary>
    /// Purchase currency. Values: Currency code (3 characters). Default: Inherit from account settings.
    /// </summary>
    public string PurchaseCurrency { get; set; }

    /// <summary>
    /// Unit purchase price in account currency.
    /// </summary>
    public decimal NativePurchasePrice { get; set; }

    /// <summary>
    /// Retail price per unit.
    /// </summary>
    public decimal RetailPrice { get; set; }

    /// <summary>
    /// Retail currency. Values: Currency code (3 characters). Default: Inherit from account settings.
    /// </summary>
    public string RetailCurrency { get; set; }

    /// <summary>
    /// Retail price in account currency.
    /// </summary>
    public decimal NativeRetailPrice { get; set; }

    /// <summary>
    /// Private note.
    /// </summary>
    public string PrivateNote { get; set; }

    /// <summary>
    /// Inventory item ID.
    /// </summary>
    public int InventoryItemId { get; set; }

    /// <summary>
    /// Details about document and line the move is tied to. Default: null.
    /// </summary>
    public object Document { get; set; }

    /// <summary>
    /// Date and time of move creation.
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last move update.
    /// </summary>
    public DateTimeOffset UpdatedAt { get; set; }

}
