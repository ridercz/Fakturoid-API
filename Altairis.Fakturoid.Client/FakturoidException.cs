using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
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
        public FakturoidException() { }

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

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="response">The HTTP response to get exception information from.</param>
        public FakturoidException(HttpResponseMessage response)
            : base(string.Format("API returned HTTP error {0} {1}",
                (int)response.StatusCode,
                Enum.GetName(typeof(System.Net.HttpStatusCode), response.StatusCode))) {

            this.Response = response;
            this.PopulateFromResponse();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakturoidException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected FakturoidException(SerializationInfo info, StreamingContext context)
            : base(info, context) {

            this.Response = (HttpResponseMessage)info.GetValue("Response", typeof(HttpResponseMessage));
            this.PopulateFromResponse();

        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" />
        /// </PermissionSet>
        public override void GetObjectData(SerializationInfo info, StreamingContext context) {
            base.GetObjectData(info, context);

            info.AddValue("Response", this.Response);
        }

        /// <summary>
        /// Gets or sets the related HTTP response object.
        /// </summary>
        /// <value>
        /// The HTTP response.
        /// </value>
        public HttpResponseMessage Response { get; private set; }

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

        /// <summary>
        /// Populates the exception properties from already set HttpResponseMessage in Response property.
        /// </summary>
        private void PopulateFromResponse() {
            // Publish response body
            this.ResponseBody = this.Response.Content.ReadAsStringAsync().Result;

            // Populate list of errors
            var errors = new List<KeyValuePair<string, string>>();
            if ((int)this.Response.StatusCode == 422) {
                // Unprocessable entity
                try {
                    // Try to deserialize the error structure
                    var jsonError = (JObject)JsonConvert.DeserializeObject(this.ResponseBody);
                    foreach (var prop in jsonError["errors"].Children().OfType<JProperty>()) {
                        var valueArray = ((JArray)prop.Value).Select(x => ((JValue)x).Value as string);
                        foreach (var value in valueArray) {
                            errors.Add(new KeyValuePair<string, string>(prop.Name, value));
                        }
                    }
#pragma warning disable CA1031 // Do not catch general exception types
                } catch (Exception ex) {
                    // Deserialization failed
                    errors.Add(new KeyValuePair<string, string>("json_parse_on_client_failed", "Error while parsing received body: " + ex.Message));
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }
            this.Errors = errors;
        }

    }
}
