using Newtonsoft.Json;

namespace Sejm.Lib.Models.MP;

public class MPVoting
{
    public DateTime Date { get; set; }
    public string Kind { get; set; }
    public string Title { get; set; }
    public string Topic { get; set; }
    public string Vote { get; set; }
    public int VotingNumber { get; set; }
    public string Description { get; set; }
    
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}