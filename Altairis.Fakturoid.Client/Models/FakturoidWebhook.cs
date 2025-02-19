namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Webhook
/// </summary>
public class FakturoidWebhook {

    /// <summary>
    /// Unique identifier in Fakturoid
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// URL of webhook endpoint
    /// </summary>
    public string WebhookUrl { get; set; }

    /// <summary>
    /// Value send in Authorization header
    /// </summary>
    public string AuthHeader { get; set; }

    /// <summary>
    /// Send webhook?
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// List of events when webhook is fired
    /// </summary>
    public List<string> Events { get; set; }

    /// <summary>
    /// Webhook API address
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Date and time of webhook creation
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last webhook update
    /// </summary>
    public DateTime UpdatedAt { get; set; }

}
