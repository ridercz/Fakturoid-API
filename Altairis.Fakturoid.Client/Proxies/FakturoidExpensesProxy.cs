using System.Xml;

namespace Altairis.Fakturoid.Client.Proxies;

#region Enums

/// <summary>
/// Query status condition for listing expenses
/// </summary>
public enum ExpenseStatusCondition {
    /// <summary>
    /// Any
    /// </summary>
    Any,

    /// <summary>
    /// Náklad není zaplacen, odeslán ani po splatnosti.
    /// </summary>
    Open,

    /// <summary>
    /// Náklad je po splatnosti.
    /// </summary>
    Overdue,

    /// <summary>
    /// Náklad je zaplacen.
    /// </summary>
    Paid,
}

/// <summary>
/// Expense payment status
/// </summary>
public enum ExpensePaymentStatus {
    /// <summary>
    /// Reset payment status to unpaid.
    /// </summary>
    Unpaid,

    /// <summary>
    /// Set status of regular expense to paid.
    /// </summary>
    Paid,
}
#endregion

/// <summary>
/// Proxy class for working with invoices.
/// </summary>
public class FakturoidExpensesProxy : FakturoidEntityProxy {
    private const string EntityPath = "expenses/{0}.json";
    private const string CollectionPath = "expenses.json";

    internal FakturoidExpensesProxy(FakturoidContext context) : base(context) { }

    /// <summary>
    /// Selects asynchronously single expense with specified ID.
    /// </summary>
    /// <param name="id">The expense id.</param>
    /// <returns>
    /// Instance of <see cref="FakturoidExpense" /> class.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
    public async Task<FakturoidExpense> SelectSingleAsync(int id) => id < 1
            ? throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.")
            : await GetSingleEntityAsync<FakturoidExpense>(string.Format(EntityPath, id));

    /// <summary>
    /// Gets asynchronously list of all invoices.
    /// </summary>
    /// <param name="status">The expense status.</param>
    /// <param name="subjectId">The customer subject id.</param>
    /// <param name="since">The date since when the expense was created.</param>
    /// <param name="number">The expense display number.</param>
    /// <returns>
    /// List of <see cref="FakturoidExpense" /> instances.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">subjectId;Value must be greater than zero.</exception>
    public Task<IEnumerable<FakturoidExpense>> SelectAsync(ExpenseStatusCondition status = ExpenseStatusCondition.Any, int? subjectId = null, DateTimeOffset? since = null, string number = null) {
        if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException(nameof(subjectId), "Value must be greater than zero.");

        // Get URI based on expense type
        var uri = CollectionPath;

        // Get status string based
        string statusString = null;
        switch (status) {
            case ExpenseStatusCondition.Open:
                statusString = "open";
                break;
            case ExpenseStatusCondition.Overdue:
                statusString = "overdue";
                break;
            case ExpenseStatusCondition.Paid:
                statusString = "paid";
                break;
        }

        // Prepare query parameters
        var queryParams = new {
            status = statusString,
            subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
            since,
            number
        };

        // Get entities
        return GetAllPagedEntitiesAsync<FakturoidExpense>(uri, queryParams);
    }

    /// <summary>
    /// Gets asynchronously paged list of invoices.
    /// </summary>
    /// <param name="page">The page number.</param>
    /// <param name="status">The expense status.</param>
    /// <param name="subjectId">The customer subject id.</param>
    /// <param name="since">The date since when the expense was created.</param>
    /// <param name="number">The expense display number.</param>
    /// <returns>
    /// List of <see cref="FakturoidExpense" /> instances.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// page;Value must be greater than zero.
    /// or
    /// subjectId;Value must be greater than zero.
    /// </exception>
    public Task<IEnumerable<FakturoidExpense>> SelectAsync(int page, ExpenseStatusCondition status = ExpenseStatusCondition.Any, int? subjectId = null, DateTimeOffset? since = null, string number = null) {
        if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.");
        if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException(nameof(subjectId), "Value must be greater than zero.");

        // Get URI based on expense type
        var uri = CollectionPath;

        // Get status string based
        string statusString = null;
        switch (status) {
            case ExpenseStatusCondition.Open:
                statusString = "open";
                break;
            case ExpenseStatusCondition.Overdue:
                statusString = "overdue";
                break;
            case ExpenseStatusCondition.Paid:
                statusString = "paid";
                break;
        }

        // Prepare query parameters
        var queryParams = new {
            status = statusString,
            subject_id = subjectId.HasValue ? subjectId.Value.ToString() : null,
            since,
            number
        };

        // Get entities
        return GetPagedEntitiesAsync<FakturoidExpense>(uri, page);
    }

    /// <summary>
    /// Deletes asynchronously expense with specified id.
    /// </summary>
    /// <param name="id">The contact id.</param>
    /// <exception cref="ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
    public Task DeleteAsync(int id) {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

        return DeleteSingleEntityAsync(string.Format(EntityPath, id));
    }

    /// <summary>
    /// Creates asynchronously the specified new expense.
    /// </summary>
    /// <param name="entity">The new expense.</param>
    /// <returns>ID of newly created expense.</returns>
    /// <exception cref="ArgumentNullException">entity</exception>
    public async Task<int> CreateAsync(FakturoidExpense entity) => entity == null ? throw new ArgumentNullException(nameof(entity)) : await CreateEntityAsync(CollectionPath, entity);

    /// <summary>
    /// Updates asynchronously the specified expense.
    /// </summary>
    /// <param name="entity">The expense to update.</param>
    /// <returns>Instance of <see cref="FakturoidExpense"/> class with modified entity.</returns>
    /// <exception cref="ArgumentNullException">entity</exception>
    public async Task<FakturoidExpense> UpdateAsync(FakturoidExpense entity) => entity == null
            ? throw new ArgumentNullException(nameof(entity))
            : await UpdateSingleEntityAsync(string.Format(EntityPath, entity.Id), entity);

    /// <summary>
    /// Sets asynchronously the expense payment status.
    /// </summary>
    /// <param name="id">The expense id.</param>
    /// <param name="status">The new payment status.</param>
    /// <returns>Instance of <see cref="FakturoidExpense"/> class with modified entity.</returns>
    public Task SetPaymentStatusAsync(int id, ExpensePaymentStatus status) => this.SetPaymentStatusAsync(id, status, DateTime.Now);

    /// <summary>
    /// Sets asynchronously the expense payment status.
    /// </summary>
    /// <param name="id">The expense id.</param>
    /// <param name="status">The new payment status.</param>
    /// <param name="effectiveDate">The date when payment was performed.</param>
    public async Task SetPaymentStatusAsync(int id, ExpensePaymentStatus status, DateTime effectiveDate) {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

        // Get url
        string urlFormat;
        switch (status) {
            case ExpensePaymentStatus.Paid:
                urlFormat = "expenses/{0}/fire.json?event=pay&paid_on=" + Uri.EscapeDataString(XmlConvert.ToString(effectiveDate, XmlDateTimeSerializationMode.RoundtripKind));
                break;
            default:
                urlFormat = "expenses/{0}/fire.json?event=remove_payment";
                break;
        }

        var c = this.Context.GetHttpClient();
        var r = await c.PostAsync(string.Format(urlFormat, id), new StringContent(string.Empty));
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Sets attachment for invoice.
    /// </summary>
    /// <param name="id">The invoice id.</param>
    /// <param name="mimeType">The mime type.</param>
    /// <param name="fileContent">The content of the file.</param>
    public async Task SetAttachmentAsync(int id, string mimeType, byte[] fileContent) {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");
        if (mimeType == null) throw new ArgumentNullException(nameof(mimeType));
        if (fileContent == null) throw new ArgumentNullException(nameof(fileContent));

        var base64 = Convert.ToBase64String(fileContent);
        var attachment = new {
            attachment = $"data:{mimeType};base64,{base64}"
        };

        var c = this.Context.GetHttpClient();
        var r = await c.PutAsJsonAsync($"expenses/{id}.json", attachment);
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Sets attachment for invoice.
    /// </summary>
    /// <param name="id">The invoice id.</param>
    /// <param name="filePath">The file path.</param>
    public Task SetAttachmentAsync(int id, string filePath) {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");
        if (filePath == null) throw new ArgumentNullException(nameof(filePath));

        var mimeType = MimeTypes.GetMimeType(filePath);
        var bytes = File.ReadAllBytes(filePath);

        return this.SetAttachmentAsync(id, mimeType, bytes);
    }

}
