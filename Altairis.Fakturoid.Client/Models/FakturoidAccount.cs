namespace Altairis.Fakturoid.Client.Models; 

/// <summary>
/// Account data.
/// </summary>
public class FakturoidAccount {

    /// <summary>
    /// Subdomain.
    /// </summary>
    public string Subdomain { get; set; }

    /// <summary>
    /// Subscription plan.
    /// </summary>
    public string Plan { get; set; }

    /// <summary>
    /// Price of subscription plan.
    /// </summary>
    public int PlanPrice { get; set; }

    /// <summary>
    /// Number of paid users.
    /// </summary>
    public int PlanPaidUsers { get; set; }

    /// <summary>
    /// Email for sending invoices.
    /// </summary>
    public string InvoiceEmail { get; set; }

    /// <summary>
    /// Phone number.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Account owner's website.
    /// </summary>
    public string Web { get; set; }

    /// <summary>
    /// The name of the company.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Name of the account holder.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Registration number.
    /// </summary>
    public string RegistrationNo { get; set; }

    /// <summary>
    /// Tax identification number.
    /// </summary>
    public string VatNo { get; set; }

    /// <summary>
    /// Tax identification number for SK subject.
    /// </summary>
    public string LocalVatNo { get; set; }

    /// <summary>
    /// VAT mode.
    /// </summary>
    public string VatMode { get; set; }

    /// <summary>
    /// VAT calculation mode.
    /// </summary>
    public string VatPriceMode { get; set; }

    /// <summary>
    /// Street.
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Postal code.
    /// </summary>
    public string Zip { get; set; }

    /// <summary>
    /// Country (ISO Code).
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Default currency (ISO Code).
    /// </summary>
    public string Currency { get; set; }

    /// <summary>
    /// Default measurement unit.
    /// </summary>
    public string UnitName { get; set; }

    /// <summary>
    /// Default VAT rate.
    /// </summary>
    public int VatRate { get; set; }

    /// <summary>
    /// Invoice footer.
    /// </summary>
    public string DisplayedNote { get; set; }

    /// <summary>
    /// Text before lines.
    /// </summary>
    public string InvoiceNote { get; set; }

    /// <summary>
    /// Default number of days until an invoice becomes overdue.
    /// </summary>
    public int Due { get; set; }

    /// <summary>
    /// Default invoice language.
    /// </summary>
    public string InvoiceLanguage { get; set; }

    /// <summary>
    /// Default payment method.
    /// </summary>
    public string InvoicePaymentMethod { get; set; }

    /// <summary>
    /// Issue proforma by default.
    /// </summary>
    public bool InvoiceProforma { get; set; }

    /// <summary>
    /// Hide bank account for payments.
    /// </summary>
    public string[] InvoiceHideBankAccountForPayments { get; set; }

    /// <summary>
    /// Fixed exchange rate.
    /// </summary>
    public bool FixedExchangeRate { get; set; }

    /// <summary>
    /// Selfbilling enabled?
    /// </summary>
    public bool InvoiceSelfbilling { get; set; }

    /// <summary>
    /// Default estimate in English.
    /// </summary>
    public string DefaultEstimateType { get; set; }

    /// <summary>
    /// Send overdue reminders automatically?
    /// </summary>
    public bool SendOverdueEmail { get; set; }

    /// <summary>
    /// Days after the due date to send an automatic overdue reminder?
    /// </summary>
    public int OverdueEmailDays { get; set; }

    /// <summary>
    /// Send automatic overdue reminders repeatedly?
    /// </summary>
    public bool SendRepeatedReminders { get; set; }

    /// <summary>
    /// Send email automatically when proforma is paid?
    /// </summary>
    public bool SendInvoiceFromProformaEmail { get; set; }

    /// <summary>
    /// Send a thank you email when invoices is paid automatically?
    /// </summary>
    public bool SendThankYouEmail { get; set; }

    /// <summary>
    /// PayPal enabled for all invoices?
    /// </summary>
    public bool InvoicePaypal { get; set; }

    /// <summary>
    /// GoPay enabled for all invoices?
    /// </summary>
    public bool InvoiceGopay { get; set; }

    /// <summary>
    /// Digitoo service enabled?
    /// </summary>
    public bool DigitooEnabled { get; set; }

    /// <summary>
    /// Digitoo service auto processing enabled.
    /// </summary>
    public bool DigitooAutoProcessingEnabled { get; set; }

    /// <summary>
    /// Number of remaining extractions by Digitoo service.
    /// </summary>
    public int DigitooExtractionsRemaining { get; set; }

    /// <summary>
    /// Account creation date.
    /// </summary>
    public string CreatedAt { get; set; }

    /// <summary>
    /// The date the account was last modified.
    /// </summary>
    public string UpdatedAt { get; set; }

}