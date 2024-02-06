using Sejm.Lib;
using Sejm.Lib.Models.Cadence;

namespace Sejm.Tests;

public class CadenceTest
{
    [Test]
    public async Task TestSejmCadenceType()
    {
        var c = new SejmCadence();

        var cadence = await c.GetCadence(9);

        Console.WriteLine(cadence);
        Assert.AreEqual(typeof(Cadence), cadence?.GetType());
    }
}