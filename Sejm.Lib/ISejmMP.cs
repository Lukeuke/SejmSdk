using Sejm.Lib.Models.MP;

namespace Sejm.Lib;

public interface ISejmMP
{
    /// <summary>
    /// Returns a list of all MPs (including those no longer in office) in a given term
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <returns>Returns a list of all MPs (including those no longer in office) in a given term</returns>
    Task<IList<Member>?> GetAllMPs(int term);
}