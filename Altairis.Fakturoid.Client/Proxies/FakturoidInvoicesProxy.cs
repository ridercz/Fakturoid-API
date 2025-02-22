using System.Net;
using System.Xml;

namespace Altairis.Fakturoid.Client.Proxies;

#region Enums

/// <summary>
/// Query status condition for listing invoices
/// </summary>
public enum InvoiceStatusCondition {
    /// <summary>
    /// Any status of invoice
    /// </summary>
    Any,
    /// <summary>
    /// Invoice is issued without being paid, sent, overdue or in any other state
    /// </summary>
    Open,
    /// <summary>
    /// Invoice was sent and is not overdue
    /// </summary>
    Sent,
    /// <summary>
    /// Invoice is overdue
    /// </summary>
    Overdue,
    /// <summary>
    /// Invoice is paid
    /// </summary>
    Paid,
    /// <summary>
    /// Invoice is cancelled (only for VAT-payers)
    /// </summary>
    Cancelled,
    /// <summary>
    /// Invoice can no longer be paid and is thus uncollectible
    /// </summary>
    Uncollectible
}

/// <summary>
/// Query invoice type condition for listing invoices.
/// </summary>
public enum InvoiceTypeCondition {
    /// <summary>
    /// Any type of invoice.
    /// </summary>
    Any,
    /// <summary>
    /// Regular invoice.
    /// </summary>
    Regular,
    /// <summary>
    /// Proforma invoice.
    /// </summary>
    Proforma,
    /// <summary>
    /// Correction invoice.
    /// </summary>
    Correction,
    /// <summary>
    /// Tax document invoice.
    /// </summary>
    TaxDocument
}

#endregion

/// <summary>
/// Proxy class for working with invoices.
/// </summary>
public class FakturoidInvoicesProxy : FakturoidEntityProxy {

    internal FakturoidInvoicesProxy(FakturoidContext context) : base(context) { }


    /// <summary>
    /// Selects asynchronously a list of invoices based on the specified conditions.
    /// </summary>
    /// <param name="since">The date from which to start listing invoices.</param>
    /// <param name="until">The date until which to list invoices.</param>
    /// <param name="updatedSince">The date from which to start listing updated invoices.</param>
    /// <param name="updatedUntil">The date until which to list updated invoices.</param>
    /// <param name="subjectId">The ID of the subject (customer) to filter invoices.</param>
    /// <param name="customId">The custom ID to filter invoices.</param>
    /// <param name="number">The invoice number to filter invoices.</param>
    /// <param name="status">The status condition to filter invoices.</param>
    /// <param name="documentType">The document type condition to filter invoices.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="FakturoidInvoice"/> instances.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="subjectId"/> is less than 1.</exception>
    public Task<IEnumerable<FakturoidInvoice>> SelectAsync(DateTimeOffset? since = null,
                                                           DateTimeOffset? until = null,
                                                           DateTimeOffset? updatedSince = null,
                                                           DateTimeOffset? updatedUntil = null,
                                                           int? subjectId = null,
                                                           string customId = null,
                                                           string number = null,
                                                           InvoiceStatusCondition status = InvoiceStatusCondition.Any,
                                                           InvoiceTypeCondition documentType = InvoiceTypeCondition.Any) {

        if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException(nameof(subjectId), "Value must be greater than zero.");

        // Get status string
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
            case InvoiceStatusCondition.Uncollectible:
                statusString = "uncollectible";
                break;
            case InvoiceStatusCondition.Any:
                break;
        }

        // Get document type string
        string documentTypeString = null;
        switch (documentType) {
            case InvoiceTypeCondition.Regular:
                documentTypeString = "regular";
                break;
            case InvoiceTypeCondition.Proforma:
                documentTypeString = "proforma";
                break;
            case InvoiceTypeCondition.Correction:
                documentTypeString = "correction";
                break;
            case InvoiceTypeCondition.TaxDocument:
                documentTypeString = "tax_document";
                break;
            case InvoiceTypeCondition.Any:
                break;
        }

        // Prepare query parameters
        var queryParams = new {
            since,
            until,
            updated_since = updatedSince,
            updated_until = updatedUntil,
            subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
            custom_id = customId,
            number,
            status = statusString,
            document_type = documentTypeString
        };

        // Get entities
        return this.GetAllPagedEntitiesAsync<FakturoidInvoice>("invoices.json", queryParams);
    }

    /// <summary>
    /// Selects asynchronously a paged list of invoices based on the specified conditions.
    /// </summary>
    /// <param name="page">The page number.</param>
    /// <param name="since">The date from which to start listing invoices.</param>
    /// <param name="until">The date until which to list invoices.</param>
    /// <param name="updatedSince">The date from which to start listing updated invoices.</param>
    /// <param name="updatedUntil">The date until which to list updated invoices.</param>
    /// <param name="subjectId">The ID of the subject (customer) to filter invoices.</param>
    /// <param name="customId">The custom ID to filter invoices.</param>
    /// <param name="number">The invoice number to filter invoices.</param>
    /// <param name="status">The status condition to filter invoices.</param>
    /// <param name="documentType">The document type condition to filter invoices.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="FakturoidInvoice"/> instances.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="subjectId"/> or <paramref name="page"/> is less than 1.</exception>
    public Task<IEnumerable<FakturoidInvoice>> SelectAsync(int page,
                                                           DateTimeOffset? since = null,
                                                           DateTimeOffset? until = null,
                                                           DateTimeOffset? updatedSince = null,
                                                           DateTimeOffset? updatedUntil = null,
                                                           int? subjectId = null,
                                                           string customId = null,
                                                           string number = null,
                                                           InvoiceStatusCondition status = InvoiceStatusCondition.Any,
                                                           InvoiceTypeCondition documentType = InvoiceTypeCondition.Any) {
        if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.");
        if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException(nameof(subjectId), "Value must be greater than zero.");

        // Get status string
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
            case InvoiceStatusCondition.Uncollectible:
                statusString = "uncollectible";
                break;
            case InvoiceStatusCondition.Any:
                break;
        }

        // Get document type string
        string documentTypeString = null;
        switch (documentType) {
            case InvoiceTypeCondition.Regular:
                documentTypeString = "regular";
                break;
            case InvoiceTypeCondition.Proforma:
                documentTypeString = "proforma";
                break;
            case InvoiceTypeCondition.Correction:
                documentTypeString = "correction";
                break;
            case InvoiceTypeCondition.TaxDocument:
                documentTypeString = "tax_document";
                break;
            case InvoiceTypeCondition.Any:
                break;
        }

        // Prepare query parameters
        var queryParams = new {
            since,
            until,
            updated_since = updatedSince,
            updated_until = updatedUntil,
            subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
            custom_id = customId,
            number,
            status = statusString,
            document_type = documentTypeString
        };

        // Get entities
        return this.GetPagedEntitiesAsync<FakturoidInvoice>("invoices.json", page, queryParams);
    }

    /// <summary>
    /// Searches asynchronously for invoices based on the specified query.
    /// </summary>
    /// <param name="query">The search query string.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="FakturoidInvoice"/> instances that match the search query.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="query"/> is null or whitespace.</exception>
    public Task<IEnumerable<FakturoidInvoice>> SearchAsync(string query) {
        if (string.IsNullOrWhiteSpace(query)) throw new ArgumentNullException(nameof(query));

        // Get entities
        return this.GetAllPagedEntitiesAsync<FakturoidInvoice>("invoices/search.json", new { query });
    }

    /// <summary>
    /// Searches asynchronously for invoices based on the specified query.
    /// </summary>
    /// <param name="page">The page number.</param>
    /// <param name="query">The search query string.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="FakturoidInvoice"/> instances that match the search query.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="query"/> is null or whitespace.</exception>
    public Task<IEnumerable<FakturoidInvoice>> SearchAsync(int page, string query) {
        if (string.IsNullOrWhiteSpace(query)) throw new ArgumentNullException(nameof(query));

        // Get entities
        return this.GetPagedEntitiesAsync<FakturoidInvoice>("invoices/search.json", page, new { query });
    }

    /// <summary>
    /// Selects asynchronously single invoice with specified ID.
    /// </summary>
    /// <param name="id">The invoice id.</param>
    /// <returns>
    /// Instance of <see cref="FakturoidInvoice" /> class.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
    public async Task<FakturoidInvoice> SelectSingleAsync(int id) => id < 1 ? throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.") : await this.GetSingleEntityAsync<FakturoidInvoice>($"invoices/{id}.json");

    /// <summary>
    /// Downloads the PDF representation of the specified invoice asynchronously.
    /// </summary>
    /// <param name="id">The ID of the invoice to download.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the PDF file as a byte array or <c>null</c>, if file is not ready yet. If file is not ready, try again in a second or two.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="id"/> is less than 1.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the response is not a PDF file.</exception>
    public async Task<byte[]> DownloadPdfAsync(int id) {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.GetAsync($"invoices/{id}/download.pdf");
        if (r.StatusCode == HttpStatusCode.NoContent) return null; // Return null if no content - client should try again later
        r.EnsureFakturoidSuccess();
        return r.Content.Headers.ContentType.MediaType != "application/pdf"
            ? throw new InvalidOperationException("The response is not a PDF file.")
            : await r.Content.ReadAsByteArrayAsync();
    }

    /// <summary>
    /// Downloads the attachment for the specified invoice asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice.</param>
    /// <param name="attachmentId">The ID of the attachment.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the attachment file as a byte array.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="invoiceId"/> or <paramref name="attachmentId"/> is less than 1.
    /// </exception>
    /// <exception cref="FakturoidException">Thrown when the response status is NoContent.</exception>
    public async Task<byte[]> DownloadAttachment(int invoiceId, int attachmentId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");
        if (attachmentId < 1) throw new ArgumentOutOfRangeException(nameof(attachmentId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.GetAsync($"invoices/{invoiceId}/attachments/{attachmentId}/download");
        if (r.StatusCode == HttpStatusCode.NoContent) throw new FakturoidException(r);
        r.EnsureFakturoidSuccess();
        return await r.Content.ReadAsByteArrayAsync();
    }

    /// <summary>
    /// Marks the specified invoice as sent asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to mark as sent.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="invoiceId"/> is less than 1.</exception>
    public async Task MarkAsSent(int invoiceId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"invoices/{invoiceId}/fire.json?event=mark_as_sent", new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Cancels the specified invoice asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to cancel.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="invoiceId"/> is less than 1.</exception>
    public async Task Cancel(int invoiceId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"invoices/{invoiceId}/fire.json?event=cancel", new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Reverts the cancellation of the specified invoice asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to undo cancellation.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="invoiceId"/> is less than 1.</exception>
    public async Task UndoCancelAsync(int invoiceId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"invoices/{invoiceId}/fire.json?event=undo_cancel", new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Locks the specified invoice asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to lock.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="invoiceId"/> is less than 1.</exception>
    public async Task LockAsync(int invoiceId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"invoices/{invoiceId}/fire.json?event=lock", new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Unlocks the specified invoice asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to unlock.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="invoiceId"/> is less than 1.</exception>
    public async Task UnlockAsync(int invoiceId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"invoices/{invoiceId}/fire.json?event=unlock", new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Marks the specified invoice as uncollectible asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to mark as uncollectible.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="invoiceId"/> is less than 1.</exception>
    public async Task MarkAsUncollectibleAsync(int invoiceId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"invoices/{invoiceId}/fire.json?event=mark_as_uncollectible", new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Reverts the uncollectible status of the specified invoice asynchronously.
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to undo uncollectible status.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="invoiceId"/> is less than 1.</exception>
    public async Task UndoUncollectibleAsync(int invoiceId) {
        if (invoiceId < 1) throw new ArgumentOutOfRangeException(nameof(invoiceId), "Value must be greater than zero.");

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync($"invoices/{invoiceId}/fire.json?event=undo_uncollectible", new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Deletes asynchronously invoice with specified id.
    /// </summary>
    /// <param name="id">The contact id.</param>
    /// <exception cref="ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
    public Task DeleteAsync(int id) {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

        return this.DeleteSingleEntityAsync(string.Format("invoices/{0}.json", id));
    }

    /// <summary>
    /// Creates asynchronously the specified new invoice.
    /// </summary>
    /// <param name="entity">The new invoice.</param>
    /// <returns>ID of newly created invoice.</returns>
    /// <exception cref="ArgumentNullException">entity</exception>
    public async Task<int> CreateAsync(FakturoidInvoice entity) => entity == null ? throw new ArgumentNullException(nameof(entity)) : await this.CreateEntityAsync("invoices.json", entity);

    /// <summary>
    /// Updates asynchronously the specified invoice.
    /// </summary>
    /// <param name="entity">The invoice to update.</param>
    /// <returns>Instance of <see cref="FakturoidInvoice"/> class with modified entity.</returns>
    /// <exception cref="ArgumentNullException">entity</exception>
    public async Task<FakturoidInvoice> UpdateAsync(FakturoidInvoice entity) => entity == null
            ? throw new ArgumentNullException(nameof(entity))
            : await this.UpdateSingleEntityAsync(string.Format("invoices/{0}.json", entity.Id), entity);

}
