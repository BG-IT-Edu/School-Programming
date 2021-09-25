using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<HeroFactory> heroes = new List<HeroFactory>();
            List<BaseHero> raidGroup = new List<BaseHero>();
            int rotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotation; i++)
            {
                string heroName = Console.ReadLine();
                string heroClass = Console.ReadLine();

                switch (heroClass.ToLower())
                {
                    case "druid":
                        HeroFactory druid = new DruidFactory(heroName);
                        heroes.Add(druid);
                        break;
                    case "paladin":
                        HeroFactory paladin = new PaladinFactory(heroName);
                        heroes.Add(paladin);
                        break;
                    case "rogue":
                        HeroFactory rogue = new RogueFactory(heroName);
                        heroes.Add(rogue);
                        break;
                    case "warrior":
                        HeroFactory warrior = new WarriorFactory(heroName);
                        heroes.Add(warrior);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        i--;
                        break;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalHeroPower = 0;

            foreach (var hero in heroes)
            {
                raidGroup.Add(hero.GetHero());
            }

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }

            foreach (var hero in raidGroup)
            {
                totalHeroPower += hero.Power;
            }

            if (totalHeroPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }

}
