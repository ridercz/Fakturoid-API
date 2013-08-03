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
    [Serializable]
    public class FakturoidException : Exception {

        #region Required by exception infrastructure

        public FakturoidException()
            : base() { }

        public FakturoidException(string message)
            : base(message) { }

        public FakturoidException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public FakturoidException(string message, Exception innerException)
            : base(message, innerException) { }

        public FakturoidException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected FakturoidException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        #endregion

        public FakturoidException(HttpResponseMessage response)
            : base(string.Format("API returned HTTP error {0} {1}",
                response.StatusCode.ToString(),
                Enum.GetName(typeof(System.Net.HttpStatusCode), response.StatusCode))) {

            // Set response and body
            this.Response = response;
            this.ResponseBody = response.Content.ReadAsStringAsync().Result;

            var errors = new List<KeyValuePair<string, string>>();
            if ((int)response.StatusCode == 422) {
                // Unprocessable entity
                try {
                    var jsonError = (JObject)JsonConvert.DeserializeObject(this.ResponseBody);
                    foreach (var prop in jsonError["errors"].Children().OfType<JProperty>()) {
                        var valueArray = ((JArray)prop.Value).Select(x => ((JValue)x).Value as string);
                        foreach (var value in valueArray) {
                            errors.Add(new KeyValuePair<string, string>(prop.Name, value));
                        }
                    }
                }
                catch (Exception ex) {
                    errors.Add(new KeyValuePair<string, string>("json_parse", "Error while parsing received body: " + ex.Message));
                }
            }
            this.Errors = errors;
        }

        public HttpResponseMessage Response { get; set; }

        public string ResponseBody { get; private set; }

        public IEnumerable<KeyValuePair<string, string>> Errors { get; private set; }

    }
}
