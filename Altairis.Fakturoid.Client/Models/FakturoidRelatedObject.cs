namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// Represents an object related to the event.
/// </summary>
public class FakturoidRelatedObject {

    /// <summary>
    /// Type of the object related to the event
    /// Values: Invoice, Subject, Expense, Generator, RecurringGenerator, ExpenseGenerator, Estimate
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// ID of the object related to event
    /// </summary>
    public int Id { get; set; }
}
