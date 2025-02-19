using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace Altairis.Fakturoid.Client;

internal static class FakturoidExtensionMethods {
    private static readonly JsonSerializerSettings JSON_SETTINGS = new() { ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() } };

    public static Task<HttpResponseMessage> FakturoidPostAsJsonAsync<T>(this HttpClient client, string requestUri, T value) {
        var content = new StringContent(JsonConvert.SerializeObject(value, JSON_SETTINGS), Encoding.UTF8, "application/json");
        return client.PostAsync(requestUri, content);
    }

    public static Task<HttpResponseMessage> FakturoidPatchAsJsonAsync<T>(this HttpClient client, string requestUri, T value) {
        var content = new StringContent(JsonConvert.SerializeObject(value, JSON_SETTINGS), Encoding.UTF8, "application/json");
        var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) { Content = content };
        return client.SendAsync(request);
    }

    public static async Task<T> FakturoidReadAsAsync<T>(this HttpContent content) {
        var json = await content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(json, JSON_SETTINGS);
    }
    public static void EnsureFakturoidSuccess(this HttpResponseMessage r) {
        if (r == null) throw new ArgumentNullException(nameof(r));
        if (r.IsSuccessStatusCode) return;

        throw new FakturoidException(r);
    }

}
