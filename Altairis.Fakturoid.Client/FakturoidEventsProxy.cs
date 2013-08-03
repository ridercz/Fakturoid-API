using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net.Http;

namespace Altairis.Fakturoid.Client {
    public class FakturoidEventsProxy : FakturoidEntityProxy {

        internal FakturoidEventsProxy(FakturoidContext context) : base(context) { }
        
        /// <summary>
        /// Gets list of all current events.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="since">The date since when events are to be selected.</param>
        /// <returns>List of <see cref="JsonEvent"/> instances.</returns>
        public IEnumerable<JsonEvent> Select(DateTime? since = null) {
            return base.GetEntities<JsonEvent>("events.json", new { since = since });
        }

        /// <summary>
        /// Gets list of current events, paged by 15.
        /// </summary>
        /// <param name="since">The date since when events are to be selected.</param>
        /// <returns>List of <see cref="JsonEvent"/> instances.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
        public IEnumerable<JsonEvent> Select(int page, DateTime? since = null) {
            if (page < 1) throw new ArgumentOutOfRangeException("page", "Page must be greater than zero.");

            return base.GetEntities<JsonEvent>("events.json", page, new { since = since });
        }

    }
}
