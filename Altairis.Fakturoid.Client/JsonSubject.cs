using System;

namespace Altairis.Fakturoid.Client {

    public class JsonSubject {

        /// <summary>
        /// Identifikátor kontaktu
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Vlastní identifikátor kontaktu
        /// </summary>
        public string custom_id { get; set; }

        /// <summary>
        /// Obchodní jméno
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Ulice
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// Ulice - druhý řádek
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        /// Město
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// PSČ
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// Země
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// IČ
        /// </summary>
        public string registration_no { get; set; }

        /// <summary>
        /// DIČ
        /// </summary>
        public string vat_no { get; set; }

        /// <summary>
        /// Číslo účtu
        /// </summary>
        public string bank_account { get; set; }

        /// <summary>
        /// Číslo účtu jako IBAN
        /// </summary>
        public string iban { get; set; }

        /// <summary>
        /// Jméno kontaktní osoby
        /// </summary>
        public string full_name { get; set; }

        /// <summary>
        /// E-mail pro zasílání faktur
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// E-mail pro zasílání kopie faktury
        /// </summary>
        public string email_copy { get; set; }

        /// <summary>
        /// Telefonní číslo
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Adresa webu
        /// </summary>
        public string web { get; set; }

        /// <summary>
        /// Adresa kontaktu rawValue GUI
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// API adresa kontaktu
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Datum poslední aktualizace kontaktu
        /// </summary>
        public DateTime updated_at { get; set; }
    }
}