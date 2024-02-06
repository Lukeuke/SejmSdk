using Newtonsoft.Json;

namespace Sejm.Lib.Abstraction;

internal static class HttpRequestHelper
{
    internal static async Task<T?> Request<T>(string requestUri)
    {
        using var httpClient = new HttpClient();

        try
        {
            var response = await httpClient.GetAsync(requestUri);

            if (!response.IsSuccessStatusCode) return default;
            
            var json = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<T>(json);

            return content;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return default;
        }

    }
}
