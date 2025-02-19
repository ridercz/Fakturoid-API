namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// Attachment for download
/// </summary>
public class FakturoidAttachment {
    /// <summary>
    /// Attachment file name.
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Attachment file MIME type.
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// API URL for file download.
    /// </summary>
    public string DownloadUrl { get; set; }
}