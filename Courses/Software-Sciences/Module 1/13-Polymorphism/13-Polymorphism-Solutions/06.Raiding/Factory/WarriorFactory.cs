namespace Raiding
{
    public class WarriorFactory : HeroFactory
    {
        public WarriorFactory(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override BaseHero GetHero()
        {
            return new Warrior(this.Name);
        }
    }
}
