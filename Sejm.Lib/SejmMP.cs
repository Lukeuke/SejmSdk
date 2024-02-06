using Sejm.Lib.Abstraction;
using Sejm.Lib.Models.MP;

namespace Sejm.Lib;

public class SejmMP : ISejmMP
{
    /// <summary>
    /// Returns a list of all MPs (including those no longer in office) in a given term
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <returns>Returns a list of all MPs (including those no longer in office) in a given term</returns>
    public async Task<IList<Member>?> GetAllMPs(int term)
    {
        var members = await HttpRequestHelper.Request<List<Member>>($"https://api.sejm.gov.pl/sejm/term{term}/MP");

        return members ?? null;
    }
}