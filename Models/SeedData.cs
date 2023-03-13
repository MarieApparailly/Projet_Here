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
            context.Events.AddRange(3
                wei,
                manifVss
            );

            // // Add users
            // var abercrombie = new Instructor
            // {
            //     FirstName = "Kim",
            //     LastName = "Abercrombie",
            //     HireDate = DateTime.Parse("1995-03-11")
            // };

            // // Add missions
            // var mathematics = new Department
            // {
            //     Name = "Mathematics",
            //     Administrator = fakhouri
            // };

            // // Add places
            // Course chemistry = new Course
            // {
            //     Id = 1050,
            //     Title = "Chemistry",
            //     Credits = 3,
            //     Department = engineering,
            //     Instructors = new List<Instructor> { abercrombie, harui }
            // };
            
            // context.Courses.AddRange(
            //     chemistry,
            //     microeconomics,
            //     macroeconmics,
            //     calculus
            // );

            // // Add enrollments
            // context.Enrollments.AddRange(
            //     new Enrollment
            //     {
            //         Student = carson,
            //         Course = chemistry,
            //         Grade = Grade.A
            //     },
            //     new Enrollment
            //     {
            //         Student = carson,
            //         Course = microeconomics,
            //         Grade = Grade.C
            //     },
            //     new Enrollment
            //     {
            //         Student = alonso,
            //         Course = calculus,
            //         Grade = Grade.B
            //     },
            //     new Enrollment
            //     {
            //         Student = anand,
            //         Course = chemistry,
            //     },
            //     new Enrollment
            //     {
            //         Student = anand,
            //         Course = microeconomics,
            //         Grade = Grade.B
            //     },
            //     new Enrollment
            //     {
            //         Student = barzdukas,
            //         Course = chemistry,
            //         Grade = Grade.C
            //     }
            // );

            // Commit changes into DB
            context.SaveChanges();
        }
    }
}