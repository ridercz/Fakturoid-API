using System;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// Event, as received from JSON API.
    /// </summary>
    public class JsonEvent {

        /// <summary>
        /// Typ události - generated, sent, accepted, sent_reminder, overdue, paid, paid_bank, payment_removed, unpaired_payment
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Datum a čas vytvoření události
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// ID faktury (nepovinné)
        /// </summary>
        public int? invoice_id { get; set; }

        /// <summary>
        /// ID kontaktu (nepovinné)
        /// </summary>
        public int? subject_id { get; set; }

        /// <summary>
        /// Text události
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// API adresa faktury (nepovinné)
        /// </summary>
        public string invoice_url { get; set; }

        /// <summary>
        /// API adresa kontaktu (nepovinné)
        /// </summary>
        public string subject_url { get; set; }
    }
}