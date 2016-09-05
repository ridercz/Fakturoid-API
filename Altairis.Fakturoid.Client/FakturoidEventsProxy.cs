using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    /// <summary>
    /// Proxy class for working with events
    /// </summary>
    public class FakturoidEventsProxy : FakturoidEntityProxy {

        internal FakturoidEventsProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets list of all current events.
        /// </summary>
        /// <param name="since">The date since when events are to be selected.</param>
        /// <returns>List of <see cref="JsonEvent"/> instances.</returns>
        /// <remarks>The result may contain duplicate entities, if they are modified between requests for pages. In current version of API, there is no way to solve rhis.</remarks>
        public IEnumerable<JsonEvent> Select(DateTime? since = null) {
            return base.GetAllPagedEntities<JsonEvent>("events.json", new { since = since });
        }

        /// <summary>
        /// Gets asynchronously list of all current events.
        /// </summary>
        /// <param name="since">The date since when events are to be selected.</param>
        /// <returns>List of <see cref="JsonEvent"/> instances.</returns>
        /// <remarks>The result may contain duplicate entities, if they are modified between requests for pages. In current version of API, there is no way to solve rhis.</remarks>
        public async Task<IEnumerable<JsonEvent>> SelectAsync(DateTime? since = null) {
            return await base.GetAllPagedEntitiesAsync<JsonEvent>("events.json", new { since = since });
        }

        /// <summary>
        /// Gets list of current events, paged by 15.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="since">The date since when events are to be selected.</param>
        /// <returns>
        /// List of <see cref="JsonEvent" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
        public IEnumerable<JsonEvent> Select(int page, DateTime? since = null) {
            if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.");

            return base.GetPagedEntities<JsonEvent>("events.json", page, new { since = since });
        }

        /// <summary>
        /// Gets asynchronously list of current events, paged by 15.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="since">The date since when events are to be selected.</param>
        /// <returns>
        /// List of <see cref="JsonEvent" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
        public async Task<IEnumerable<JsonEvent>> SelectAsync(int page, DateTime? since = null) {
            if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.");

            return await base.GetPagedEntitiesAsync<JsonEvent>("events.json", page, new { since = since });
        }

    }
}
