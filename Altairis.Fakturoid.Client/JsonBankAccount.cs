namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// Bank account information, as received from JSON API.
    /// </summary>
    public class JsonBankAccount {

        /// <summary>
        /// Identifikátor bankovního účtu
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Název účtu
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Měna účtu
        /// </summary>
        public string currency { get; set; }


        /// <summary>
        /// Číslo účtu
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Číslo účtu ve formátu IBAN
        /// </summary>
        public string iban { get; set; }

        /// <summary>
        /// BIC pro SWIFT platby
        /// </summary>
        public string swift_bic { get; set; }

        /// <summary>
        /// Povoleno párování plateb
        /// </summary>
        public bool pairing { get; set; }

        /// <summary>
        /// Haléřové vyrovnání pro párování plateb
        /// </summary>
        public bool payment_adjustment { get; set; }

    }
}
