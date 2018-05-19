using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace Altairis.Fakturoid.Client {

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
    public enum ExpensePaymentStatus
    {
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
        /// Selects single expense with specified ID.
        /// </summary>
        /// <param name="id">The expense id.</param>
        /// <returns>
        /// Instance of <see cref="JsonExpense" /> class.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public JsonExpense SelectSingle(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            return base.GetSingleEntity<JsonExpense>(string.Format(EntityPath, id));
        }

        /// <summary>
        /// Selects asynchronously single expense with specified ID.
        /// </summary>
        /// <param name="id">The expense id.</param>
        /// <returns>
        /// Instance of <see cref="JsonExpense" /> class.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public async Task<JsonExpense> SelectSingleAsync(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            return await base.GetSingleEntityAsync<JsonExpense>(string.Format(EntityPath, id));
        }

        /// <summary>
        /// Gets list of all invoices.
        /// </summary>
        /// <param name="type">The expense type.</param>
        /// <param name="status">The expense status.</param>
        /// <param name="subjectId">The customer subject id.</param>
        /// <param name="since">The date since when the expense was created.</param>
        /// <param name="number">The expense display number.</param>
        /// <returns>
        /// List of <see cref="JsonExpense" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">subjectId;Value must be greater than zero.</exception>
        public IEnumerable<JsonExpense> Select(ExpenseStatusCondition status = ExpenseStatusCondition.Any, int? subjectId = null, DateTime? since = null, string number = null) {
            try {
                return this.SelectAsync(status, subjectId, since, number).Result;
            }
            catch (AggregateException aex) {
                throw aex.InnerException;
            }
        }

        /// <summary>
        /// Gets asynchronously list of all invoices.
        /// </summary>
        /// <param name="status">The expense status.</param>
        /// <param name="subjectId">The customer subject id.</param>
        /// <param name="since">The date since when the expense was created.</param>
        /// <param name="number">The expense display number.</param>
        /// <returns>
        /// List of <see cref="JsonExpense" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">subjectId;Value must be greater than zero.</exception>
        public async Task<IEnumerable<JsonExpense>> SelectAsync(ExpenseStatusCondition status = ExpenseStatusCondition.Any, int? subjectId = null, DateTime? since = null, string number = null) {
            if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException(nameof(subjectId), "Value must be greater than zero.");

            // Get URI based on expense type
            string uri = CollectionPath;

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
                since = since,
                number = number
            };

            // Get entities
            return await base.GetAllPagedEntitiesAsync<JsonExpense>(uri, queryParams);
        }

        /// <summary>
        /// Gets paged list of invoices.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="type">The expense type.</param>
        /// <param name="status">The expense status.</param>
        /// <param name="subjectId">The customer subject id.</param>
        /// <param name="since">The date since when the expense was created.</param>
        /// <param name="number">The expense display number.</param>
        /// <returns>
        /// List of <see cref="JsonExpense" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// page;Value must be greater than zero.
        /// or
        /// subjectId;Value must be greater than zero.
        /// </exception>
        public IEnumerable<JsonExpense> Select(int page, ExpenseStatusCondition status = ExpenseStatusCondition.Any, int? subjectId = null, DateTime? since = null, string number = null) {
            try {
                return this.SelectAsync(page, status, subjectId, since, number).Result;
            }
            catch (AggregateException aex) {
                throw aex.InnerException;
            }
        }

        /// <summary>
        /// Gets asynchronously paged list of invoices.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="type">The expense type.</param>
        /// <param name="status">The expense status.</param>
        /// <param name="subjectId">The customer subject id.</param>
        /// <param name="since">The date since when the expense was created.</param>
        /// <param name="number">The expense display number.</param>
        /// <returns>
        /// List of <see cref="JsonExpense" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// page;Value must be greater than zero.
        /// or
        /// subjectId;Value must be greater than zero.
        /// </exception>
        public async Task<IEnumerable<JsonExpense>> SelectAsync(int page, ExpenseStatusCondition status = ExpenseStatusCondition.Any, int? subjectId = null, DateTime? since = null, string number = null) {
            if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.");
            if (subjectId.HasValue && subjectId.Value < 1) throw new ArgumentOutOfRangeException(nameof(subjectId), "Value must be greater than zero.");

            // Get URI based on expense type
            string uri = CollectionPath;

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
                since = since,
                number = number
            };

            // Get entities
            return await base.GetPagedEntitiesAsync<JsonExpense>(uri, page);
        }

        /// <summary>
        /// Deletes expense with specified id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public void Delete(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            base.DeleteSingleEntity(string.Format(EntityPath, id));
        }

        /// <summary>
        /// Deletes asynchronously expense with specified id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public async Task DeleteAsync(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            await base.DeleteSingleEntityAsync(string.Format(EntityPath, id));
        }

        /// <summary>
        /// Creates the specified new expense.
        /// </summary>
        /// <param name="entity">The new expense.</param>
        /// <returns>ID of newly created expense.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public int Create(JsonExpense entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return base.CreateEntity(CollectionPath, entity);
        }

        /// <summary>
        /// Creates asynchronously the specified new expense.
        /// </summary>
        /// <param name="entity">The new expense.</param>
        /// <returns>ID of newly created expense.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public async Task<int> CreateAsync(JsonExpense entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return await base.CreateEntityAsync(CollectionPath, entity);
        }

        /// <summary>
        /// Updates the specified expense.
        /// </summary>
        /// <param name="entity">The expense to update.</param>
        /// <returns>Instance of <see cref="JsonExpense"/> class with modified entity.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public JsonExpense Update(JsonExpense entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return base.UpdateSingleEntity(string.Format(EntityPath, entity.id), entity);
        }

        /// <summary>
        /// Updates asynchronously the specified expense.
        /// </summary>
        /// <param name="entity">The expense to update.</param>
        /// <returns>Instance of <see cref="JsonExpense"/> class with modified entity.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public async Task<JsonExpense> UpdateAsync(JsonExpense entity) {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            return await base.UpdateSingleEntityAsync(string.Format(EntityPath, entity.id), entity);
        }



        /// <summary>
        /// Sets the expense payment status.
        /// </summary>
        /// <param name="id">The expense id.</param>
        /// <param name="status">The new payment status.</param>
        public void SetPaymentStatus(int id, ExpensePaymentStatus status) {
            this.SetPaymentStatus(id, status, DateTime.Now);
        }

        /// <summary>
        /// Sets asynchronously the expense payment status.
        /// </summary>
        /// <param name="id">The expense id.</param>
        /// <param name="status">The new payment status.</param>
        /// <returns>Instance of <see cref="JsonExpense"/> class with modified entity.</returns>
        public async Task SetPaymentStatusAsync(int id, ExpensePaymentStatus status) {
            await this.SetPaymentStatusAsync(id, status, DateTime.Now);
        }

        /// <summary>
        /// Sets the expense payment status.
        /// </summary>
        /// <param name="id">The expense id.</param>
        /// <param name="status">The new payment status.</param>
        /// <param name="effectiveDate">The date when payment was performed.</param>
        public void SetPaymentStatus(int id, ExpensePaymentStatus status, DateTime effectiveDate) {
            try {
                this.SetPaymentStatusAsync(id, status, effectiveDate).Wait();
            }
            catch (AggregateException aex) {
                throw aex.InnerException;
            }
        }

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
                    urlFormat = "expenses/{0}/fire.json?event=pay&paid_at=" + Uri.EscapeDataString(XmlConvert.ToString(effectiveDate, XmlDateTimeSerializationMode.RoundtripKind));
                    break;
                default:
                    urlFormat = "expenses/{0}/fire.json?event=remove_payment";
                    break;
            }

            var c = this.Context.GetHttpClient();
            var r = await c.PostAsync(string.Format(urlFormat, id), new StringContent(string.Empty));
            r.EnsureFakturoidSuccess();
        }

    }
}
