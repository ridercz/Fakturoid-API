using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    public class FakturoidInvoicesProxy : FakturoidEntityProxy {

        internal FakturoidInvoicesProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Selects single invoice with specified ID.
        /// </summary>
        /// <param name="id">The invoice id.</param>
        /// <returns>
        /// Instance of <see cref="JsonInvoice" /> class.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public JsonInvoice SelectSingle(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException("id", "Value must be greater than zero.");

            return base.GetSingleEntity<JsonInvoice>(string.Format("invoices/{0}.json", id));
        }
        
        /// <summary>
        /// Gets list of all invoices.
        /// </summary>
        /// <param name="type">The invoice type.</param>
        /// <param name="status">The invoice status.</param>
        /// <param name="subjectId">The customer subject id.</param>
        /// <param name="since">The date since when the invoice was created.</param>
        /// <param name="number">The invoice display number.</param>
        /// <returns>
        /// List of <see cref="JsonInvoice" /> instances.
        /// </returns>
        public IEnumerable<JsonInvoice> Select(InvoiceType type, InvoiceStatus status, int? subjectId = null, DateTime? since = null, string number = null) {
            var uri = type.ToString();
            var queryParams = new {
                status = status.ToString(),
                subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
                since = since,
                number = number
            };

            return base.GetAllPagedEntities<JsonInvoice>(uri, queryParams);
        }

        /// <summary>
        /// Gets list of invoiced, paged by 10.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="type">The invoice type.</param>
        /// <param name="status">The invoice status.</param>
        /// <param name="subjectId">The customer subject id.</param>
        /// <param name="since">The date since when the invoice was created.</param>
        /// <param name="number">The invoice display number.</param>
        /// <returns>
        /// List of <see cref="JsonInvoice" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
        public IEnumerable<JsonInvoice> Select(int page, InvoiceType type, InvoiceStatus status, int? subjectId = null, DateTime? since = null, string number = null) {
            if (page < 1) throw new ArgumentOutOfRangeException("page", "Page must be greater than zero.");
            var uri = type.ToString();
            var queryParams = new {
                status = status.ToString(),
                subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
                since = since,
                number = number
            };

            return base.GetPagedEntities<JsonInvoice>("invoices.json", page);
        }

        /// <summary>
        /// Deletes invoice with specified id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public void Delete(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException("id", "Value must be greater than zero.");

            base.DeleteSingleEntity(string.Format("invoices/{0}.json", id));
        }

        /// <summary>
        /// Creates the specified new invoice.
        /// </summary>
        /// <param name="entity">The new invoice.</param>
        /// <returns>ID of newly created invoice.</returns>
        /// <exception cref="System.ArgumentNullException">entity</exception>
        public int Create(JsonInvoice entity) {
            if (entity == null) throw new ArgumentNullException("entity");

            return base.CreateEntity("invoices.json", entity);
        }

        /// <summary>
        /// Updates the specified invoice.
        /// </summary>
        /// <param name="entity">The invoice to update.</param>
        /// <returns>Instance of <see cref="JsonInvoice"/> class with modified entity.</returns>
        /// <exception cref="System.ArgumentNullException">entity</exception>
        public JsonInvoice Update(JsonInvoice entity) {
            if (entity == null) throw new ArgumentNullException("entity");

            return base.UpdateSingleEntity(string.Format("invoices/{0}.json", entity.id), entity);
        }

        /// <summary>
        /// Fires action over single invoice.
        /// </summary>
        /// <param name="id">The invoice id.</param>
        /// <param name="action">The action to be fired.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        /// <exception cref="System.ArgumentNullException">action</exception>
        public void FireAction(int id, InvoiceAction action) {
            if (id < 1) throw new ArgumentOutOfRangeException("id", "Value must be greater than zero.");
            if (action == null) throw new ArgumentNullException("action");

            var c = this.Context.GetHttpClient();
            var r = c.PostAsync(string.Format("invoices/{0}/fire.json?event={1}", id, action), new StringContent(string.Empty)).Result;
            r.EnsureFakturoidSuccess();
        }

    }
}
