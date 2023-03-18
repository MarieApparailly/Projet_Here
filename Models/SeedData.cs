using Projet_Here.Data;

namespace Projet_Here.Models;

public class SeedData
{
    public static void Init()
    {
        using (var context = new HereContext())
        {
            // // Look for existing content
            // if (context.Events.Any())
            // {
            //     return;   // DB already filled
            // }

            // Add events
            Event wei = new Event
            {
                Title = "WEI", 
                StartDate = DateTime.Parse("2023-09-29 17:00:00"),
                EndDate = DateTime.Parse("2023-10-01 15:00:00")
            };
            Event manifVss = new Event
            {
                Title = "Manif VSS", 
                Description = "Manifestion contre les Violences Sexistes et Sexuelles, organisée par l'association NousToutes",
                StartDate = DateTime.Parse("2023-11-19 10:00:00"),
                EndDate = DateTime.Parse("2023-11-19 23:59:00"),
            };
            context.Events.AddRange(
                wei,
                manifVss
            );

            // Add users
            User cha = new User
            {
                Pseudo = "Cha";
                Password = "test";
                FirstName = "Charlotte";
                LastName = "Miaou";
                Phone = "0624449999";
                Car = false;
                Group = "NousToutes";
            };
            User luc = new User
            {
                Pseudo = "Lucky";
                Password = "test";
                FirstName = "Luc";
                LastName = "Tanos";
                Phone = "0627834400";
                Car = true;
                Group = "NousToutes";
            };
            User idunn = new User
            {
                Pseudo = "Idunn";
                Password = "test";
                FirstName = "Idunn";
                LastName = "Apparailly";
                Phone = "0666325487";
                Car = false;
                Group = "NousToutes";
            };
            User marie = new User
            {
                Pseudo = "Marie";
                Password = "test";
                FirstName = "Marie";
                LastName = "Apparailly";
                Phone = "0626000001";
                Car = false;
                Group = "NousToutes";
            };
            User marie2 = marie
            {
                Pseudo = "Marie";
                Password = "test";
                Group = "BDE";
            };
            User cycy = new User
            {
                Pseudo = "Cycy";
                Password = "test";
                FirstName = "Cyrielle";
                LastName = "Barbier";
                Phone = "0780322222";
                Car = true;
                Group = "BDE";
            };
            User jo = new User
            {
                Pseudo = "Jo";
                Password = "test";
                FirstName = "Joseph";
                LastName = "Beasse";
                Phone = "060673333";
                Car = false;
                Group = "BDE";
            };
            User clem = new User
            {
                Pseudo = "Clem";
                Password = "test";
                FirstName = "Clémence";
                LastName = "Monnier";
                Phone = "0788889543";
                Car = false;
                Group = "BDE";
            };
            User tiph = new User
            {
                Pseudo = "Tiph";
                Password = "test";
                FirstName = "Tiphaine";
                LastName = "Petit";
                Phone = "0632214455";
                Car = false;
                Group = "BDE";
            };
            User alex = new User
            {
                Pseudo = "Alex";
                Password = "test";
                FirstName = "Alexandra";
                LastName = "Moras";
                Phone = "0666669821";
                Car = true;
                Group = "BDE";
            };
            context.Users.AddRange(
                cha, 
                luc,
                idunn,
                marie,
                marie2,
                cycy,
                jo,
                clem,
                tiph,
                alex                
            );

            // Add missions
            // Mission secu = new Mission 
            // {

            // }

            // Commit changes into DB
            context.SaveChanges();
        }
    }
}