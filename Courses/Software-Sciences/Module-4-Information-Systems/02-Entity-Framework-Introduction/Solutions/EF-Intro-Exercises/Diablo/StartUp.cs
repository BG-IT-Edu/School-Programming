using System;
using System.Linq;
using System.Text;
using System.Globalization;
using Diablo.Data;
using Diablo.Models;

namespace Diablo
{
    public class StartUp
    {
        static void Main()
        {
            DiabloContext context = new DiabloContext();
            //Console.WriteLine(GetGamesInformation(context));
            //Console.WriteLine(GetItemsWithPriceOver790(context));
            //Console.WriteLine(GetItemWithTypeAxe(context));
            //Console.WriteLine(AddNewGame(context));
            //Console.WriteLine(GetUsersAndGamesInformation(context));
            //Console.WriteLine(GetUsersGames(context));
            //Console.WriteLine(GetUsersWithMoreThan5Games(context));
            Console.WriteLine(IncreasePrice(context));
        }
        public static string GetGamesInformation(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var games = context.Games
                .Select(x => new
                {
                    x.Name,
                    x.Start,
                    x.Duration,
                    x.IsFinished
                })
                .OrderBy(e => e.Start).ToList();

            foreach (var game in games)
            {
                string finished = "Finished";
                if (game.IsFinished == false)
                {
                    finished = "Unfinished";
                }
                sb.AppendLine($"{game.Name} {game.Start} {game.Duration} {finished}");
            }

            return sb.ToString().Trim();
        }

        public static string GetItemsWithPriceOver790(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var items = context.Items.Where(x => x.Price > 790)
                .Select(x => new
                {
                    x.Name,
                    x.Price
                }
                )
                .OrderBy(e => e.Name).ToList();

            foreach (var item in items)
            {
                sb.AppendLine($"{item.Name} - {item.Price:F2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetItemWithTypeAxe(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var items = context.Items.Where(i => i.ItemType.Name == "Axe").Select(i => new
            {
                i.Name,
                ItemType = i.ItemType.Name,
                i.Price
            })
            .OrderBy(i => i.Price)
            .ThenByDescending(i => i.Name)
            .ToList();

            foreach (var item in items)
            {
                sb.AppendLine($"{item.Name} with type {item.ItemType} - ${item.Price:F2}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string AddNewGame(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();
            GameType gameType = context.GameTypes.FirstOrDefault(g => g.Id == 5);

            Game newGame = new Game()
            {
                Name = "Demo",
                Start = Convert.ToDateTime("2016-02-13 00:00:00.000"),
                Duration = 7,
                GameType = gameType,
                IsFinished = false
            };

            context.Games.Add(newGame);

            context.SaveChanges();

            var tenGames = context
                .Games
                .OrderByDescending(g => g.Id)
                .Take(10)
                .Select(x => x.Name);

            foreach (var game in tenGames)
            {
                sb.AppendLine(game);
            }

            return sb.ToString().Trim();
        }

        public static string GetUsersAndGamesInformation(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var users = context.Users
                .Where(e => e.UsersGames.Any(ep => ep.JoinedOn.Year >= 2013 && ep.JoinedOn.Year <= 2014))
                .Take(10)
                .Select(u => new
                {
                    u.Username,
                    u.FirstName,
                    u.LastName,
                    u.RegistrationDate,
                    GamesOfUser = u.UsersGames
                    .Select(ug => new
                    {
                        GameName = ug.Game.Name,
                        Level = ug.Level,
                        JoinedOnDate = ug.JoinedOn.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                        Duration = ug.Game.Duration.HasValue ?
                                    ug.Game.Duration.Value.ToString() :
                                    "Not finished"
                    }).ToList()
                }).ToList();

            foreach (var u in users)
            {
                sb.AppendLine($"Username:{u.Username} Names: {u.FirstName} {u.LastName} - Registration Date: {u.RegistrationDate}");

                foreach (var gamesUser in u.GamesOfUser)
                {
                    sb.AppendLine($"-- Game: {gamesUser.GameName}, Level: {gamesUser.Level} - {gamesUser.JoinedOnDate}, Duration: {gamesUser.Duration}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetUsersGames(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            var users = context.Users
                .OrderByDescending(x => x.UsersGames.Count())
                .ThenBy(x => x.Username)
                .ThenBy(x => x.FirstName)
                .Select(x => new
                {
                    x.Username,
                    Email = x.Email,
                    GamesCount = x.UsersGames.Count()
                })
                .Take(10)
                .ToList();

            foreach (var u in users)
            {
                sb.AppendLine($"{u.Username}, {u.Email} - {u.GamesCount} games");
            }

            return sb.ToString().Trim();
        }
        public static string GetUsersWithMoreThan5Games(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

                        var users = context.Users
                .Where(c => c.UsersGames.Count > 5)
                .OrderBy(c => c.UsersGames.Count)
                .ThenBy(c => c.Username)
                .Select(c => new
                {
                    Username = c.Username,
                    UsersGamesCount = c.UsersGames.Count

                })
                .ToList();

            foreach (var u in users)
            {
                sb.AppendLine($"Username: {u.Username} - Count Games:{u.UsersGamesCount}");

            }

            return sb.ToString().Trim();
        }

        public static string IncreasePrice(DiabloContext context)
        {
            StringBuilder sb = new StringBuilder();

            IQueryable<Item> items = context.Items
                .Where(e => e.Statistic.Luck == 18 );

            foreach (Item item in items)
            {
                item.Price += item.Price * 0.12M;
            }

            context.SaveChanges();

            var itemsInfo = items.Select(i => new
            {
                i.Name,
                i.Statistic.Speed,
                i.Price
            }).OrderBy(e => e.Name).ThenBy(e => e.Price).ToList();

            foreach (var it in itemsInfo)
            {
                sb.AppendLine($"{it.Name} {it.Speed} (${it.Price:f2})");
            }

            return sb.ToString().Trim();
        }

    }
}
