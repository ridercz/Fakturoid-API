using System;
using System.Collections.Generic;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// User account information, as received from JSON API.
    /// Single invoice
    /// </summary>
    public class JsonExpense {

        /// <summary>
        /// Identifikátor nákladu
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// identifikátor nákladu ve vaší aplikaci
        /// </summary>
        public string custom_id { get; set; }

        /// <summary>
        /// číslo nákladu (Př: N20150101, musí odpovídat formátu čísla v nastavení účtu, doplní se automaticky)
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// číslo dokladu (uvedené na přijaté faktuře)
        /// </summary>
        public string original_number { get; set; }

        /// <summary>
        /// Variabilní symbol
        /// </summary>
        public string variable_symbol { get; set; }

        /// <summary>
        /// Nazev firmy kontaktu
        /// </summary>
        public string supplier_name { get; set; }

        /// <summary>
        /// kontakt ulice
        /// </summary>
        public string supplier_street { get; set; }


        /// <summary>
        /// kontakt město
        /// </summary>
        public string supplier_city { get; set; }

        /// <summary>
        /// kontakt PSČ
        /// </summary>
        public string supplier_zip { get; set; }

        /// <summary>
        /// kontakt země
        /// </summary>
        public string supplier_country { get; set; }

        /// <summary>
        /// kontakt IČ
        /// </summary>
        public string supplier_registration_no { get; set; }

        /// <summary>
        /// kontakt DIČ
        /// </summary>
        public string supplier_vat_no { get; set; }

     
        /// <summary>
        /// ID kontaktu příjemce
        /// </summary>
        public int subject_id { get; set; }

        /// <summary>
        /// Stav nákladu - open/overdue/paid
        /// </summary>
        public string status { get; set; }


        /// <summary>
        /// typ dokumentu - bill/invoice/other
        /// </summary>
        public string document_type { get; set; }

        /// <summary>
        /// Datum vystavení (zobrazeno na faktuře)
        /// </summary>
        public DateTime? issued_on { get; set; }

        /// <summary>
        /// Datum přijetí (nepovinné - doplní se dle duzp)
        /// </summary>
        public DateTime? received_on { get; set; }

        /// <summary>
        /// Datum zdanitelného plnění (nepovinné - doplní se dnes)
        /// </summary>
        public DateTime? taxable_fulfillment_due { get; set; }

        /// <summary>
        /// Datum splatnosti (doplní se podle due)
        /// </summary>
        public DateTime? due_on { get; set; }


        /// <summary>
        /// Datum a čas zaplacení nákladu
        /// </summary>
        public DateTime? paid_on { get; set; }


        /// <summary>
        /// popis (nepovinné)
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Soukromá poznámka (nepovinné)
        /// </summary>
        public string private_note { get; set; }

        /// <summary>
        /// Seznam tagů nákladu
        /// </summary>
        public ICollection<string> tags { get; set; }

        /// <summary>
        /// Číslo bankovního účtu (nepovinné - doplní se z účtu)
        /// </summary>
        public string bank_account { get; set; }

        /// <summary>
        /// IBAN (nepovinné - doplní se z účtu)
        /// </summary>
        public string iban { get; set; }

        /// <summary>
        /// BIC (nepovinné - doplní se z účtu)
        /// </summary>
        public string swift_bic { get; set; }

        /// <summary>
        /// Způsob úhrady: bank (bankovní převod) / cash (hotově) / cod (dobírka)
        /// </summary>
        public string payment_method { get; set; }

        /// <summary>
        /// Kód měny (nepovinné - doplní se z účtu, 3 znaky)
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Kurz (nepovinné)
        /// </summary>
        public decimal exchange_rate { get; set; }

        /// <summary>
        /// Přenesená daňová povinnost
        /// </summary>
        public bool transferred_tax_liability { get; set; }

        
        /// <summary>
        /// Způsob zadávání cen do řádků (hodnoty: null, without_vat, with_vat, default: dle účtu).
        /// Je ignorováno, pokud účet je neplátce DPH nebo je zapnuta přenesená daňová povinnost.
        /// </summary>
        public string vat_price_mode { get; set; }

        /// <summary>
        /// Kód plnění pro souhrnná hlášení (pouze pro zahraniční nákladu do EU, nepovinné)
        /// </summary>
        public int? supply_code { get; set; }


        /// <summary>
        /// Zaokrouhlit cenu s DPH při vystavení (nepovinné)
        /// </summary>
        public bool? round_total { get; set; }

        /// <summary>
        /// Součet bez DPH
        /// </summary>
        public decimal subtotal { get; set; }

        /// <summary>
        /// Součet bez DPH v měně účtu
        /// </summary>
        public decimal native_subtotal { get; set; }
        
        /// <summary>
        /// Součet včetně DPH
        /// </summary>
        public decimal total { get; set; }

        /// <summary>
        /// Součet včetně DPH v měně účtu
        /// </summary>
        public decimal native_total { get; set; }

        /// <summary>
        /// Příloha
        /// </summary>
        public JsonAttachment attachment { get; set; }

        /// <summary>
        /// Adresa nákladu v GUI
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// API adresa nákladu
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// API adresa pro stažení nákladu v PDF
        /// </summary>
        public string pdf_url { get; set; }

        /// <summary>
        /// API adresa kontaktu příjemce
        /// </summary>
        public string subject_url { get; set; }

        /// <summary>
        /// Datum vytvoreni nákladu
        /// </summary>
        public DateTime? created_at { get; set; }

        /// <summary>
        /// Datum poslední aktualizace nákladu
        /// </summary>
        public DateTime? updated_at { get; set; }

        /// <summary>
        /// Položky nákladu
        /// </summary>
        public ICollection<JsonExpenseLine> lines { get; set; }
    }
}
