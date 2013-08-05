using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// The exception representing error returned by Fakturoid API.
    /// </summary>
    [Serializable]
    public class FakturoidException : Exception {

        #region Required by exception infrastructure

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        public FakturoidException()
            : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public FakturoidException(string message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public FakturoidException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public FakturoidException(string message, Exception innerException)
            : base(message, innerException) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="innerException">The inner exception.</param>
        /// <param name="args">The args.</param>
        public FakturoidException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected FakturoidException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="response">The HTTP response to get exception information from.</param>
        public FakturoidException(HttpResponseMessage response)
            : base(string.Format("API returned HTTP error {0} {1}",
                (int)response.StatusCode,
                Enum.GetName(typeof(System.Net.HttpStatusCode), response.StatusCode))) {

            // Set response and body
            this.Response = response;
            this.ResponseBody = response.Content.ReadAsStringAsync().Result;

            // Populate internal list of errors
            var errors = new List<KeyValuePair<string, string>>();
            if ((int)response.StatusCode == 422) { // Unprocessable entity
                try {
                    // Try to deserialize the error structure
                    var jsonError = (JObject)JsonConvert.DeserializeObject(this.ResponseBody);
                    foreach (var prop in jsonError["errors"].Children().OfType<JProperty>()) {
                        var valueArray = ((JArray)prop.Value).Select(x => ((JValue)x).Value as string);
                        foreach (var value in valueArray) {
                            errors.Add(new KeyValuePair<string, string>(prop.Name, value));
                        }
                    }
                }
                catch (Exception ex) {
                    // Deserialization failed
                    errors.Add(new KeyValuePair<string, string>("json_parse_on_client_failed", "Error while parsing received body: " + ex.Message));
                }
            }
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or sets the related HTTP response object.
        /// </summary>
        /// <value>
        /// The HTTP response.
        /// </value>
        public HttpResponseMessage Response { get; set; }

        /// <summary>
        /// Gets the HTTP response body as string.
        /// </summary>
        /// <value>
        /// The response body as string.
        /// </value>
        public string ResponseBody { get; private set; }

        /// <summary>
        /// Gets the errors returned by Fakturoid API.
        /// </summary>
        /// <value>
        /// The list of errors returned by Fakturoid API.
        /// </value>
        public IEnumerable<KeyValuePair<string, string>> Errors { get; private set; }

    }
}
