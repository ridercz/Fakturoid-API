﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    /// <summary>
    /// Proxy class for working with subjects/contacts.
    /// </summary>
    public class FakturoidSubjectsProxy : FakturoidEntityProxy {

        internal FakturoidSubjectsProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets asynchronously list of all subjects.
        /// </summary>
        /// <param name="customId">The custom identifier used for filtering.</param>
        /// <param name="createdSince">List only subjects created since certain date.</param>
        /// <param name="updatedSince">List only subjects updated since certain date.</param>
        /// <returns>
        /// List of <see cref="JsonSubject" /> instances.
        /// </returns>
        public Task<IEnumerable<JsonSubject>> SelectAsync(string customId = null, DateTime? createdSince = default, DateTime? updatedSince = default) => base.GetAllPagedEntitiesAsync<JsonSubject>("subjects.json", new { custom_id = customId, updated_since = updatedSince, since = createdSince });

        /// <summary>
        /// Searches asynchronously all Subjects in Name, Full name, Email, Email copy, Registration number, VAT number and Private note.
        /// </summary>
        /// <param name="searchTerm">Search string.</param>
        /// <returns>Collection if search results.</returns>
        public Task<IEnumerable<JsonSubject>> SearchAsync(string searchTerm) =>
            base.GetUnpagedEntitiesAsync<JsonSubject>("subjects/search.json", new {
                query = searchTerm
            });

        /// <summary>
        /// Gets asynchronously paged list of subjects
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <returns>List of <see cref="JsonSubject"/> instances.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Value must be greater than zero.</exception>
        public async Task<IEnumerable<JsonSubject>> SelectAsync(int page) {
            return page < 1
                ? throw new ArgumentOutOfRangeException(nameof(page), "Value must be greater than zero.")
                : await base.GetPagedEntitiesAsync<JsonSubject>("subjects.json", page);
        }

        /// <summary>
        /// Selects asynchronously single subject with specified ID.
        /// </summary>
        /// <param name="id">The subject id.</param>
        /// <returns>Instance of <see cref="JsonSubject"/> class.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public async Task<JsonSubject> SelectSingleAsync(int id) {
            return id < 1
                ? throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.")
                : await base.GetSingleEntityAsync<JsonSubject>(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Deletes asynchronously with specified id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public Task DeleteAsync(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "Value must be greater than zero.");

            return base.DeleteSingleEntityAsync(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Creates asynchronously the specified new subject.
        /// </summary>
        /// <param name="entity">The new subject.</param>
        /// <returns>ID of newly created subject.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public async Task<int> CreateAsync(JsonSubject entity) => entity == null ? throw new ArgumentNullException(nameof(entity)) : await base.CreateEntityAsync("subjects.json", entity);

        /// <summary>
        /// Updates asynchronously the specified subject.
        /// </summary>
        /// <param name="entity">The subject to update.</param>
        /// <returns>Instance of <see cref="JsonSubject"/> class with modified entity.</returns>
        /// <exception cref="ArgumentNullException">entity</exception>
        public async Task<JsonSubject> UpdateAsync(JsonSubject entity) {
            return entity == null
                ? throw new ArgumentNullException(nameof(entity))
                : await base.UpdateSingleEntityAsync(string.Format("subjects/{0}.json", entity.id), entity);
        }

    }
}
