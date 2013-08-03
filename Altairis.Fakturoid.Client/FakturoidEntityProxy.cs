using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Altairis.Fakturoid.Client {
    public abstract class FakturoidEntityProxy {

        protected FakturoidEntityProxy(FakturoidContext context) {
            if (context == null) throw new ArgumentNullException("context");
            this.Context = context;
        }

        protected FakturoidContext Context { get; private set; }

        protected IEnumerable<T> GetEntities<T>(string baseUri, object additionalQueryParams) {
            var completeList = new List<T>();
            var page = 1;

            while (true) {
                var partialList = this.GetEntities<T>(baseUri, page, additionalQueryParams);
                if (!partialList.Any()) break; // no more entities
                completeList.AddRange(partialList);
                page++;
            }

            return completeList;
        }

        protected IEnumerable<T> GetEntities<T>(string baseUri, int page, object additionalQueryParams) {
            if (baseUri == null) throw new ArgumentNullException("baseUri");
            if (string.IsNullOrWhiteSpace(baseUri)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "baseUri");
            if (page < 1) throw new ArgumentOutOfRangeException("page", "Page must be greater than zero.");

            // Build URI
            var uri = baseUri + "?page=" + page + GetQueryStringFromParams(additionalQueryParams);

            // Get result
            var c = this.Context.GetHttpClient();
            var r = c.GetAsync(uri).Result;

            // Ensure result was successfull
            r.EnsureSuccessStatusCode();

            // Parse and return result
            return r.Content.ReadAsAsync<IEnumerable<T>>().Result;
        }

        private static string GetQueryStringFromParams(object queryParams) {
            if (queryParams == null) return string.Empty;

            var qsb = new StringBuilder();

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(queryParams)) {
                // Get property value
                var rawValue = descriptor.GetValue(queryParams);
                if (rawValue == null) continue; // null queryParams do not propagate to query

                string stringValue = null;
                if (rawValue.GetType() == typeof(DateTime)) {
                    // Format date
                    stringValue = XmlConvert.ToString((DateTime)rawValue, XmlDateTimeSerializationMode.RoundtripKind);
                }
                else if (rawValue.GetType() == typeof(DateTime?)) {
                    // Format nullable date
                    var dateValue = (DateTime?)rawValue;
                    if (dateValue.HasValue) stringValue = XmlConvert.ToString(dateValue.Value, XmlDateTimeSerializationMode.RoundtripKind);
                }
                else {
                    var formattableValue = rawValue as IFormattable;
                    if (formattableValue != null) {
                        // Format IFormattable rawValue
                        stringValue = formattableValue.ToString(null, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    else {
                        // Format other value - just use ToString()
                        stringValue = rawValue.ToString();
                    }
                }

                if (string.IsNullOrWhiteSpace(stringValue)) continue; // empty value after string conversion
                qsb.AppendFormat("&{0}={1}", descriptor.Name, Uri.EscapeDataString(stringValue));
            }

            return qsb.ToString();
        }

    }
}
