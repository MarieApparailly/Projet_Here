namespace Projet_Here.Models;


// enum for member' status
public enum Status
{
    EN_MISSION,
    DISPONIBLE,
    EN_REPOS
}


public class User 
{
    public int Id { get; set; }

    public string? Latitude { get; set; } 
    public string? Longitude { get; set; } 

    public int? PlaceId { get; set; } // à associer ou pour remplacer Latitude et Longitude (en fonction de l'API de localisation)
    public Place? Place { get; set; } 

    public string Pseudo { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Mail { get; set; }
    public string? Photo { get; set; }
    public bool Car { get; set; }

    public Status Status { get; set; } 
    public string Team { get; set; } = null!;
    public bool Admin { get; set; }
    public List<Mission> Missions { get; set; } = new List<Mission>();

    // Constructors
    public User() { 
        Status = Status.DISPONIBLE;
        Admin = true;
    }

    public User(string team) {
        Team = team;
        Status = Status.DISPONIBLE;
        Admin = true;
    }

    public User(string pseudo, string password, string firstName, string lastName, string phone, bool car, string team) {
        Pseudo = pseudo;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Car = car;
        Team = team;
        Status = Status.DISPONIBLE;
        Admin = true;
    }

}