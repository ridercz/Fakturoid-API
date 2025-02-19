namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// Invoice line.
/// </summary>
public class FakturoidLine {
    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Line name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Quantity.
    /// </summary>
    public decimal Quantity { get; set; } = 1;

    /// <summary>
    /// Unit name.
    /// </summary>
    public string UnitName { get; set; }

    /// <summary>
    /// Unit price.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// VAT rate.
    /// </summary>
    public decimal VatRate { get; set; } = 0;

    /// <summary>
    /// Unit price without VAT.
    /// </summary>
    public decimal UnitPriceWithoutVat { get; set; }

    /// <summary>
    /// Unit price including VAT.
    /// </summary>
    public decimal UnitPriceWithVat { get; set; }

    /// <summary>
    /// Total price without VAT.
    /// </summary>
    public decimal TotalPriceWithoutVat { get; set; }

    /// <summary>
    /// Total VAT.
    /// </summary>
    public decimal TotalVat { get; set; }

    /// <summary>
    /// Total price without VAT in account currency.
    /// </summary>
    public decimal NativeTotalPriceWithoutVat { get; set; }

    /// <summary>
    /// Total VAT in account currency.
    /// </summary>
    public decimal NativeTotalVat { get; set; }

    /// <summary>
    /// ID of the related inventory item.
    /// </summary>
    public int InventoryItemId { get; set; }

    /// <summary>
    /// Stock Keeping Unit (SKU).
    /// </summary>
    public string Sku { get; set; }

    /// <summary>
    /// Inventory information.
    /// </summary>
    public FakturoidInventory Inventory { get; set; } = null;
}