namespace PII_HERE.Models;

public enum Status
{
    "En mission",
    "Disponible",
    "En repos"
}

public class User 
{
    public int Id { get; set; }
    public string Pseudo { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public ?string Mail { get; set; }
    public Status Status { get; set; } = null!;
    public bool Car { get; set; } = null!;
    public string Team { get; set; } = null!;
    public ?List<Mission> Missions { get; set; } = new List<Mission>();

    public User() { 
        Status = "Disponible";
    }

    public User(string team) {
        Team = team;
    }

}