using Newtonsoft.Json;

namespace Sejm.Lib.Models.Cadence;

public class Cadence
{
    public bool Current { get; set; }
    public string From { get; set; }
    public int Num { get; set; }
    public Prints Prints { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}