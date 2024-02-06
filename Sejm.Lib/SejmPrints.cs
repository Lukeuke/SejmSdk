using Sejm.Lib.Abstraction;
using Sejm.Lib.Models.SejmPrints;

namespace Sejm.Lib;

public sealed class SejmPrints : ISejmPrints
{
    /// <summary>
    /// Returns print details
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <param name="nr">Print number</param>
    /// <returns>Returns print details.</returns>
    public async Task<SejmPrintsModel> GetPrint(int term, int nr)
    {
        var content = await HttpRequestHelper.Request<SejmPrintsModel>($"https://api.sejm.gov.pl/sejm/term{term}/prints/{nr}");

        return content;
    }
}