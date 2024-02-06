using Newtonsoft.Json;
using Sejm.Lib;
using Sejm.Lib.Models.MP;

namespace Sejm.Tests;

public class MPTests
{
    [Test]
    public static async Task GetAllMPTest()
    {
        var mp = new SejmMP();

        var allMPs = await mp.GetAllMPs(9);
        
        Assert.AreEqual(typeof(List<Member>),allMPs.GetType());
    }
    
    [Test]
    public static async Task GetAllMPTest_ShouldBeZero()
    {
        var mp = new SejmMP();

        var allMPs = await mp.GetAllMPs(0);
        
        Assert.AreEqual(0, allMPs.Count);
    }
    
    [Test]
    public static async Task GetMPTest()
    {
        var mp = new SejmMP();

        var member = await mp.GetMP(9, 1);

        Console.WriteLine(member);
        
        Assert.AreEqual(typeof(Member), member.GetType());
    }

    [Test]
    public static async Task GetVotingOfMP()
    {
        var mp = new SejmMP();

        var voting = await mp.GetMPVotings(10, 1, 4, new DateOnly(2024, 01, 25));

        Console.WriteLine(JsonConvert.SerializeObject(voting));
        
        Assert.AreEqual(typeof(List<MPVoting>), voting.GetType());
    }
}