using Sejm.Lib;
using Sejm.Lib.Models.SejmPrints;

namespace Sejm.Tests;

public class PrintsTests
{
    [Test]
    public async Task TestSejmPrint()
    {
        var c = new SejmPrints();

        var print = await c.GetPrint(9, 23);

        if (print?.GetType() == typeof(SejmPrintsModel))
        {
            Console.WriteLine(print);
            Assert.Pass();
        }

        Assert.Fail();
    }
}