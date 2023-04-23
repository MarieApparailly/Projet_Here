using Projet_Here.Data;

namespace Projet_Here.Models;

public class SeedData
{
    public static void Init()
    {
        using (var context = new HereContext())
        {
            // Look for existing content
            if (context.Events.Any())
            {
                return;   // DB already filled
            }

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
                Pseudo = "Cha",
                Password = "test",
                FirstName = "Charlotte",
                LastName = "Miaou",
                Phone = "0624449999",
                Car = false,
                Team = "NousToutes"
            };
            User luc = new User
            {
                Pseudo = "Lucky",
                Password = "test",
                FirstName = "Luc",
                LastName = "Tanos",
                Phone = "0627834400",
                Car = true,
                Team = "NousToutes"
            };
            User idunn = new User
            {
                Pseudo = "Idunn",
                Password = "test",
                FirstName = "Idunn",
                LastName = "Apparailly",
                Phone = "0666325487",
                Car = false,
                Team = "NousToutes"
            };
            User marie = new User
            {
                Pseudo = "Marie",
                Password = "test",
                FirstName = "Marie",
                LastName = "Apparailly",
                Phone = "0626000001",
                Car = false,
                Team = "NousToutes"
            };
            User marie2 = new User
            {
                Pseudo = "Marie",
                Password = "test",
                FirstName = "Marie",
                LastName = "Apparailly",
                Phone = "0626000001",
                Car = false,
                Team = "BDE"
            };
            User cycy = new User
            {
                Pseudo = "Cycy",
                Password = "test",
                FirstName = "Cyrielle",
                LastName = "Barbier",
                Phone = "0780322222",
                Car = true,
                Team = "BDE"
            };
            User jo = new User
            {
                Pseudo = "Jo",
                Password = "test",
                FirstName = "Joseph",
                LastName = "Beasse",
                Phone = "060673333",
                Car = false,
                Team = "BDE"
            };
            User clem = new User
            {
                Pseudo = "Clem",
                Password = "test",
                FirstName = "Clémence",
                LastName = "Monnier",
                Phone = "0788889543",
                Car = false,
                Team = "BDE"
            };
            User tiph = new User
            {
                Pseudo = "Tiph",
                Password = "test",
                FirstName = "Tiphaine",
                LastName = "Petit",
                Phone = "0632214455",
                Car = false,
                Team = "BDE"
            };
            User alex = new User
            {
                Pseudo = "Alex",
                Password = "test",
                FirstName = "Alexandra",
                LastName = "Moras",
                Phone = "0666669821",
                Car = true,
                Team = "BDE"
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

            //Add places
            Place ensc = new Place 
            {
                Name = "ENSC",
                City = "Talence",
                Description = "Ecole Nationale Supérieure de Cognitique"
            };
            Place parking = new Place 
            {
                Name = "Parking Arts&Métiers",
                City = "Talence",
            };
            Place bt = new Place 
            {
                Name = "BT",
                City = "Bordeaux",
                Description = "Bar partenaire du BDE de l'ENSC"
            };
            Place camping = new Place 
            {
                Name = "Camping Le Lac",
                City = "Mimizan"
            };
            Place carrefour = new Place 
            {
                Name = "Carrefour",
                City = "Bordeaux"
            };
            Place victoire = new Place 
            {
                Name = "Place de la victoire",
                City = "Bordeaux"
            };
            Place qgAsso = new Place 
            {
                Name = "Local NousToutes",
                City = "Bordeaux"
            };
            Place maisonFemmes = new Place 
            {
                Name = "La maison des femmes",
                City = "Bordeaux",
                Description = "Association bénévole bordelaise pour l'acceuil des femmes victimes de violences"
            };
            Place palaisJustice = new Place 
            {
                Name = "Palais de Justice",
                City = "Bordeaux"
            };
            context.Places.AddRange(
                ensc,
                parking,
                bt,
                camping,
                carrefour,
                maisonFemmes,
                palaisJustice           
            );

            //Add missions
            Mission pancartes = new Mission 
            {
                Event = manifVss,
                Place = qgAsso,
                Title = "Fabriquer des pancartes",
                StartDate = DateTime.Parse("2023-11-18 18:30:00")
            };
            Mission circuit = new Mission 
            {
                Event = manifVss,
                Title = "Définir circuit",
            };
            Mission marche = new Mission 
            {
                Event = manifVss,
                Place = qgAsso,
                Title = "Début de la marche",
                StartDate = DateTime.Parse("2023-11-19 14:00:00")
            };
            Mission discoursAsso = new Mission 
            {
                Event = manifVss,
                Place = maisonFemmes,
                Title = "Discours actions de l'asso",
                StartDate = DateTime.Parse("2023-11-19 14:45:00")
            };
            Mission discoursLoi = new Mission 
            {
                Event = manifVss,
                Place = palaisJustice,
                Title = "Discours loi VSS",
                StartDate = DateTime.Parse("2023-11-19 15:30:00"),
                Description = "Discours sur le projet de loi de la nouvelle ministre avec plusieurs intervenants"
            };
            Mission secu = new Mission 
            {
                Event = manifVss,
                Title = "Sécurité",
                StartDate = DateTime.Parse("2023-11-19 13:00:00")
            };
            Mission debrief = new Mission 
            {
                Event = manifVss,
                Place = qgAsso,
                Title = "Debrief manif",
                StartDate = DateTime.Parse("2023-11-19 20:00:00")
            };
            Mission courses = new Mission 
            {
                Event = wei,
                Place = carrefour,
                Title = "Faire les courses",
                StartDate = DateTime.Parse("2023-09-27 17:00:00")
            };
            Mission appelSecours = new Mission 
            {
                Event = wei,
                Title = "Appel secours",
                Description = "Appeler tous les organismes et assos de sauvetage et de secourisme listés sur le sheet dans le dossier wei du drive"
            };
            Mission stand = new Mission 
            {
                Event = wei,
                Title = "Tenir le stand",
                Description = "Dernier stand de paiement pour le wei",
                StartDate = DateTime.Parse("2023-09-10 12:15:00")
            };
            Mission bus = new Mission 
            {
                Event = wei,
                Place = parking,
                Title = "Charger les bus",
                StartDate = DateTime.Parse("2023-09-29 15:30:00")
            };
            Mission depart = new Mission 
            {
                Event = wei,
                Place = parking,
                Title = "Départ de l'école",
                StartDate = DateTime.Parse("2023-09-29 16:15:00")
            };
            Mission reu = new Mission 
            {
                Event = wei,
                Place = bt,
                Title = "Réunion/bar teambuilding",
                Description = "Un verre tous ensemble avant le jour J",
                StartDate = DateTime.Parse("2023-09-28 18:00:00")
            };
            Mission mobilhome = new Mission 
            {
                Event = wei,
                Title = "Répartition mobilhomes",
                Place = camping,
                Description = "Répartir et guider les étudiants vers leurs mobilhomes : groupe et numéro de mobilhomes dans le 2eme onglet du sheet",
                StartDate = DateTime.Parse("2023-09-29 18:00:00")
            };
            Mission sheet = new Mission 
            {
                Event = wei,
                Title = "Faire sheet bar",
                Description = "Créer un sheet pour les stocks de boissons du bar",
            };
            Mission repas = new Mission 
            {
                Event = wei,
                Title = "Repas",
                Place = camping,
                StartDate = DateTime.Parse("2023-09-29 19:00:00")
            };
            Mission deco = new Mission 
            {
                Event = wei,
                Title = "Décorer la salle",
                Place = camping,
                StartDate = DateTime.Parse("2023-09-29 18:30:00")
            };
            Mission cocktails = new Mission 
            {
                Event = wei,
                Title = "Faire les cocktails",
                Place = camping,
                StartDate = DateTime.Parse("2023-09-29 18:30:00")
            };
            Mission tireuse = new Mission 
            {
                Event = wei,
                Title = "Installer la tireuse",
                Place = camping,
                StartDate = DateTime.Parse("2023-09-29 18:00:00")
            };
            Mission soiree = new Mission 
            {
                Event = wei,
                Title = "Soiréej1",
                Place = camping,
                StartDate = DateTime.Parse("2023-09-29 20:30:00")
            };
            context.Missions.AddRange(
                pancartes,
                circuit,
                marche,
                discoursAsso,
                discoursLoi,
                secu,
                debrief,
                courses,
                appelSecours,    
                stand,
                bus,
                depart,
                reu,
                mobilhome,
                sheet,
                repas,
                deco,
                cocktails,
                tireuse,
                soiree      
            );


            // Add enrollments
            Enrollment marieTireuse = new Enrollment
            {
                User = marie2,
                Mission = tireuse,
                Accepted = true,
            };
            Enrollment marieAppel = new Enrollment
            {
                User = marie2,
                Mission = appelSecours,
                Accepted = true,
                Started = true,
                Ended = true,
            };
            Enrollment cycyCocktails = new Enrollment
            {
                User = cycy,
                Mission = cocktails,
                Accepted = true,
            };
            Enrollment clemCocktails = new Enrollment
            {
                User = clem,
                Mission = cocktails,
            };
            Enrollment tiphCocktails = new Enrollment
            {
                User = tiph,
                Mission = cocktails,
            };
            Enrollment alexDeco = new Enrollment
            {
                User = alex,
                Mission = deco,
                Accepted = true,
                Started = true,
                NeedHelp = true
            };
            Enrollment joMobilhome = new Enrollment
            {
                User = jo,
                Mission = mobilhome,
            };
            Enrollment lucCircuit = new Enrollment
            {
                User = luc,
                Mission = circuit,
                Accepted = true,
                Started = true,
                Ended = true,
            };
            Enrollment marie2DiscoursA = new Enrollment
            {
                User = marie2,
                Mission = discoursAsso,
            };
            Enrollment marie2Pancartes = new Enrollment
            {
                User = marie2,
                Mission = appelSecours,
                Accepted = true,
                Started = true,
            };
            Enrollment marieDiscoursA = new Enrollment
            {
                User = marie,
                Mission = discoursAsso,
            };
            Enrollment mariePancartes = new Enrollment
            {
                User = marie,
                Mission = pancartes,
                Accepted = true,
            };
            Enrollment idunnPancartes = new Enrollment
            {
                User = idunn,
                Mission = pancartes,
                Accepted = true,
                Started = true,
                NeedHelp = true
            };
            Enrollment idunnSecu = new Enrollment
            {
                User = idunn,
                Mission = secu,
                Accepted = true,
            };
            Enrollment lucSecu = new Enrollment
            {
                User = luc,
                Mission = secu,
            };
            Enrollment chaDiscoursL = new Enrollment
            {
                User = cha,
                Mission = discoursLoi,
            };
            context.Enrollments.AddRange(
                marieTireuse,
                marieAppel,
                cycyCocktails,
                tiphCocktails,
                clemCocktails,
                alexDeco,
                joMobilhome,
                lucCircuit,
                lucSecu,
                marieDiscoursA,
                mariePancartes,
                marie2DiscoursA,
                marie2Pancartes,
                idunnPancartes,
                idunnSecu,
                chaDiscoursL 
            );

            // Add list missions in user
            IEnumerable<Mission> missionsMarie2 = new List<Mission>{
                pancartes,
                discoursAsso,
                appelSecours,    
                tireuse};
            marie2.Missions.AddRange(missionsMarie2);
            IEnumerable<Mission> missionsMarie = new List<Mission>{
                pancartes,
                discoursAsso};
            marie.Missions.AddRange(missionsMarie);
            IEnumerable<Mission> missionsClem = new List<Mission>{
                cocktails};
            clem.Missions.AddRange(missionsClem);
            IEnumerable<Mission> missionsCy = new List<Mission>{
                cocktails};
            cycy.Missions.AddRange(missionsCy);
            IEnumerable<Mission> missionsTiph = new List<Mission>{
                cocktails};
            tiph.Missions.AddRange(missionsTiph);
            IEnumerable<Mission> missionsAlex = new List<Mission>{
                deco};
            alex.Missions.AddRange(missionsAlex);
            IEnumerable<Mission> missionsJo = new List<Mission>{
                mobilhome};
            jo.Missions.AddRange(missionsJo);
            IEnumerable<Mission> missionsLuc = new List<Mission>{
                secu,
                circuit};
            luc.Missions.AddRange(missionsLuc);
            IEnumerable<Mission> missionsIdunn = new List<Mission>{
                pancartes,
                secu};
            idunn.Missions.AddRange(missionsIdunn);
            IEnumerable<Mission> missionsCha = new List<Mission>{
                discoursLoi};
            cha.Missions.AddRange(missionsCha);

            // Add list users in mission
            IEnumerable<User> usersTireuse = new List<User>{
                marie2};
            tireuse.Users.AddRange(usersTireuse);
            IEnumerable<User> usersAppel = new List<User>{
                marie2};
            appelSecours.Users.AddRange(usersAppel);
            IEnumerable<User> usersCocktail = new List<User>{
                clem,
                cycy,
                tiph};
            cocktails.Users.AddRange(usersCocktail);
            IEnumerable<User> usersDeco = new List<User>{
                alex};
            deco.Users.AddRange(usersDeco);
            IEnumerable<User> usersMobilhome = new List<User>{
                jo};
            mobilhome.Users.AddRange(usersMobilhome);
            IEnumerable<User> usersCircuit = new List<User>{
                luc};
            circuit.Users.AddRange(usersCircuit);
            IEnumerable<User> usersDiscoursA = new List<User>{
                marie,
                marie2};
            discoursAsso.Users.AddRange(usersDiscoursA);
            IEnumerable<User> usersPancartes = new List<User>{
                marie,
                marie2,
                idunn};
            pancartes.Users.AddRange(usersPancartes);
            IEnumerable<User> usersSecu = new List<User>{
                luc,
                idunn};
            secu.Users.AddRange(usersSecu);
            IEnumerable<User> usersDiscoursL = new List<User>{
                cha};
            discoursLoi.Users.AddRange(usersDiscoursL);

            // Commit changes into DB
            context.SaveChanges();
        }
    }
}