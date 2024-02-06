using Sejm.Lib;
using Sejm.Lib.Models.Cadence;

namespace Sejm.Tests;

public class Tests
{
    [Test]
    public async Task TestSejmCadenceType()
    {
        var c = new SejmCadence();

        var cadence = await c.GetCadence(9);

        if (cadence?.GetType() == typeof(Cadence))
        {
            Console.WriteLine(cadence);
            Assert.Pass();
        }

        Assert.Fail();
    }
}