namespace Projet_Here.Models;

public class Place 
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string? Description { get; set; } 
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public List<Mission> Missions { get; set; } = new List<Mission>();
    //public List<Mission> EndMissions { get; set; } = new List<Mission>();

}