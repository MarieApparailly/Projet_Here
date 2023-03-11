namespace PII_HERE.Models;

public class Event 
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ?string Description { get; set; }
    public ?List<Mission> Missions { get; set; } = new List<Mission>();
}