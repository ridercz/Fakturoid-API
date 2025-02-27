﻿using System.ComponentModel;
using System.Text;
using System.Xml;

namespace Altairis.Fakturoid.Client.Proxies;

/// <summary>
/// Proxy class for working with any Fakturoid entity
/// </summary>
public abstract class FakturoidEntityProxy {

    // Initialization

    /// <summary>
    /// Initializes a new instance of the <see cref="FakturoidEntityProxy"/> class.
    /// </summary>
    /// <param name="context">The related context.</param>
    /// <exception cref="ArgumentNullException">context</exception>
    protected FakturoidEntityProxy(FakturoidContext context) {
        this.Context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Gets the related context.
    /// </summary>
    /// <value>
    /// The related context.
    /// </value>
    public FakturoidContext Context { get; private set; }

    // Helper methods for proxy classes

    /// <summary>
    /// Gets asynchronously all paged entities, making sequential repeated requests for pages.
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="baseUri">The base URI.</param>
    /// <param name="additionalQueryParams">The additional query params.</param>
    /// <returns>All existing entities of given type.</returns>
    /// <remarks>The result may contain duplicate entities, if they are modified between requests for pages. In current version of API, there is no way to solve rhis.</remarks>
    protected async Task<IEnumerable<T>> GetAllPagedEntitiesAsync<T>(string baseUri, object additionalQueryParams = null) {
        var completeList = new List<T>();
        var page = 1;

        while (true) {
            var partialList = await this.GetPagedEntitiesAsync<T>(baseUri, page, additionalQueryParams);
            if (!partialList.Any()) break; // no more entities
            completeList.AddRange(partialList);
            page++;
        }

        return completeList;
    }

    /// <summary>
    /// Gets asynchronously single page of entities.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    /// <param name="baseUri">The base URI.</param>
    /// <param name="page">The page number.</param>
    /// <param name="additionalQueryParams">The additional query params.</param>
    /// <returns>Paged list of entities of given type.</returns>
    /// <exception cref="ArgumentNullException">uri</exception>
    /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.;uri</exception>
    /// <exception cref="ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
    /// <remarks>The number of entities on single page is determined by API and is different for each type. In current version of API, there is no way to detect or change page size.</remarks>
    protected Task<IEnumerable<T>> GetPagedEntitiesAsync<T>(string baseUri, int page, object additionalQueryParams = null) {
        if (baseUri == null) throw new ArgumentNullException(nameof(baseUri));
        if (string.IsNullOrWhiteSpace(baseUri)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(baseUri));
        if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.");

        // Build URI
        var uri = baseUri + "?page=" + page + GetQueryStringFromParams(additionalQueryParams, "&");

        // Get result
        return this.GetSingleEntityAsync<IEnumerable<T>>(uri);
    }

    /// <summary>
    /// Gets asynchronously the unpaged entities.
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="baseUri">The base URI.</param>
    /// <param name="additionalQueryParams">The additional query params.</param>
    /// <returns>List of entities of given type.</returns>
    /// <exception cref="ArgumentNullException">uri</exception>
    /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.;uri</exception>
    protected Task<IEnumerable<T>> GetUnpagedEntitiesAsync<T>(string baseUri, object additionalQueryParams = null) {
        if (baseUri == null) throw new ArgumentNullException(nameof(baseUri));
        if (string.IsNullOrWhiteSpace(baseUri)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(baseUri));

        // Build URI
        var uri = baseUri + GetQueryStringFromParams(additionalQueryParams, "?");

        // Get result
        return this.GetSingleEntityAsync<IEnumerable<T>>(uri);
    }

    /// <summary>
    /// Gets asynchronously single entity of given type.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    /// <param name="uri">The URI.</param>
    /// <returns>Single entity of given type.</returns>
    /// <exception cref="ArgumentNullException">uri</exception>
    /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.;uri</exception>
    protected async Task<T> GetSingleEntityAsync<T>(string uri) {
        if (uri == null) throw new ArgumentNullException(nameof(uri));
        if (string.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(uri));

        // Get result
        var c = this.Context.GetHttpClient();
        var r = await c.GetAsync(uri);

        // Ensure result was successfull
        r.EnsureFakturoidSuccess();

        // Parse and return result
        return await r.Content.FakturoidReadAsAsync<T>();
    }

    /// <summary>
    /// Creates asynchronously new entity.
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="uri">The endpoint URI.</param>
    /// <param name="newEntity">The new entity.</param>
    /// <returns>ID of newly created entity.</returns>
    /// <exception cref="ArgumentNullException">
    /// uri
    /// or
    /// newEntity
    /// </exception>
    /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.;uri</exception>
    /// <exception cref="FormatException"></exception>
    protected async Task<int> CreateEntityAsync<T>(string uri, T newEntity) where T : class {
        if (uri == null) throw new ArgumentNullException(nameof(uri));
        if (string.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(uri));
        if (newEntity == null) throw new ArgumentNullException(nameof(newEntity));

        // Create new entity
        var c = this.Context.GetHttpClient();
        var r = await c.FakturoidPostAsJsonAsync(uri, newEntity);
        r.EnsureFakturoidSuccess();

        // Extract ID from URI
        try {
            var idString = r.Headers.Location.ToString();
            if (idString.EndsWith(".json", StringComparison.OrdinalIgnoreCase)) idString = idString.Substring(0, idString.Length - 5); // remove .json extension
            idString = idString.Substring(idString.LastIndexOf('/') + 1); // last path component should now be numeric ID
            return int.Parse(idString);
        } catch (Exception) {
            throw new FormatException(string.Format("Unexpected format of new entity URI. Expected format 'scheme://anystring/123456.json', got '{0}' instead.", r.Headers.Location));
        }
    }

    /// <summary>
    /// Deletes asynchronously single entity.
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <exception cref="ArgumentNullException">uri</exception>
    /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.;uri</exception>
    protected async Task DeleteSingleEntityAsync(string uri) {
        if (uri == null) throw new ArgumentNullException(nameof(uri));
        if (string.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(uri));

        // Get result
        var c = this.Context.GetHttpClient();
        var r = await c.DeleteAsync(uri);

        // Ensure result was successfull
        r.EnsureFakturoidSuccess();
    }

    /// <summary>
    /// Updates asynchronously the single entity.
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <param name="uri">The entity URI.</param>
    /// <param name="entity">The entity object.</param>
    /// <returns>Returns the updated entity</returns>
    /// <exception cref="ArgumentNullException">
    /// </exception>
    /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.</exception>
    /// <exception cref="ArgumentNullException">uri
    /// or
    /// entity</exception>
    /// <exception cref="ArgumentException">Value cannot be empty or whitespace only string.;uri</exception>
    protected async Task<T> UpdateSingleEntityAsync<T>(string uri, T entity) where T : class {
        if (uri == null) throw new ArgumentNullException(nameof(uri));
        if (string.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(uri));
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        // Get result
        var c = this.Context.GetHttpClient();
        var r = await c.FakturoidPatchAsJsonAsync(uri, entity);

        // Ensure result was successfull
        r.EnsureFakturoidSuccess();

        // Return updated entity
        return await r.Content.FakturoidReadAsAsync<T>();
    }

    // Helper methods for this class

    /// <summary>
    /// Gets the query string from properties of any (usually anonymous) object.
    /// </summary>
    /// <param name="queryParams">The query parameters as properties of any object.</param>
    /// <param name="prefix">The query string prefix.</param>
    /// <returns>Returns constructed query string.</returns>
    /// <exception cref="ArgumentNullException">prefix</exception>
    private static string GetQueryStringFromParams(object queryParams, string prefix) {
        if (prefix == null) throw new ArgumentNullException(nameof(prefix));
        if (queryParams == null) return string.Empty;

        var qsb = new StringBuilder();

        foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(queryParams)) {
            // Get property value
            var rawValue = descriptor.GetValue(queryParams);
            if (rawValue == null) continue; // null queryParams do not propagate to query

            string stringValue = null;
            if (rawValue is DateTimeOffset dto) {
                // Format DateTimeOffset
                stringValue = XmlConvert.ToString(dto);
            } else if (rawValue is DateTimeOffset?) {
                // Format nullable DateTimeOffset
                var dateValue = (DateTimeOffset?)rawValue;
                if (dateValue.HasValue) stringValue = XmlConvert.ToString(dateValue.Value);
            } else if (rawValue is DateTime time) {
                // Format DateTime
                stringValue = XmlConvert.ToString(time, XmlDateTimeSerializationMode.RoundtripKind);
            } else if (rawValue is DateTime?) {
                // Format nullable DateTime
                var dateValue = (DateTime?)rawValue;
                if (dateValue.HasValue) stringValue = XmlConvert.ToString(dateValue.Value, XmlDateTimeSerializationMode.RoundtripKind);
            } else if (rawValue is IFormattable formattableValue) {
                // Format IFormattable rawValue
                stringValue = formattableValue.ToString(null, System.Globalization.CultureInfo.InvariantCulture);
            } else {
                // Format other value - just use ToString()
                stringValue = rawValue.ToString();
            }

            if (string.IsNullOrWhiteSpace(stringValue)) continue; // empty value after string conversion
            qsb.AppendFormat("{0}={1}&", descriptor.Name, Uri.EscapeDataString(stringValue));
        }

        var qs = qsb.ToString().TrimEnd('&');
        return string.IsNullOrWhiteSpace(qs) ? string.Empty : prefix + qs;
    }

}
