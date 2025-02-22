using Newtonsoft.Json;

namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// Attachment for download
/// </summary>
public class FakturoidAttachment {
    /// <summary>
    /// Attachment file name.
    /// </summary>
    public string Filename { get; set; }

    /// <summary>
    /// Attachment file MIME type (download only).
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// API URL for file download (download only).
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Attachment contents in the form of a Data URI (upload only).
    /// </summary>
    public string DataUrl { get; set; }
}