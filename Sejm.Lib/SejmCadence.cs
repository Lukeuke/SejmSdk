using Newtonsoft.Json;
using Sejm.Lib.Models.Cadence;

namespace Sejm.Lib;

public class SejmCadence : ISejmCadence
{
    /// <summary>
    /// Basic information's about cadence
    /// </summary>
    /// <param name="term">Sejm Cadence</param>
    /// <returns>Basic information's about cadence</returns>
    public async Task<Cadence?> GetCadence(int term)
    {
        using var httpClient = new HttpClient();

        try
        {
            var response = await httpClient.GetAsync($"https://api.sejm.gov.pl/sejm/term{term}");

            if (!response.IsSuccessStatusCode) return null;
            
            var json = await response.Content.ReadAsStringAsync();

            var cadence = JsonConvert.DeserializeObject<Cadence>(json);

            return cadence;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
        
    }
}