namespace Altairis.Fakturoid.Client
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// EET Information, as recieved from API
    /// </summary>
    public partial class JsonEet
    {
        /// <summary>
        /// ID záznamu
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// DIČ účtu ve Fakturoidu
        /// </summary>
        [JsonProperty("vat_no")]
        public string VatNo { get; set; }
        /// <summary>
        /// Pořadové číslo dokladu
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }
        /// <summary>
        /// ID provozovny
        /// </summary>
        [JsonProperty("store")]
        public long Store { get; set; }
        /// <summary>
        /// Číslo pokladny
        /// </summary>
        [JsonProperty("cash_register")]
        public string CashRegister { get; set; }
        /// <summary>
        /// Datum a čas tržby
        /// </summary>
        [JsonProperty("paid_at")]
        public DateTimeOffset PaidAt { get; set; }
        /// <summary>
        /// Základ nepodléhající DPH
        /// </summary>
        [JsonProperty("vat_base0")]
        public object VatBase0 { get; set; }
        /// <summary>
        /// DPH pro základní sazbu
        /// </summary>
        [JsonProperty("vat1")]
        public string Vat1 { get; set; }
        /// <summary>
        /// Základ pro základní sazbu DPH (21 %)
        /// </summary>

        [JsonProperty("vat_base1")]
        public string VatBase1 { get; set; }
        /// <summary>
        /// DPH pro 1. sníženou sazbu DPH
        /// </summary>
        [JsonProperty("vat2")]
        public object Vat2 { get; set; }
        /// <summary>
        /// Základ pro 1. sníženou sazbu DPH (15 %)
        /// </summary>
        [JsonProperty("vat_base2")]
        public object VatBase2 { get; set; }

        /// <summary>
        /// DPH pro 2. sníženou sazbu DPH
        /// </summary>
        [JsonProperty("vat3")]
        public object Vat3 { get; set; }
        /// <summary>
        /// Základ pro 2. sníženou sazbu DPH (10 %)
        /// </summary>

        [JsonProperty("vat_base3")]
        public object VatBase3 { get; set; }
        /// <summary>
        /// Celková částka tržby
        /// </summary>
        [JsonProperty("total")]
        public string Total { get; set; }
        /// <summary>
        /// FIK kód
        /// </summary>
        [JsonProperty("fik")]
        public string Fik { get; set; }
        /// <summary>
        /// BKP kód
        /// </summary>
        [JsonProperty("bkp")]
        public string Bkp { get; set; }
        /// <summary>
        /// PKP kód
        /// </summary>
        [JsonProperty("pkp")]
        public string Pkp { get; set; }
        /// <summary>
        /// Stav zaevidování:
        ///    waiting - čeká se na první odpověď serveru EET
        ///    pkp - na faktuře se zobrazí PKP kód
        ///    fik - na faktuře se zobrazí FIK kód
        /// </summary>

        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// Datum a čas získání FIK ze serverů EET
        /// </summary>

        [JsonProperty("fik_received_at")]
        public DateTimeOffset FikReceivedAt { get; set; }
        /// <summary>
        /// Tržba je zaevidována mimo Fakturoid a potřebné kódy jsou zadány přes API
        /// </summary>
        [JsonProperty("external")]
        public bool External { get; set; }
        /// <summary>
        /// Počet pokusů o zaevidování tržby
        /// </summary>
        [JsonProperty("attempts")]
        public long Attempts { get; set; }
        /// <summary>
        /// Datum a čas posledního pokusu o zaevidování tržby
        /// </summary>
        [JsonProperty("last_attempt_at")]
        public DateTimeOffset LastAttemptAt { get; set; }
        /// <summary>
        /// UUID posledního pokusu o zaevidování tržby
        /// </summary>
        [JsonProperty("last_uuid")]
        public Guid LastUuid { get; set; }
        /// <summary>
        /// Evidováno v EET Playground prostředí
        /// </summary>
        [JsonProperty("playground")]
        public bool Playground { get; set; }
        /// <summary>
        /// ID faktury, ke které EET záznam patří
        /// </summary>
        [JsonProperty("invoice_id")]
        public long InvoiceId { get; set; }
        /// <summary>
        /// Datum a čas vytvoření záznamu
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        /// <summary>
        /// Datum a čas poslední úpravy záznamu
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
