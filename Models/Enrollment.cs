using Microsoft.AspNetCore.Mvc;
using Projet_Here.Controllers;

namespace Projet_Here.Models;

public class Enrollment
{
    public int Id { get; set; }
    // link User
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    // link Mission
    public int MissionId { get; set; }
    public Mission Mission { get; set; } = null!;
    // infos MissionUser
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

    public Enrollment(User user, Mission mission) {
        UserId = user.Id;
        MissionId = mission.Id;
        user.Missions.Add(mission);
        mission.Users.Add(user);
        Accepted = false;
        Started = false;
        Ended = false;
        NeedHelp = false;
    }

    // // Copy constructor
    // public Enrollment(EnrollmentDTO dto)
    // {
    //     // Copy DTO field values
    //     Id = dto.Id;
    //     UserId = dto.UserId;
    //     MissionId = dto.MissionId;
    //     Accepted = false;
    //     Started = false;
    //     Ended = false;
    //     NeedHelp = false;
    // }

    public void UserMission(User user, Mission mission) {

        
    }
}