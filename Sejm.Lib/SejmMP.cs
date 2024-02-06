using System.Globalization;
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
    public async Task<IList<Member>> GetAllMPs(int term)
    {
        var members = await HttpRequestHelper.Request<List<Member>>($"https://api.sejm.gov.pl/sejm/term{term}/MP");

        return members;
    }

    /// <summary>
    /// Returns details about MP
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <param name="leg">parliamentary ID number</param>
    /// <returns>Returns details about MP</returns>
    public async Task<Member> GetMP(int term, int leg)
    {
        var member = await HttpRequestHelper.Request<Member>($"https://api.sejm.gov.pl/sejm/term{term}/MP/{leg}");
        return member ?? null;
    }

    public async Task<List<MPVoting>> GetMPVotings(int term, int leg, int sitting, DateOnly date)
    {
        var url =
            $"https://api.sejm.gov.pl/sejm/term{term}/MP/{leg}/votings/{sitting}/{date.ToString("o", CultureInfo.InvariantCulture)}";
        var voting = await HttpRequestHelper.Request<List<MPVoting>>(url);
        return voting;
    }
}