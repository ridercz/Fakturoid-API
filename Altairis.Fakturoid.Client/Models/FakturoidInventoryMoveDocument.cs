namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Document related to inventory move.
/// </summary>
public class FakturoidInventoryMoveDocument {

    /// <summary>
    /// Gets or sets the document ID.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the type of document.
    /// Values: Estimate, Expense, ExpenseGenerator, Generator, Invoice
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the document line ID.
    /// </summary>
    public int LineId { get; set; }

}
