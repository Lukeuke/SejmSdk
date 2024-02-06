using Sejm.Lib.Models.SejmPrints;

namespace Sejm.Lib;

public interface ISejmPrints
{
    Task<SejmPrintsModel?> GetPrint(int term, int nr);
}