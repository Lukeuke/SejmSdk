using Newtonsoft.Json;

namespace Sejm.Lib.Models.Cadence;

public class Prints
{
    public int Count { get; set; }
    public DateTime LastChanged { get; set; }
    public string Link { get; set; }
    
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}