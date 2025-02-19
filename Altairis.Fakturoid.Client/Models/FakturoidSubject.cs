namespace Altairis.Fakturoid.Client.Models;

/// <summary>
/// Subject (contact).
/// </summary>
public class FakturoidSubject {
    /// <summary>Unique identifier in Fakturoid</summary>
    public int Id { get; set; }

    /// <summary>Identifier in your application</summary>
    public string CustomId { get; set; }

    /// <summary>User ID who created the subject</summary>
    public int UserId { get; set; }

    /// <summary>Type of subject. Values: "customer", "supplier", "both". Default: "customer"</summary>
    public string Type { get; set; } = "customer";

    /// <summary>Name of the subject</summary>
    public string Name { get; set; }

    /// <summary>Contact person name</summary>
    public string FullName { get; set; }

    /// <summary>Main email address to receive invoice emails</summary>
    public string Email { get; set; }

    /// <summary>Email copy address to receive invoice emails</summary>
    public string EmailCopy { get; set; }

    /// <summary>Phone number</summary>
    public string Phone { get; set; }

    /// <summary>Web page</summary>
    public string Web { get; set; }

    /// <summary>Street</summary>
    public string Street { get; set; }

    /// <summary>City</summary>
    public string City { get; set; }

    /// <summary>ZIP or postal code</summary>
    public string Zip { get; set; }

    /// <summary>Country (ISO code). Default: Account setting</summary>
    public string Country { get; set; }

    /// <summary>Enable delivery address. Default: false</summary>
    public bool HasDeliveryAddress { get; set; } = false;

    /// <summary>Delivery address name</summary>
    public string DeliveryName { get; set; }

    /// <summary>Delivery address street</summary>
    public string DeliveryStreet { get; set; }

    /// <summary>Delivery address city</summary>
    public string DeliveryCity { get; set; }

    /// <summary>Delivery address ZIP or postal code</summary>
    public string DeliveryZip { get; set; }

    /// <summary>Delivery address country (ISO code). Default: Account setting</summary>
    public string DeliveryCountry { get; set; }

    /// <summary>Number of days until an invoice is due for this subject. Default: Inherit from account settings</summary>
    public int? Due { get; set; }

    /// <summary>Currency (ISO code). Default: Inherit from account settings</summary>
    public string Currency { get; set; }

    /// <summary>Invoice language. Default: Inherit from account settings</summary>
    public string Language { get; set; }

    /// <summary>Private note</summary>
    public string PrivateNote { get; set; }

    /// <summary>Registration number (IČO)</summary>
    public string RegistrationNo { get; set; }

    /// <summary>VAT-payer VAT number (DIČ, IČ DPH in Slovakia, typically starts with the country code)</summary>
    public string VatNo { get; set; }

    /// <summary>SK DIČ (only in Slovakia, does not start with country code)</summary>
    public string LocalVatNo { get; set; }

    /// <summary>Unreliable VAT-payer</summary>
    public bool Unreliable { get; set; }

    /// <summary>Date of last check for unreliable VAT-payer</summary>
    public DateTime? UnreliableCheckedAt { get; set; }

    /// <summary>Legal form</summary>
    public string LegalForm { get; set; }

    /// <summary>VAT mode</summary>
    public string VatMode { get; set; }

    /// <summary>Bank account number</summary>
    public string BankAccount { get; set; }

    /// <summary>IBAN</summary>
    public string Iban { get; set; }

    /// <summary>SWIFT/BIC</summary>
    public string SwiftBic { get; set; }

    /// <summary>Fixed variable symbol (used for all invoices for this client instead of invoice number)</summary>
    public string VariableSymbol { get; set; }

    /// <summary>Whether to update subject data from ARES. Used to override account settings. Values: inherit, on, off. Default: inherit</summary>
    public string SettingUpdateFromAres { get; set; } = "inherit";

    /// <summary>Whether to update subject data from ARES. Used to override account settings. Default: true. Deprecated in favor of setting_update_from_ares</summary>
    public bool AresUpdate { get; set; } = true;

    /// <summary>Whether to attach invoice PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit</summary>
    public string SettingInvoicePdfAttachments { get; set; } = "inherit";

    /// <summary>Whether to attach estimate PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit</summary>
    public string SettingEstimatePdfAttachments { get; set; } = "inherit";

    /// <summary>Whether to send overdue invoice email reminders. Used to override account settings. Values: inherit, on, off. Default: inherit</summary>
    public string SettingInvoiceSendReminders { get; set; } = "inherit";

    /// <summary>Suggest for documents. Default: true</summary>
    public bool SuggestionEnabled { get; set; } = true;

    /// <summary>New invoice custom email text</summary>
    public string CustomEmailText { get; set; }

    /// <summary>Overdue reminder custom email text</summary>
    public string OverdueEmailText { get; set; }

    /// <summary>Proforma paid custom email text</summary>
    public string InvoiceFromProformaEmailText { get; set; }

    /// <summary>Thanks for payment custom email text</summary>
    public string ThankYouEmailText { get; set; }

    /// <summary>Estimate custom email text</summary>
    public string CustomEstimateEmailText { get; set; }

    /// <summary>Webinvoice history. Values: null, "disabled", "recent", "client_portal". Default: null (inherit from account settings)</summary>
    public string WebinvoiceHistory { get; set; }

    /// <summary>Subject HTML web address</summary>
    public string HtmlUrl { get; set; }

    /// <summary>Subject API address</summary>
    public string Url { get; set; }

    /// <summary>Date and time of subject creation</summary>
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>Date and time of last subject update</summary>
    public DateTimeOffset UpdatedAt { get; set; }
}