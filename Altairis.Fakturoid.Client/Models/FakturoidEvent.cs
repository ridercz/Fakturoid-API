namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Event data.
/// </summary>
public partial class FakturoidEvent {

    /// <summary>
    /// Event name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Date and time of event creation
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Text of the event
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Attributes of objects related to the event
    /// </summary>
    public FakturoidRelatedObject[] RelatedObjects { get; set; }

    /// <summary>
    /// User details
    /// </summary>
    public FakturoidEventUser User { get; set; }

    /// <summary>
    /// Parameters with details about event, specific for each type of event
    /// </summary>
    public object Params { get; set; }

}