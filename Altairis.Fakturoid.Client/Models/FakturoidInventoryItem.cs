namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Inventory item data.
/// </summary>
public class FakturoidInventoryItem {
    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Item name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Stock Keeping Unit (SKU). Required if track_quantity is enabled.
    /// </summary>
    public string Sku { get; set; }

    /// <summary>
    /// Article number type. Values: ian, ean, isbn. Default: ian.
    /// </summary>
    public string ArticleNumberType { get; set; }

    /// <summary>
    /// Article number.
    /// </summary>
    public string ArticleNumber { get; set; }

    /// <summary>
    /// Unit of measure.
    /// </summary>
    public string UnitName { get; set; }

    /// <summary>
    /// Track quantity via inventory moves? Default: false.
    /// </summary>
    public bool TrackQuantity { get; set; }

    /// <summary>
    /// Quantity in stock. Required if track_quantity is enabled. Becomes read-only after item creation and can be changed only via inventory moves.
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Minimum stock quantity.
    /// </summary>
    public decimal MinQuantity { get; set; }

    /// <summary>
    /// Maximum stock quantity.
    /// </summary>
    public decimal MaxQuantity { get; set; }

    /// <summary>
    /// Allow quantity below zero. Default: false.
    /// </summary>
    public bool AllowBelowZero { get; set; }

    /// <summary>
    /// Date when item quantity dropped below min_quantity.
    /// </summary>
    public DateTime LowQuantityDate { get; set; }

    /// <summary>
    /// Unit purchase price without VAT in account currency. Required if track_quantity is enabled.
    /// </summary>
    public decimal NativePurchasePrice { get; set; }

    /// <summary>
    /// Unit retail price without VAT in account currency.
    /// </summary>
    public decimal NativeRetailPrice { get; set; }

    /// <summary>
    /// VAT rate. Values: standard (21%), reduced (15%), reduced2 (10%), zero (0%).
    /// </summary>
    public string VatRate { get; set; }

    /// <summary>
    /// Average purchase price in account currency.
    /// </summary>
    public decimal AverageNativePurchasePrice { get; set; }

    /// <summary>
    /// Item type. Values: goods, service. Default: goods.
    /// </summary>
    public string SupplyType { get; set; }

    /// <summary>
    /// If item is archived.
    /// </summary>
    public bool Archived { get; set; }

    /// <summary>
    /// Private note.
    /// </summary>
    public string PrivateNote { get; set; }

    /// <summary>
    /// Suggest item for documents. Values: invoices, expenses, both. Default: both.
    /// </summary>
    public string SuggestFor { get; set; }

    /// <summary>
    /// Date and time of item creation.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last item update.
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
