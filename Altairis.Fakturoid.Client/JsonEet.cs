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
        public long id { get; set; }
        /// <summary>
        /// DIČ účtu ve Fakturoidu
        /// </summary>
        public string vat_no { get; set; }
        /// <summary>
        /// Pořadové číslo dokladu
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// ID provozovny
        /// </summary>
        public long store { get; set; }
        /// <summary>
        /// Číslo pokladny
        /// </summary>
        public string cash_register { get; set; }
        /// <summary>
        /// Datum a čas tržby
        /// </summary>
        public DateTimeOffset paid_at { get; set; }
        /// <summary>
        /// Základ nepodléhající DPH
        /// </summary>
        public object vat_base0 { get; set; }
        /// <summary>
        /// DPH pro základní sazbu
        /// </summary>
        public string vat1 { get; set; }
        /// <summary>
        /// Základ pro základní sazbu DPH (21 %)
        /// </summary>

        public string vat_base1 { get; set; }
        /// <summary>
        /// DPH pro 1. sníženou sazbu DPH
        /// </summary>
        public object vat2 { get; set; }
        /// <summary>
        /// Základ pro 1. sníženou sazbu DPH (15 %)
        /// </summary>
        public object vat_base2 { get; set; }

        /// <summary>
        /// DPH pro 2. sníženou sazbu DPH
        /// </summary>
        public object vat3 { get; set; }
        /// <summary>
        /// Základ pro 2. sníženou sazbu DPH (10 %)
        /// </summary>

        public object vat_base3 { get; set; }
        /// <summary>
        /// Celková částka tržby
        /// </summary>
        public string total { get; set; }
        /// <summary>
        /// FIK kód
        /// </summary>
        public string fik { get; set; }
        /// <summary>
        /// BKP kód
        /// </summary>
        public string bkp { get; set; }
        /// <summary>
        /// PKP kód
        /// </summary>
        public string pkp { get; set; }
        /// <summary>
        /// Stav zaevidování:
        ///    waiting - čeká se na první odpověď serveru EET
        ///    pkp - na faktuře se zobrazí PKP kód
        ///    fik - na faktuře se zobrazí FIK kód
        /// </summary>

        public string status { get; set; }
        /// <summary>
        /// Datum a čas získání FIK ze serverů EET
        /// </summary>
        public DateTimeOffset fik_received_at { get; set; }
        /// <summary>
        /// Tržba je zaevidována mimo Fakturoid a potřebné kódy jsou zadány přes API
        /// </summary>
        public bool external { get; set; }
        /// <summary>
        /// Počet pokusů o zaevidování tržby
        /// </summary>
        public long attempts { get; set; }
        /// <summary>
        /// Datum a čas posledního pokusu o zaevidování tržby
        /// </summary>
        public DateTimeOffset last_attempt_at { get; set; }
        /// <summary>
        /// UUID posledního pokusu o zaevidování tržby
        /// </summary>
        public Guid last_uuid { get; set; }
        /// <summary>
        /// Evidováno v EET Playground prostředí
        /// </summary>
        public bool playground { get; set; }
        /// <summary>
        /// ID faktury, ke které EET záznam patří
        /// </summary>
        public long invoice_id { get; set; }
        /// <summary>
        /// Datum a čas vytvoření záznamu
        /// </summary>
        public DateTimeOffset created_at { get; set; }
        /// <summary>
        /// Datum a čas poslední úpravy záznamu
        /// </summary>
        public DateTimeOffset updated_at { get; set; }
    }
}
