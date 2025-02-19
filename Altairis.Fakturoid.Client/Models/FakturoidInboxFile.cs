namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Inbox file
/// </summary>
public class FakturoidInboxFile {

    /// <summary>
    /// Unique identifier in Fakturoid
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// File name (with extension)
    /// </summary>
    public string Filename { get; set; }

    /// <summary>
    /// File size in bytes
    /// </summary>
    public int Bytesize { get; set; }

    /// <summary>
    /// The file will be sent to OCR
    /// </summary>
    public bool SendToOcr { get; set; }

    /// <summary>
    /// The date and time the file was sent to OCR
    /// </summary>
    public DateTime? SentToOcrAt { get; set; }

    /// <summary>
    /// OCR file processing status
    /// Values: created, processing, processing_failed, processing_rejected, processed
    /// Note: null value is returned when the file is not sent to OCR
    /// </summary>
    public string OcrStatus { get; set; }

    /// <summary>
    /// The date and time the OCR file was completed
    /// </summary>
    public DateTime? OcrCompletedAt { get; set; }

    /// <summary>
    /// URL to download the file
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// The date and time of file creation
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The date and time of last file update
    /// </summary>
    public DateTime UpdatedAt { get; set; }

}
