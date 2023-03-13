namespace Projet_Here.Models;

public class Enrollment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int MissionId { get; set; }
    public User User { get; set; } = null!;
    public Mission Mission { get; set; } = null!;
    public bool Accepted { get; set; } 
    public bool Started { get; set; } 
    public bool Ended { get; set; } 
    public bool NeedHelp { get; set; } 

    // Default (empty) constructor
    public Enrollment() { 
        Accepted = false;
        Started = false;
        Ended = false;
        NeedHelp = false;
    }

    // Copy constructor
    public Enrollment(EnrollmentDTO dto)
    {
        // Copy DTO field values
        Id = dto.Id;
        UserId = dto.UserId;
        MissionId = dto.MissionId;
        Accepted = false;
        Started = false;
        Ended = false;
        NeedHelp = false;
    }
}