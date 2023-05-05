namespace Raiding
{
    public class Rogue : BaseHero 
    {
        private new const int Power = 80;
        public Rogue(string name) : base(name)
        {
            base.Power = Power;
        }

        public override string CastAbility()
        {
            return $"{nameof(Rogue)} - {this.Name} hit for {base.Power} damage";
        }
    }
}
