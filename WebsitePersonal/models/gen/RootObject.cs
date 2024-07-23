namespace BlazorApp1.models.gen;

public class RootObject
{
    public string schema { get; set; }
    public string title { get; set; }
    public Definitions definitions { get; set; }
    public string type { get; set; }
    public Properties properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}