namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Invoice message
/// </summary>
public class FakturoidInvoiceMessage {

    /// <summary>
    /// Email subject
    /// Default: Inherit from account settings
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Email address
    /// Default: Inherit from invoice subject
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Email copy address
    /// Default: Inherit from invoice subject
    /// </summary>
    public string EmailCopy { get; set; }

    /// <summary>
    /// Email message
    /// Default: Inherit from account settings
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Deliver e-mail immediately if you are outside of the delivery times set in settings
    /// Default: false
    /// This option has effect only if you have set e-mail delivery window in Fakturoid settings and you are outside of the given times. If the delivery times are not set or you are in the given window e-mail are always sent immediately.
    /// </summary>
    public bool DeliverNow { get; set; } = false;

}
