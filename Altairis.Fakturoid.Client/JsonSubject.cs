using System;

namespace Altairis.Fakturoid.Client {
    /// <summary>
    /// Subject (contact), as received from JSON API.
    /// </summary>
    public class JsonSubject {

        /// <summary>
        /// Unique identifier in Fakturoid
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Identifier in your application
        /// </summary>
        public string custom_id { get; set; }

        /// <summary>
        /// User ID who created the subject
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Type of subject. Values: "customer", "supplier", "both". Default: "customer"
        /// </summary>
        public string type { get; set; } = "customer";

        /// <summary>
        /// Name of the subject
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Contact person name
        /// </summary>
        public string full_name { get; set; }

        /// <summary>
        /// Main email address to receive invoice emails
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Email copy address to receive invoice emails
        /// </summary>
        public string email_copy { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Web page
        /// </summary>
        public string web { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// ZIP or postal code
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// Country (ISO code). Default: Account setting
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Enable delivery address. Default: false
        /// </summary>
        public bool has_delivery_address { get; set; } = false;

        /// <summary>
        /// Delivery address name
        /// </summary>
        public string delivery_name { get; set; }

        /// <summary>
        /// Delivery address street
        /// </summary>
        public string delivery_street { get; set; }

        /// <summary>
        /// Delivery address city
        /// </summary>
        public string delivery_city { get; set; }

        /// <summary>
        /// Delivery address ZIP or postal code
        /// </summary>
        public string delivery_zip { get; set; }

        /// <summary>
        /// Delivery address country (ISO code). Default: Account setting
        /// </summary>
        public string delivery_country { get; set; }

        /// <summary>
        /// Number of days until an invoice is due for this subject. Default: Inherit from account settings
        /// </summary>
        public int due { get; set; }

        /// <summary>
        /// Currency (ISO code). Default: Inherit from account settings
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Invoice language. Default: Inherit from account settings
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// Private note
        /// </summary>
        public string private_note { get; set; }

        /// <summary>
        /// Registration number (IČO)
        /// </summary>
        public string registration_no { get; set; }

        /// <summary>
        /// VAT-payer VAT number (DIČ, IČ DPH in Slovakia, typically starts with the country code)
        /// </summary>
        public string vat_no { get; set; }

        /// <summary>
        /// SK DIČ (only in Slovakia, does not start with country code)
        /// </summary>
        public string local_vat_no { get; set; }

        /// <summary>
        /// Unreliable VAT-payer
        /// </summary>
        public bool unreliable { get; set; }

        /// <summary>
        /// Date of last check for unreliable VAT-payer
        /// </summary>
        public DateTime? unreliable_checked_at { get; set; }

        /// <summary>
        /// Legal form
        /// </summary>
        public string legal_form { get; set; }

        /// <summary>
        /// VAT mode
        /// </summary>
        public string vat_mode { get; set; }

        /// <summary>
        /// Bank account number
        /// </summary>
        public string bank_account { get; set; }

        /// <summary>
        /// IBAN
        /// </summary>
        public string iban { get; set; }

        /// <summary>
        /// SWIFT/BIC
        /// </summary>
        public string swift_bic { get; set; }

        /// <summary>
        /// Fixed variable symbol (used for all invoices for this client instead of invoice number)
        /// </summary>
        public string variable_symbol { get; set; }

        /// <summary>
        /// Whether to update subject data from ARES. Used to override account settings. Values: inherit, on, off. Default: inherit
        /// </summary>
        public string setting_update_from_ares { get; set; } = "inherit";

        /// <summary>
        /// Whether to update subject data from ARES. Used to override account settings. Default: true. Deprecated in favor of setting_update_from_ares
        /// </summary>
        public bool ares_update { get; set; } = true;

        /// <summary>
        /// Whether to attach invoice PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit
        /// </summary>
        public string setting_invoice_pdf_attachments { get; set; } = "inherit";

        /// <summary>
        /// Whether to attach estimate PDF in email. Used to override account settings. Values: inherit, on, off. Default: inherit
        /// </summary>
        public string setting_estimate_pdf_attachments { get; set; } = "inherit";

        /// <summary>
        /// Whether to send overdue invoice email reminders. Used to override account settings. Values: inherit, on, off. Default: inherit
        /// </summary>
        public string setting_invoice_send_reminders { get; set; } = "inherit";

        /// <summary>
        /// Suggest for documents. Default: true
        /// </summary>
        public bool suggestion_enabled { get; set; } = true;

        /// <summary>
        /// New invoice custom email text
        /// </summary>
        public string custom_email_text { get; set; }

        /// <summary>
        /// Overdue reminder custom email text
        /// </summary>
        public string overdue_email_text { get; set; }

        /// <summary>
        /// Proforma paid custom email text
        /// </summary>
        public string invoice_from_proforma_email_text { get; set; }

        /// <summary>
        /// Thanks for payment custom email text
        /// </summary>
        public string thank_you_email_text { get; set; }

        /// <summary>
        /// Estimate custom email text
        /// </summary>
        public string custom_estimate_email_text { get; set; }

        /// <summary>
        /// Webinvoice history. Values: null, "disabled", "recent", "client_portal". Default: null (inherit from account settings)
        /// </summary>
        public string webinvoice_history { get; set; }

        /// <summary>
        /// Subject HTML web address
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// Subject API address
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Date and time of subject creation
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// Date and time of last subject update
        /// </summary>
        public DateTime updated_at { get; set; }
 
    }
}