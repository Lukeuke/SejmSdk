using Sejm.Lib.Models.MP;

namespace Sejm.Lib;

public interface ISejmMP
{
    /// <summary>
    /// Returns a list of all MPs (including those no longer in office) in a given term
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <returns>Returns a list of all MPs (including those no longer in office) in a given term</returns>
    Task<IList<Member>> GetAllMPs(int term);

    /// <summary>
    /// Returns details about MP
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <param name="leg">parliamentary ID number</param>
    /// <returns>Returns details about MP</returns>
    Task<Member> GetMP(int term, int leg);

    /// <summary>
    /// Returns the voting results of a given MP on a given voting day.
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <param name="leg">parliamentary ID number</param>
    /// <param name="sitting">Sejm sitting number</param>
    /// <param name="date">Date of voting</param>
    /// <returns>Returns the voting results of a given MP on a given voting day.</returns>
    Task<List<MPVoting>> GetMPVotings(int term, int leg, int sitting, DateOnly date);
}