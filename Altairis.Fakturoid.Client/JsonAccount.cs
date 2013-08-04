using System;

namespace Altairis.Fakturoid.Client {

    public class JsonAccount {

        /// <summary>
        /// Subdoména
        /// </summary>
        public string subdomain { get; set; }

        /// <summary>
        /// Jméno tarifu
        /// </summary>
        public string plan { get; set; }

        /// <summary>
        /// Cena tarifu
        /// </summary>
        public int plan_price { get; set; }

        /// <summary>
        /// E-mail vlastníka účtu
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// E-mail, ze kterého jsou odesílány faktury
        /// </summary>
        public string invoice_email { get; set; }

        /// <summary>
        /// Telefon vlastníka účtu
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Web vlastníka účtu
        /// </summary>
        public string web { get; set; }

        /// <summary>
        /// Jméno firmy
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Jméno majitele účtu
        /// </summary>
        public string full_name { get; set; }

        /// <summary>
        /// IČ
        /// </summary>
        public string registration_no { get; set; }

        /// <summary>
        /// DIČ
        /// </summary>
        public string vat_no { get; set; }

        /// <summary>
        /// Ulice
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// Ulice - druhý řádek
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        /// Místo
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// PSČ
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// ISO kód země
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Číslo účtu
        /// </summary>
        public string bank_account { get; set; }

        /// <summary>
        /// Číslo účtu jako IBAN
        /// </summary>
        public string iban { get; set; }

        /// <summary>
        /// BIC (pro SWIFT platby)
        /// </summary>
        public string swift_bic { get; set; }

        /// <summary>
        /// Měna
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Výchozí měrná jednotka
        /// </summary>
        public string unit_name { get; set; }

        /// <summary>
        /// Výchozí sazba DPH
        /// </summary>
        public decimal vat_rate { get; set; }

        /// <summary>
        /// Text patičky faktury
        /// </summary>
        public string displayed_note { get; set; }

        /// <summary>
        /// Text před položkami faktury
        /// </summary>
        public string invoice_note { get; set; }

        /// <summary>
        /// Výchozí splatnost faktur
        /// </summary>
        public int due { get; set; }

        /// <summary>
        /// Adresa účtu v GUI
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// Adresa API
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Datum poslední úpravy účtu
        /// </summary>
        public DateTime updated_at { get; set; }

        /// <summary>
        /// Datum vytvoření účtu
        /// </summary>
        public DateTime created_at { get; set; }
    }
}