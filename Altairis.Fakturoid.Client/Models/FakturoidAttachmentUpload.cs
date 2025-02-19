namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// Attachment.
/// </summary>
public class FakturoidAttachmentUpload {
    /// <summary>
    /// Attachment file name.
    /// </summary>
    public string Filename { get; set; }

    /// <summary>
    /// Attachment contents in the form of a Data URI.
    /// </summary>
    public string DataUrl { get; set; }
}