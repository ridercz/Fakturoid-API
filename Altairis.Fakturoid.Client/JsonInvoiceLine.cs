namespace Altairis.Fakturoid.Client {

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

        /// <summary>
        /// Cena je uvedena včetně DPH?
        /// </summary>
        public bool with_vat { get; set; }
    }
}