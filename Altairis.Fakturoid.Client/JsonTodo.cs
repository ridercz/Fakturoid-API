using System;

namespace Altairis.Fakturoid.Client {

    public class JsonTodo {


        /// <summary>
        /// Typ události - initial_todo, initial_fb, already_paid, unpaired_payment, email_bounced
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Datum a čas vytvoření události
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// Datum a čas odškrtnutí události
        /// </summary>
        public DateTime? completed_at { get; set; }

        /// <summary>
        /// ID faktury
        /// </summary>
        public int? invoice_id { get; set; }

        /// <summary>
        /// ID kontaktu
        /// </summary>
        public int? subject_id { get; set; }

        /// <summary>
        /// Text události
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// API adresa faktury
        /// </summary>
        public string invoice_url { get; set; }

        /// <summary>
        /// API adresa kontaktu
        /// </summary>
        public string subject_url { get; set; }
    }
}