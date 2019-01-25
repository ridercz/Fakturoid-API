using System;
using System.Collections.Generic;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// User account information, as received from JSON API.
    /// Single invoice
    /// </summary>
    public class JsonAttachment {
        /// <summary>
        /// Název souboru
        /// </summary>
        public string file_name { get; set; }

        /// <summary>
        /// MIME type souboru
        /// </summary>
        public string content_type { get; set; }

        /// <summary>
        /// URL pro download přílohy přes API
        /// </summary>
        public string download_url { get; set; }
    }
}
