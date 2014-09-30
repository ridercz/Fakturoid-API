namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// Represents single line of invoice, as received from JSON API.
    /// </summary>
    public class JsonInvoiceLine {

        /// <summary>
        /// Název položky
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Množství
        /// </summary>
        public decimal quantity { get; set; }

        /// <summary>
        /// Měrná jednotka
        /// </summary>
        public string unit_name { get; set; }

        /// <summary>
        /// Jednotková cena
        /// </summary>
        public decimal unit_price { get; set; }

        /// <summary>
        /// Sazba DPH
        /// </summary>
        public decimal vat_rate { get; set; }

    }
}