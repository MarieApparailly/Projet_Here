namespace Projet_Here.Models;

public class Mission 
{
    public int Id { get; set; }
    
    public int EventId { get; set; }
    public Event Event { get; set; } = null!;

    public int PlaceId { get; set; }
    public Place? Place { get; set; } 

    //public int PlaceId { get; set; }
    //public Place StartPlace { get; set; } = null!;

    public string Title { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public string? Description { get; set; }

    public List<User> Users { get; set; } = new List<User>();
}