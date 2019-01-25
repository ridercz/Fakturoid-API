using System;
using System.Collections.Generic;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// User account information, as received from JSON API.
    /// Single invoice
    /// </summary>
    public class JsonInvoice {

        /// <summary>
        /// Identifikátor faktury
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Příznak proformy
        /// </summary>
        public bool proforma { get; set; }

        /// <summary>
        /// Přiznak zda je proforma na plnou částku
        /// </summary>
        public bool? partial_proforma { get; set; }

        /// <summary>
        /// Číslo faktury (např.: 2011-0001, musí odpovídat formátu čísla v nastavení účtu)
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Variabilní symbol
        /// </summary>
        public string variable_symbol { get; set; }

        /// <summary>
        /// Vaše obchodní jméno
        /// </summary>
        public string your_name { get; set; }

        /// <summary>
        /// Vaše ulice
        /// </summary>
        public string your_street { get; set; }

        /// <summary>
        /// Vaše ulice - druhý řádek
        /// </summary>
        public string your_street2 { get; set; }

        /// <summary>
        /// Vaše město
        /// </summary>
        public string your_city { get; set; }

        /// <summary>
        /// Vaše PSČ
        /// </summary>
        public string your_zip { get; set; }

        /// <summary>
        /// Vaše země
        /// </summary>
        public string your_country { get; set; }

        /// <summary>
        /// Vaše IČ
        /// </summary>
        public string your_registration_no { get; set; }

        /// <summary>
        /// Vaše DIČ
        /// </summary>
        public string your_vat_no { get; set; }

        /// <summary>
        /// Obchodní jméno příjemce
        /// </summary>
        public string client_name { get; set; }

        /// <summary>
        /// Ulice příjemce
        /// </summary>
        public string client_street { get; set; }

        /// <summary>
        /// Ulice příjemce - druhý řádek
        /// </summary>
        public string client_street2 { get; set; }

        /// <summary>
        /// Místo příjemce
        /// </summary>
        public string client_city { get; set; }

        /// <summary>
        /// PSČ příjemce
        /// </summary>
        public string client_zip { get; set; }

        /// <summary>
        /// Země příjemce
        /// </summary>
        public string client_country { get; set; }

        /// <summary>
        /// IČ příjemce
        /// </summary>
        public string client_registration_no { get; set; }

        /// <summary>
        /// DIČ příjemce
        /// </summary>
        public string client_vat_no { get; set; }

        /// <summary>
        /// ID kontaktu příjemce
        /// </summary>
        public int subject_id { get; set; }

        /// <summary>
        /// ID šablony ze které byla faktura vystavena (nepovinné)
        /// </summary>
        public int? generator_id { get; set; }

        /// <summary>
        /// ID proformy/faktury (nepovinné)
        /// </summary>
        public int? related_id { get; set; }

        /// <summary>
        /// Opravný daňový doklad (false = faktura/proforma, nepovinné)
        /// </summary>
        public bool? correction { get; set; }

        /// <summary>
        /// ID opravovaného dokladu, zdává se pouze pokud je correction=true, na opravovaný doklad 
        /// se doplní automaticky doplní ID opravného daňového dokladu (nepovinné)
        /// </summary>
        public int? correction_id { get; set; }

        /// <summary>
        /// Token pro public akci
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// Stav faktury - open/sent/overdue/paid
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Číslo objednávky (nepovinné)
        /// </summary>
        public string order_number { get; set; }

        /// <summary>
        /// Datum vystavení (zobrazeno na faktuře)
        /// </summary>
        public DateTime? issued_on { get; set; }

        /// <summary>
        /// Datum zdanitelného plnění (nepovinné - doplní se dnes)
        /// </summary>
        public DateTime? taxable_fulfillment_due { get; set; }

        /// <summary>
        /// Počet dní, než bude po splatnosti (nepovinné - doplní se z účtu)
        /// </summary>
        public int? due { get; set; }

        /// <summary>
        /// Datum splatnosti (doplní se podle due)
        /// </summary>
        public DateTime? due_on { get; set; }

        /// <summary>
        /// Datum a čas odeslání faktury
        /// </summary>
        public DateTime? sent_at { get; set; }

        /// <summary>
        /// Datum a čas zaplacení faktury
        /// </summary>
        public DateTime? paid_at { get; set; }

        /// <summary>
        /// Datum a čas odeslání upomínky
        /// </summary>
        public DateTime? reminder_sent_at { get; set; }

        /// <summary>
        /// Datum a čas odsouhlasení faktury klientem
        /// </summary>
        public DateTime? accepted_at { get; set; }

        /// <summary>
        /// Datum stornování faktury (pouze pro neplátce DPH)
        /// </summary>
        public DateTime? cancelled_at { get; set; }

        /// <summary>
        /// Text před položkami faktury (nepovinné - doplní se z účtu)
        /// </summary>
        public string note { get; set; }

        /// <summary>
        /// Patička faktury (nepovinné - doplní se z účtu)
        /// </summary>
        public string footer_note { get; set; }

        /// <summary>
        /// Soukromá poznámka (nepovinné)
        /// </summary>
        public string private_note { get; set; }

        /// <summary>
        /// Seznam tagů faktury
        /// </summary>
        public ICollection<string> tags { get; set; }

        /// <summary>
        /// ID bankovního účtu (nepovinné - použije se výchozí bankovní účet)
        /// </summary>
        public int? bank_account_id { get; set; }

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
        /// Tlačítko pro platbu PayPalem - true/false (nepovinné)
        /// </summary>
        public bool? paypal { get; set; }

        /// <summary>
        /// Jazyk faktury
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// Přenesená daňová povinnost
        /// </summary>
        public bool transferred_tax_liability { get; set; }

        /// <summary>
        /// Kód plnění pro souhrnná hlášení (pouze pro zahraniční faktury do EU, nepovinné)
        /// </summary>
        public int? supply_code { get; set; }

        /// <summary>
        /// Příznak, pokud je faktura v režimu MOSS (nepovinné)
        /// </summary>
        public bool? eu_electronic_service { get; set; }

        /// <summary>
        /// Způsob zadávání cen do řádků (hodnoty: null, without_vat, with_vat, default: dle účtu).
        /// Je ignorováno, pokud účet je neplátce DPH nebo je zapnuta přenesená daňová povinnost.
        /// </summary>
        public string vat_price_mode { get; set; }

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
        /// Částka k zaplacení
        /// </summary>
        public decimal remaining_amount { get; set; }

        /// <summary>
        /// Částka k zaplacení v měně účtu 
        /// </summary>
        public decimal remaining_native_amount { get; set; }

        /// <summary>
        /// Příloha
        /// </summary>
        public JsonAttachment attachment { get; set; }

        /// <summary>
        /// Adresa faktury v GUI
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// Veřejná HTML adresa faktury
        /// </summary>
        public string public_html_url { get; set; }

        /// <summary>
        /// API adresa faktury
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// API adresa pro stažení faktury v PDF
        /// </summary>
        public string pdf_url { get; set; }

        /// <summary>
        /// API adresa kontaktu příjemce
        /// </summary>
        public string subject_url { get; set; }

        /// <summary>
        /// Datum poslední aktualizace faktury
        /// </summary>
        public DateTime? updated_at { get; set; }

        /// <summary>
        /// Položky faktury
        /// </summary>
        public ICollection<JsonInvoiceLine> lines { get; set; }
    }
}