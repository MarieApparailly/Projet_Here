namespace Projet_Here.Models;

// Data Transfer Object class, used to bypass navigation properties validation during API calls
public class EnrollmentDTO
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int MissionId { get; set; }
    // status for the user
    public bool Accepted { get; set; } 
    public bool Started { get; set; } 
    public bool Ended { get; set; } 
    public bool NeedHelp { get; set; } 
}