using System;
using System.Linq;
using System.Text;
using System.Globalization;
using Diablo.Data;
using Diablo.Data.Models;

namespace Diablo
{
    public class StartUp
    {
        static void Main()
        {
            DiabloContext context = new DiabloContext();

            Console.WriteLine(UserGamesInformation(context, 10));
            //Console.WriteLine(CharactersInformation(context, 17));
            //Console.WriteLine(GameTypesInformation(context, 5));
        }

        public static string CharactersInformation(DiabloContext context, int luck)
        {
            var charactersInfo = context
                .Characters.ToArray().Where(x => x.Statistic.Luck > luck)
                .Select(x => new
                {
                    CharactersName = x.Name,
                    CountGames = x.UsersGames.Count,
                    Games = x.UsersGames.Select(v => new
                    {
                        GameName = v.Game.Name
                    })
                }).OrderBy(x => x.CountGames)
                .ThenBy(x => x.CharactersName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var character in charactersInfo)
            {
                sb.AppendLine($"Name: {character.CharactersName}");
                sb.AppendLine($"Games: {character.CountGames}");
                foreach (var g in character.Games)
                {
                    sb.AppendLine($"Game name: {g.GameName}");
                }
            }

            return sb.ToString().Trim();
        }

        public static string GameTypesInformation(DiabloContext context, int idGameType)
        {
            var gameTypesInfo = context.GameTypes
                .Where(x => x.Id == idGameType)
                .Select(x => new
                {
                    GameTypeName= x.Name,
                    Games = x.Games.Select(g => new
                    {
                        GameName= g.Name,
                    })
                })
                .OrderBy(x => x.GameTypeName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var gt in gameTypesInfo)
            {
                sb.AppendLine($"Name: {gt.GameTypeName}");
                foreach (var g in gt.Games)
                {
                    sb.AppendLine($"Game name: {g.GameName}");
                }
            }

            return sb.ToString().Trim();
        }
        public static string UserGamesInformation(DiabloContext context, int userId)
        {
            var userInfo = context.UsersGames
                .Where(u => u.UserId == userId)
                .Select(ug => new
                {
                    Game = ug.Game.Name,
                    CharacterName = ug.Character.Name,
                    Items = ug.UserGameItems.Select(ui => new
                    {
                        ItemName = ui.Item.Name
                    })
                })
                .OrderBy(x => x.Items.Count())
                .ThenBy(x => x.Game)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var game in userInfo)
            {
                sb.AppendLine($"Game:{game.Game}");
                sb.AppendLine($"  Character Name: {game.CharacterName}");
                sb.AppendLine($"   Items:");
                foreach (var g in game.Items)
                {
                    sb.AppendLine($"   -{g.ItemName}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
