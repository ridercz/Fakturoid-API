namespace Altairis.Fakturoid.Client {

    public class JsonInvoiceLine {

        /// <summary>
        /// Název položky
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Množství
        /// </summary>
        public float quantity { get; set; }

        /// <summary>
        /// Měrná jednotka
        /// </summary>
        public string unit_name { get; set; }

        /// <summary>
        /// Jednotková cena
        /// </summary>
        public float unit_price { get; set; }

        /// <summary>
        /// Sazba DPH
        /// </summary>
        public float vat_rate { get; set; }

        /// <summary>
        /// Cena je uvedena včetně DPH?
        /// </summary>
        public bool with_vat { get; set; }
    }
}