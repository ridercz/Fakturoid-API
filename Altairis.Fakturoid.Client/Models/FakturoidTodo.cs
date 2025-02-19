namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Todo task.
/// </summary>
public class FakturoidTodo {

    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Todo name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Date and time of todo creation.
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Date and time of todo completion.
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Todo text.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Attributes of objects related to the todo.
    /// </summary>
    public List<FakturoidRelatedObject> RelatedObjects { get; set; }

    /// <summary>
    /// Parameters with details about todo, specific for each type of todo.
    /// </summary>
    public object Params { get; set; }

}