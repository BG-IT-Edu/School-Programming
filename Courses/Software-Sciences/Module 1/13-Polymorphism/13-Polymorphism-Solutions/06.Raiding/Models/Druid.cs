namespace Raiding
{
    public class Druid : BaseHero
    {
        private new const int Power = 80; 
        public Druid(string name) : base(name)
        {
            base.Power = Power;
        }

        public override string CastAbility()
        {
            return $"{nameof(Druid)} - {this.Name} healed for {base.Power}";
        }
    }
}
