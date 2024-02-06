using Sejm.Lib.Models.SejmPrints;

namespace Sejm.Lib;

public interface ISejmPrints
{
    /// <summary>
    /// Returns print details
    /// </summary>
    /// <param name="term">Sejm cadence</param>
    /// <param name="nr">Print number</param>
    /// <returns>Returns print details.</returns>
    Task<SejmPrintsModel> GetPrint(int term, int nr);
}