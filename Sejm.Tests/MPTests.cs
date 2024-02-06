using Sejm.Lib;
using Sejm.Lib.Models.MP;

namespace Sejm.Tests;

public class MPTests
{
    [Test]
    public static async Task MPTest()
    {
        var mp = new SejmMP();

        var allMPs = await mp.GetAllMPs(9);
        
        Assert.AreEqual(typeof(List<Member>),allMPs?.GetType());
    }
}