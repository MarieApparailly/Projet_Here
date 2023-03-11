namespace Projet_Here.Models;

public enum Status
{
    EN_MISSION,
    DISPONIBLE,
    EN_REPOS
}

public class User 
{
    public int Id { get; set; }
    public string Pseudo { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Mail { get; set; }
    public Status Status { get; set; } 
    public bool Car { get; set; }
    public string Team { get; set; } = null!;
    public List<Mission> Missions { get; set; } = new List<Mission>();

    public User() { 
        Status = Status.DISPONIBLE;
    }

    public User(string team) {
        Team = team;
    }

}