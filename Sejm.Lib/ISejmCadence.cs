using Sejm.Lib.Models.Cadence;

namespace Sejm.Lib;

public interface ISejmCadence
{
    /// <summary>
    /// Basic information's about cadence
    /// </summary>
    /// <param name="term">Sejm Cadence</param>
    /// <returns>Basic information's about cadence</returns>
    Task<Cadence?> GetCadence(int term);
}