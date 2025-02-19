namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Invoice number format.
/// </summary>
public class FakturoidNumberFormat {

    /// <summary>
    /// Unique identifier in Fakturoid.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Format.
    /// </summary>
    public string Format { get; set; }

    /// <summary>
    /// Preview of number format.
    /// </summary>
    public string Preview { get; set; }

    /// <summary>
    /// Default number format.
    /// </summary>
    public bool Default { get; set; }

    /// <summary>
    /// Date and time of number format creation.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and time of last number format update.
    /// </summary>
    public DateTime UpdatedAt { get; set; }

}
