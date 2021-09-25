namespace Raiding
{
    public class RogueFactory : HeroFactory
    {
        public RogueFactory(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override BaseHero GetHero()
        {
            return new Rogue(this.Name);
        }
    }
}
