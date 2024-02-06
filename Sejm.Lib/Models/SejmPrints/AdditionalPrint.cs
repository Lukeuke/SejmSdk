using Newtonsoft.Json;

namespace Sejm.Lib.Models.SejmPrints;

public class AdditionalPrint
{
    public List<string> Attachments { get; set; }
    public DateTime ChangeDate { get; set; }
    public string DeliveryDate { get; set; }
    public string DocumentDate { get; set; }
    public string Number { get; set; }
    public List<string> NumberAssociated { get; set; }
    public List<string> ProcessPrint { get; set; }
    public int Term { get; set; }
    public string Title { get; set; }
    
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}