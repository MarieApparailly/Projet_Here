namespace Projet_Here.Models;

public class Mission 
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public string? Description { get; set; }
    public List<User> Users { get; set; } = new List<User>();
}