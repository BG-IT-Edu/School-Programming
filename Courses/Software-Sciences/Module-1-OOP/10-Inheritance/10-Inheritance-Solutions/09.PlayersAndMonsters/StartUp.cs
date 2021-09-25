using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string typeHero = Console.ReadLine();
            string heroName = Console.ReadLine();
            int heroLevel = int.Parse(Console.ReadLine());

            switch (typeHero)
            {
                case "Hero":
                    Hero hero = new Hero(heroName, heroLevel);
                    Console.WriteLine(hero);
                    break;
                case "Elf":
                    Elf elf = new Elf(heroName, heroLevel);
                    Console.WriteLine(elf);
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard(heroName, heroLevel);
                    Console.WriteLine(wizard);
                    break;
                case "Knight":
                    Knight knight = new Knight(heroName, heroLevel);
                    Console.WriteLine(knight);
                    break;
                case "MuseElf":
                    MuseElf museElf = new MuseElf(heroName, heroLevel);
                    Console.WriteLine(museElf);
                    break;
                case "DarkWizard":
                    DarkWizard darkWizard = new DarkWizard(heroName, heroLevel);
                    Console.WriteLine(darkWizard);
                    break;
                case "DarkKnight":
                    DarkKnight darkKnight = new DarkKnight(heroName, heroLevel);
                    Console.WriteLine(darkKnight);
                    break;
                case "SoulMaster":
                    SoulMaster soulMaster = new SoulMaster(heroName, heroLevel);
                    Console.WriteLine(soulMaster);
                    break;
                case "BladeKnight":
                    BladeKnight bladeKnight = new BladeKnight(heroName, heroLevel);
                    Console.WriteLine(bladeKnight);
                    break;
            }

        }
        
    }
}