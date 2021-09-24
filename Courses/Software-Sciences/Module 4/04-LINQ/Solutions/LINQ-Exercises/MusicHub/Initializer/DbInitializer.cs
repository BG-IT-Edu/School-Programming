namespace MusicHub.Initializer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Microsoft.EntityFrameworkCore;

    using Data;
    using Data.Models;

    public class DbInitializer
    {
        public static void ResetDatabase(MusicHubDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Console.WriteLine("MusicHub database created successfully.");

            Seed(context);
        }

        private static void Seed(MusicHubDbContext context)
        {
            var datasetsJson =
            "{\"Writer\":[{\"Id\":1,\"Name\":\"Mik Jonathan\",\"Pseudonym\":\"The Mik\"},{\"Id\":2,\"Name\":\"Maitilde Sangar\",\"Pseudonym\":\"Dilly Marjoram\"},{\"Id\":3,\"Name\":\"Linnie Petrolli\",\"Pseudonym\":\"Teodorico Skyppe\"},{\"Id\":4,\"Name\":\"Bili Franek\",\"Pseudonym\":\"Cornelius Cranson\"},{\"Id\":5,\"Name\":\"Quillan Grover\",\"Pseudonym\":null},{\"Id\":6,\"Name\":\"Tiebout Standall\",\"Pseudonym\":\"Ransom Siemens\"},{\"Id\":7,\"Name\":\"Chloe Trayhorn\",\"Pseudonym\":\"Jonie Driscoll\"},{\"Id\":8,\"Name\":\"Holly Coppen\",\"Pseudonym\":null},{\"Id\":9,\"Name\":\"Chelsy Pennyman\",\"Pseudonym\":\"Roberto Fullard\"},{\"Id\":10,\"Name\":\"Sibelle Hanton\",\"Pseudonym\":null},{\"Id\":11,\"Name\":\"Rosalyn Humphris\",\"Pseudonym\":\"Melesa Sussems\"},{\"Id\":12,\"Name\":\"Marlee Olivet\",\"Pseudonym\":\"Alyda Blundel\"},{\"Id\":13,\"Name\":\"Carol Mitchell\",\"Pseudonym\":\"Fannie Davenhill\"},{\"Id\":14,\"Name\":\"Jessie Townby\",\"Pseudonym\":null},{\"Id\":15,\"Name\":\"Stanford Daykin\",\"Pseudonym\":\"Erny Wiggam\"},{\"Id\":16,\"Name\":\"Kara-lynn Sharpous\",\"Pseudonym\":\"Devina Abatelli\"},{\"Id\":17,\"Name\":\"Verine Eschalotte\",\"Pseudonym\":\"Blair Chilton\"},{\"Id\":18,\"Name\":\"Padget Steptowe\",\"Pseudonym\":\"Loise Topp\"},{\"Id\":19,\"Name\":\"Gleda Messum\",\"Pseudonym\":\"Nonie Beadell\"},{\"Id\":20,\"Name\":\"Lusa Steers\",\"Pseudonym\":\"Granny Hyndley\"},{\"Id\":21,\"Name\":\"Petko Matisse\",\"Pseudonym\":\"Michaelina Liffe\"},{\"Id\":22,\"Name\":\"Norina Renihan\",\"Pseudonym\":\"Valentin Lorenc\"},{\"Id\":23,\"Name\":\"Kizzie Hoyle\",\"Pseudonym\":\"Karlik Lillistone\"}],\"Producer\":[{\"Id\":1,\"Name\":\"Ab Pittham\",\"Pseudonym\":null,\"PhoneNumber\":null},{\"Id\":2,\"Name\":\"Georgi Milkov\",\"Pseudonym\":\"Gosho Goshev\",\"PhoneNumber\":\"+359 899 345 045\"},{\"Id\":3,\"Name\":\"Jana Karaivanova\",\"Pseudonym\":\"Jani Gog\",\"PhoneNumber\":null},{\"Id\":4,\"Name\":\"Evtim Miloshev\",\"Pseudonym\":\"Evo Mils\",\"PhoneNumber\":\"+359 567 234 345\"},{\"Id\":5,\"Name\":\"Dobromir Slavchev\",\"Pseudonym\":\"Doba Dog\",\"PhoneNumber\":\"+359 353 355 789\"},{\"Id\":6,\"Name\":\"Denney Allott\",\"Pseudonym\":null,\"PhoneNumber\":null},{\"Id\":7,\"Name\":\"F.O.\",\"Pseudonym\":\"Rancell Caughey\",\"PhoneNumber\":\"+359 343 244 797\"},{\"Id\":8,\"Name\":\"Rolph Nibley\",\"Pseudonym\":\"Rea Netley\",\"PhoneNumber\":\"+359 343 234 454\"},{\"Id\":9,\"Name\":\"Evgeni Dimitrov\",\"Pseudonym\":\"Evgeni Maestroto\",\"PhoneNumber\":\"+359 456 244 321\"}],\"Album\":[{\"Id\":1,\"Name\":\"Fight and flight\",\"ReleaseDate\":\"2018-11-05T00:00:00\",\"Price\":23.24,\"ProducerId\":2},{\"Id\":2,\"Name\":\"Cherry\",\"ReleaseDate\":\"2018-06-09T00:00:00\",\"Price\":27.288,\"ProducerId\":2},{\"Id\":3,\"Name\":\"No history\",\"ReleaseDate\":\"2019-03-05T00:00:00\",\"Price\":36.5577,\"ProducerId\":2},{\"Id\":4,\"Name\":\"Blinded by fame\",\"ReleaseDate\":\"2018-12-12T00:00:00\",\"Price\":22.2768,\"ProducerId\":3},{\"Id\":5,\"Name\":\"Barrage of noise\",\"ReleaseDate\":\"2018-07-03T00:00:00\",\"Price\":31.583,\"ProducerId\":4},{\"Id\":6,\"Name\":\"The fat lady sings\",\"ReleaseDate\":\"2018-06-01T00:00:00\",\"Price\":7,\"ProducerId\":4},{\"Id\":7,\"Name\":\"Zero gravity\",\"ReleaseDate\":\"2019-08-05T00:00:00\",\"Price\":11.9452,\"ProducerId\":4},{\"Id\":8,\"Name\":\"Hit the road\",\"ReleaseDate\":\"2019-07-03T00:00:00\",\"Price\":29.016,\"ProducerId\":5},{\"Id\":9,\"Name\":\"Louder actions\",\"ReleaseDate\":\"2019-06-01T00:00:00\",\"Price\":9.1649,\"ProducerId\":5},{\"Id\":10,\"Name\":\"Don't Step to This\",\"ReleaseDate\":\"2018-07-01T00:00:00\",\"Price\":23.3699,\"ProducerId\":7},{\"Id\":11,\"Name\":\"Rap Time\",\"ReleaseDate\":\"2019-06-06T00:00:00\",\"Price\":19.5746,\"ProducerId\":7},{\"Id\":12,\"Name\":\"Game on\",\"ReleaseDate\":\"2018-07-03T00:00:00\",\"Price\":3.5,\"ProducerId\":8},{\"Id\":13,\"Name\":\"Two to tango\",\"ReleaseDate\":\"2018-04-03T00:00:00\",\"Price\":25.4087,\"ProducerId\":9},{\"Id\":14,\"Name\":\"Flower shower\",\"ReleaseDate\":\"2018-07-17T00:00:00\",\"Price\":38.0394,\"ProducerId\":9},{\"Id\":15,\"Name\":\"Devil's advocate\",\"ReleaseDate\":\"2018-07-21T00:00:00\",\"Price\":40.4854,\"ProducerId\":9},{\"Id\":16,\"Name\":\"Dark matters\",\"ReleaseDate\":\"2018-07-22T00:00:00\",\"Price\":11.99,\"ProducerId\":9}],\"Song\":[{\"Id\":1,\"Name\":\"What Goes Around\",\"Duration\":\"00:03:23\",\"CreatedOn\":\"2018-12-21T00:00:00\",\"Genre\":0,\"AlbumId\":2,\"WriterId\":2,\"Price\":12},{\"Id\":2,\"Name\":\"Cough Relief\",\"Duration\":\"00:10:34\",\"CreatedOn\":\"2018-06-03T00:00:00\",\"Genre\":3,\"AlbumId\":14,\"WriterId\":14,\"Price\":25.0394},{\"Id\":3,\"Name\":\"Levothyroxine Sodium\",\"Duration\":\"00:10:41\",\"CreatedOn\":\"2018-12-21T00:00:00\",\"Genre\":2,\"AlbumId\":13,\"WriterId\":13,\"Price\":16.4187},{\"Id\":4,\"Name\":\"Medique Diphen\",\"Duration\":\"00:09:31\",\"CreatedOn\":\"2018-09-24T00:00:00\",\"Genre\":1,\"AlbumId\":11,\"WriterId\":11,\"Price\":19.5746},{\"Id\":5,\"Name\":\"Hydralazine Hydroch\",\"Duration\":\"00:09:54\",\"CreatedOn\":\"2018-09-19T00:00:00\",\"Genre\":0,\"AlbumId\":10,\"WriterId\":10,\"Price\":23.3699},{\"Id\":6,\"Name\":\"rx act pain relief\",\"Duration\":\"00:03:39\",\"CreatedOn\":\"2018-03-06T00:00:00\",\"Genre\":1,\"AlbumId\":9,\"WriterId\":9,\"Price\":5.186},{\"Id\":7,\"Name\":\"Crayola Wild Blue\",\"Duration\":\"00:01:58\",\"CreatedOn\":\"2018-02-21T00:00:00\",\"Genre\":3,\"AlbumId\":8,\"WriterId\":8,\"Price\":17.516},{\"Id\":8,\"Name\":\"Carvedilol\",\"Duration\":\"00:02:39\",\"CreatedOn\":\"2018-02-13T00:00:00\",\"Genre\":4,\"AlbumId\":7,\"WriterId\":7,\"Price\":2.9452},{\"Id\":9,\"Name\":\"Water Additive\",\"Duration\":\"00:02:33\",\"CreatedOn\":\"2018-08-08T00:00:00\",\"Genre\":4,\"AlbumId\":5,\"WriterId\":5,\"Price\":11.0343},{\"Id\":10,\"Name\":\"Kids SPF 60\",\"Duration\":\"00:01:17\",\"CreatedOn\":\"2018-12-24T00:00:00\",\"Genre\":3,\"AlbumId\":4,\"WriterId\":4,\"Price\":8.7768},{\"Id\":11,\"Name\":\"Quinapril\",\"Duration\":\"00:10:31\",\"CreatedOn\":\"2018-06-01T00:00:00\",\"Genre\":2,\"AlbumId\":3,\"WriterId\":3,\"Price\":28.0577},{\"Id\":12,\"Name\":\"La Vaquita\",\"Duration\":\"00:08:32\",\"CreatedOn\":\"2018-12-11T00:00:00\",\"Genre\":1,\"AlbumId\":2,\"WriterId\":2,\"Price\":8.788},{\"Id\":13,\"Name\":\"Bentasil\",\"Duration\":\"00:04:03\",\"CreatedOn\":\"2018-07-30T00:00:00\",\"Genre\":0,\"AlbumId\":9,\"WriterId\":1,\"Price\":3.9789},{\"Id\":14,\"Name\":\"Don't call me up\",\"Duration\":\"00:05:20\",\"CreatedOn\":\"2015-09-12T00:00:00\",\"Genre\":4,\"AlbumId\":8,\"WriterId\":14,\"Price\":5},{\"Id\":15,\"Name\":\"Cry Me A River\",\"Duration\":\"00:04:20\",\"CreatedOn\":\"2016-09-18T00:00:00\",\"Genre\":4,\"AlbumId\":7,\"WriterId\":16,\"Price\":9},{\"Id\":16,\"Name\":\"Wait For A Minute\",\"Duration\":\"00:04:20\",\"CreatedOn\":\"2016-09-21T00:00:00\",\"Genre\":0,\"AlbumId\":6,\"WriterId\":17,\"Price\":7},{\"Id\":17,\"Name\":\"Just the two of us\",\"Duration\":\"00:02:40\",\"CreatedOn\":\"2011-09-05T00:00:00\",\"Genre\":1,\"AlbumId\":5,\"WriterId\":18,\"Price\":7},{\"Id\":18,\"Name\":\"Personal\",\"Duration\":\"00:02:40\",\"CreatedOn\":\"2011-09-05T00:00:00\",\"Genre\":2,\"AlbumId\":4,\"WriterId\":19,\"Price\":3.5},{\"Id\":19,\"Name\":\"Ride it\",\"Duration\":\"00:04:35\",\"CreatedOn\":\"2011-03-05T00:00:00\",\"Genre\":4,\"AlbumId\":3,\"WriterId\":20,\"Price\":8.5},{\"Id\":20,\"Name\":\"Say It Right\",\"Duration\":\"00:04:35\",\"CreatedOn\":\"2011-06-05T00:00:00\",\"Genre\":3,\"AlbumId\":2,\"WriterId\":21,\"Price\":6.5},{\"Id\":21,\"Name\":\"Away\",\"Duration\":\"00:05:35\",\"CreatedOn\":\"2008-06-03T00:00:00\",\"Genre\":2,\"AlbumId\":1,\"WriterId\":22,\"Price\":7.5},{\"Id\":22,\"Name\":\"Tiempo\",\"Duration\":\"00:05:35\",\"CreatedOn\":\"2008-06-03T00:00:00\",\"Genre\":2,\"AlbumId\":1,\"WriterId\":22,\"Price\":7.5},{\"Id\":23,\"Name\":\"In the end\",\"Duration\":\"00:02:11\",\"CreatedOn\":\"2006-09-03T00:00:00\",\"Genre\":3,\"AlbumId\":16,\"WriterId\":17,\"Price\":11.99},{\"Id\":24,\"Name\":\"Numb\",\"Duration\":\"00:04:11\",\"CreatedOn\":\"2002-09-03T00:00:00\",\"Genre\":3,\"AlbumId\":15,\"WriterId\":16,\"Price\":13.99},{\"Id\":25,\"Name\":\"It is my life\",\"Duration\":\"00:06:11\",\"CreatedOn\":\"2001-11-03T00:00:00\",\"Genre\":3,\"AlbumId\":14,\"WriterId\":15,\"Price\":13},{\"Id\":26,\"Name\":\"Wide Awake\",\"Duration\":\"00:04:11\",\"CreatedOn\":\"2014-11-03T00:00:00\",\"Genre\":0,\"AlbumId\":13,\"WriterId\":12,\"Price\":8.99},{\"Id\":27,\"Name\":\"In the start\",\"Duration\":\"00:03:15\",\"CreatedOn\":\"2016-08-08T00:00:00\",\"Genre\":2,\"AlbumId\":12,\"WriterId\":11,\"Price\":3.5},{\"Id\":28,\"Name\":\"Lose Yourself\",\"Duration\":\"00:03:30\",\"CreatedOn\":\"2016-08-01T00:00:00\",\"Genre\":3,\"AlbumId\":8,\"WriterId\":9,\"Price\":6.5},{\"Id\":29,\"Name\":\"River\",\"Duration\":\"00:03:10\",\"CreatedOn\":\"2018-12-01T00:00:00\",\"Genre\":2,\"AlbumId\":1,\"WriterId\":5,\"Price\":8.24},{\"Id\":30,\"Name\":\"Morning After\",\"Duration\":\"00:04:23\",\"CreatedOn\":\"2007-12-21T00:00:00\",\"Genre\":1,\"AlbumId\":4,\"WriterId\":3,\"Price\":10},{\"Id\":31,\"Name\":\"Ibuprofen\",\"Duration\":\"00:01:04\",\"CreatedOn\":\"2018-02-22T00:00:00\",\"Genre\":4,\"AlbumId\":15,\"WriterId\":15,\"Price\":26.4954},{\"Id\":32,\"Name\":\"Dorzolamide HCl\",\"Duration\":\"00:02:50\",\"CreatedOn\":\"2018-03-22T00:00:00\",\"Genre\":1,\"AlbumId\":5,\"WriterId\":22,\"Price\":13.5487}],\"Performer\":[{\"Id\":1,\"FirstName\":\"Peter\",\"LastName\":\"Bree\",\"Age\":25,\"NetWorth\":3243},{\"Id\":2,\"FirstName\":\"Gennifer\",\"LastName\":\"Lopez\",\"Age\":38,\"NetWorth\":5531},{\"Id\":3,\"FirstName\":\"Tine\",\"LastName\":\"Althorp\",\"Age\":35,\"NetWorth\":1184},{\"Id\":4,\"FirstName\":\"Gilligan\",\"LastName\":\"Caney\",\"Age\":50,\"NetWorth\":5211},{\"Id\":5,\"FirstName\":\"Zabrina\",\"LastName\":\"Amor\",\"Age\":62,\"NetWorth\":8921},{\"Id\":6,\"FirstName\":\"Georgia\",\"LastName\":\"Winchurch\",\"Age\":21,\"NetWorth\":5072},{\"Id\":7,\"FirstName\":\"Dasi\",\"LastName\":\"Pirrey\",\"Age\":26,\"NetWorth\":5913},{\"Id\":8,\"FirstName\":\"Lula\",\"LastName\":\"Zuan\",\"Age\":19,\"NetWorth\":9558},{\"Id\":9,\"FirstName\":\"Alidia\",\"LastName\":\"Horsewood\",\"Age\":19,\"NetWorth\":2499},{\"Id\":10,\"FirstName\":\"Rhody\",\"LastName\":\"Bettam\",\"Age\":19,\"NetWorth\":8013},{\"Id\":11,\"FirstName\":\"Livia\",\"LastName\":\"Baddoe\",\"Age\":18,\"NetWorth\":6699},{\"Id\":12,\"FirstName\":\"Perl\",\"LastName\":\"Pruvost\",\"Age\":19,\"NetWorth\":9114}],\"SongPerformer\":[{\"SongId\":1,\"PerformerId\":1},{\"SongId\":2,\"PerformerId\":1},{\"SongId\":3,\"PerformerId\":2},{\"SongId\":4,\"PerformerId\":2},{\"SongId\":5,\"PerformerId\":2},{\"SongId\":5,\"PerformerId\":10},{\"SongId\":5,\"PerformerId\":11},{\"SongId\":6,\"PerformerId\":3},{\"SongId\":6,\"PerformerId\":10},{\"SongId\":6,\"PerformerId\":11},{\"SongId\":7,\"PerformerId\":3},{\"SongId\":7,\"PerformerId\":10},{\"SongId\":7,\"PerformerId\":11},{\"SongId\":8,\"PerformerId\":3},{\"SongId\":8,\"PerformerId\":10},{\"SongId\":9,\"PerformerId\":4},{\"SongId\":9,\"PerformerId\":10},{\"SongId\":10,\"PerformerId\":4},{\"SongId\":10,\"PerformerId\":10},{\"SongId\":11,\"PerformerId\":4},{\"SongId\":12,\"PerformerId\":5},{\"SongId\":13,\"PerformerId\":5},{\"SongId\":14,\"PerformerId\":6},{\"SongId\":15,\"PerformerId\":6},{\"SongId\":16,\"PerformerId\":7},{\"SongId\":17,\"PerformerId\":7},{\"SongId\":18,\"PerformerId\":8},{\"SongId\":19,\"PerformerId\":8},{\"SongId\":20,\"PerformerId\":8},{\"SongId\":21,\"PerformerId\":8},{\"SongId\":22,\"PerformerId\":8},{\"SongId\":23,\"PerformerId\":8},{\"SongId\":23,\"PerformerId\":12},{\"SongId\":24,\"PerformerId\":9},{\"SongId\":24,\"PerformerId\":12},{\"SongId\":25,\"PerformerId\":9},{\"SongId\":25,\"PerformerId\":12},{\"SongId\":26,\"PerformerId\":9},{\"SongId\":27,\"PerformerId\":9},{\"SongId\":28,\"PerformerId\":9},{\"SongId\":29,\"PerformerId\":9}]}";

            var datasets = JsonConvert.DeserializeObject<Dictionary<string, IEnumerable<JObject>>>(datasetsJson);

            foreach (var dataset in datasets)
            {
                var entityType = GetType(dataset.Key);

                using (var transaction = context.Database.BeginTransaction())
                {
                    var entities = dataset.Value
                        .Select(j => j.ToObject(entityType))
                        .ToArray();
                    var entityName = $"{entityType.Name}s";
                    context.AddRange(entities);

                    if (entityType != typeof(SongPerformer))
                    {
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + entityName + " ON;");
                    }

                    context.SaveChanges();

                    if (entityType != typeof(SongPerformer))
                    {
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + entityName + "  OFF;");
                    }
                    transaction.Commit();
                }
            }
        }

        private static Type GetType(string modelName)
        {
            var modelType = Assembly
                .GetEntryAssembly()?
                .GetTypes()
                .FirstOrDefault(t => t.Name == modelName);

            return modelType;
        }
    }
}
