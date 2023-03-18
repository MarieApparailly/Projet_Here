namespace Projet_Here.Models;


// enum définissant le statut du membre
public enum Status
{
    EN_MISSION,
    DISPONIBLE,
    EN_REPOS
}

public class Team 
{
    public int Id { get; set; }
    public string Name { get; set;} = null!;
    public string? Description { get; set; }

    public List<User> Users { get; set; }

    public Team(User user)
    {
        Users.Add(user);
    }
}