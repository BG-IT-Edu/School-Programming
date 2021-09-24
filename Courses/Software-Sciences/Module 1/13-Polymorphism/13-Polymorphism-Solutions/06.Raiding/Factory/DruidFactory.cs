namespace Raiding
{
    public class DruidFactory : HeroFactory
    {
        public DruidFactory(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set;}

        public override BaseHero GetHero()
        {
            return new Druid(this.Name);
        }
    }
}
