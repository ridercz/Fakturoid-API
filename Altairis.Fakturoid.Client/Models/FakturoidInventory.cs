namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// Inventory information.
/// </summary>
public class FakturoidInventory {
    /// <summary>
    /// ID of the related inventory item.
    /// </summary>
    public int ItemId { get; set; }

    /// <summary>
    /// Stock Keeping Unit (SKU).
    /// </summary>
    public string Sku { get; set; }

    /// <summary>
    /// Article number type (only if article_number is present).
    /// Values: ian, ean, isbn
    /// </summary>
    public string ArticleNumberType { get; set; }

    /// <summary>
    /// Article number (if present).
    /// </summary>
    public string ArticleNumber { get; set; }

    /// <summary>
    /// ID of the related inventory move.
    /// </summary>
    public int MoveId { get; set; }

}