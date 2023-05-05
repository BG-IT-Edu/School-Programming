namespace Raiding
{
    public class PaladinFactory : HeroFactory
    {
        public PaladinFactory(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override BaseHero GetHero()
        {
            return new Paladin(this.Name);
        }
    }
}
