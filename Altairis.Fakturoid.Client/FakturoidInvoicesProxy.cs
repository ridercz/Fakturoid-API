using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Altairis.Fakturoid.Client {

    #region Enums

    public enum InvoiceStatusCondition {
        Any,
        Open,
        Sent,
        Overdue,
        Paid,
        Cancelled
    }

    public enum InvoiceTypeCondition {
        Any,
        Proforma,
        Regular
    }

    /// <summary>
    /// Invoice payment status
    /// </summary>
    public enum InvoicePaymentStatus {
        Unpaid,
        Paid,
        ProformaPaid,
        PartialProformaPaid
    }

    /// <summary>
    /// Type of e-mail message to be sent.
    /// </summary>
    public enum InvoiceMessageType {
        /// <summary>
        /// Do not actually send anything, just mark invoice as sent
        /// </summary>
        NoMessage,

        /// <summary>
        /// Predefined message containing link to invoice
        /// </summary>
        InvoiceMessage,

        /// <summary>
        /// Predefined message containing payment reminder
        /// </summary>
        PaymentReminderMessage,
    }

    #endregion

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
        /// <exception cref="System.ArgumentOutOfRangeException">subjectId;Value must be greater than zero.</exception>
        public IEnumerable<JsonInvoice> Select(InvoiceTypeCondition type = InvoiceTypeCondition.Any, InvoiceStatusCondition status = InvoiceStatusCondition.Any, int? subjectId = null, DateTime? since = null, string number = null) {
            if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException("subjectId", "Value must be greater than zero.");

            // Get URI based on invoice type
            string uri;
            switch (type) {
                case InvoiceTypeCondition.Proforma:
                    uri = "invoices/proforma.json";
                    break;
                case InvoiceTypeCondition.Regular:
                    uri = "invoices/regular.json";
                    break;
                default:
                    uri = "invoices.json";
                    break;
            }

            // Get status string based
            string statusString = null;
            switch (status) {
                case InvoiceStatusCondition.Open:
                    statusString = "open";
                    break;
                case InvoiceStatusCondition.Sent:
                    statusString = "sent";
                    break;
                case InvoiceStatusCondition.Overdue:
                    statusString = "overdue";
                    break;
                case InvoiceStatusCondition.Paid:
                    statusString = "paid";
                    break;
                case InvoiceStatusCondition.Cancelled:
                    statusString = "cancelled";
                    break;
            }

            // Prepare query parameters
            var queryParams = new {
                status = statusString,
                subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
                since = since,
                number = number
            };

            // Get entities
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
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// page;Value must be greater than zero.
        /// or
        /// subjectId;Value must be greater than zero.
        /// </exception>
        public IEnumerable<JsonInvoice> Select(int page, InvoiceTypeCondition type = InvoiceTypeCondition.Any, InvoiceStatusCondition status = InvoiceStatusCondition.Any, int? subjectId = null, DateTime? since = null, string number = null) {
            if (page < 1) throw new ArgumentOutOfRangeException("page", "Value must be greater than zero.");
            if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException("subjectId", "Value must be greater than zero.");

            // Get URI based on invoice type
            string uri;
            switch (type) {
                case InvoiceTypeCondition.Proforma:
                    uri = "invoices/proforma.json";
                    break;
                case InvoiceTypeCondition.Regular:
                    uri = "invoices/regular.json";
                    break;
                default:
                    uri = "invoices.json";
                    break;
            }

            // Get status string based
            string statusString = null;
            switch (status) {
                case InvoiceStatusCondition.Open:
                    statusString = "open";
                    break;
                case InvoiceStatusCondition.Sent:
                    statusString = "sent";
                    break;
                case InvoiceStatusCondition.Overdue:
                    statusString = "overdue";
                    break;
                case InvoiceStatusCondition.Paid:
                    statusString = "paid";
                    break;
                case InvoiceStatusCondition.Cancelled:
                    statusString = "cancelled";
                    break;
            }

            // Prepare query parameters
            var queryParams = new {
                status = statusString,
                subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
                since = since,
                number = number
            };

            // Get entities
            return base.GetPagedEntities<JsonInvoice>(uri, page);
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
        /// Sends e-mail message for the specified invoice.
        /// </summary>
        /// <param name="id">The invoice id.</param>
        /// <param name="messageType">Type of the message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public void SendMessage(int id, InvoiceMessageType messageType) {
            if (id < 1) throw new ArgumentOutOfRangeException("id", "Value must be greater than zero.");

            // Get name of event
            string eventName;
            switch (messageType) {
                case InvoiceMessageType.InvoiceMessage:
                    eventName = "deliver";
                    break;
                case InvoiceMessageType.PaymentReminderMessage:
                    eventName = "deliver_reminder";
                    break;
                default:
                    eventName = "mark_as_sent";
                    break;
            }

            var c = this.Context.GetHttpClient();
            var r = c.PostAsync(string.Format("invoices/{0}/fire.json?event={1}", id, eventName), new StringContent(string.Empty)).Result;
            r.EnsureFakturoidSuccess();
        }

        /// <summary>
        /// Sets the invoice payment status.
        /// </summary>
        /// <param name="id">The invoice id.</param>
        /// <param name="status">The new payment status.</param>
        public void SetPaymentStatus(int id, InvoicePaymentStatus status) {
            this.SetPaymentStatus(id, status, DateTime.Now);
        }

        /// <summary>
        /// Sets the invoice payment status.
        /// </summary>
        /// <param name="id">The invoice id.</param>
        /// <param name="status">The new payment status.</param>
        /// <param name="effectiveDate">The date when payment was performed.</param>
        public void SetPaymentStatus(int id, InvoicePaymentStatus status, DateTime effectiveDate) {
            if (id < 1) throw new ArgumentOutOfRangeException("id", "Value must be greater than zero.");

            // Get url
            string urlFormat;
            switch (status) {
                case InvoicePaymentStatus.Paid:
                    urlFormat = "invoices/{0}/fire.json?event=pay&paid_at=" + Uri.EscapeDataString(XmlConvert.ToString(effectiveDate, XmlDateTimeSerializationMode.RoundtripKind));
                    break;
                case InvoicePaymentStatus.ProformaPaid:
                    urlFormat = "invoices/{0}/fire.json?event=pay_proforma&paid_at=" + Uri.EscapeDataString(XmlConvert.ToString(effectiveDate, XmlDateTimeSerializationMode.RoundtripKind));
                    break;
                case InvoicePaymentStatus.PartialProformaPaid:
                    urlFormat = "invoices/{0}/fire.json?event=pay_partial_proforma&paid_at=" + Uri.EscapeDataString(XmlConvert.ToString(effectiveDate, XmlDateTimeSerializationMode.RoundtripKind));
                    break;
                default:
                    urlFormat = "invoices/{0}/fire.json?event=remove_payment";
                    break;
            }

            var c = this.Context.GetHttpClient();
            var r = c.PostAsync(string.Format(urlFormat, id), new StringContent(string.Empty)).Result;
            r.EnsureFakturoidSuccess();
        }

    }
}
