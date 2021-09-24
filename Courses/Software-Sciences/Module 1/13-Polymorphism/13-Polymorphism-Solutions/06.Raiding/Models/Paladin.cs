namespace Raiding
{
    public class Paladin : BaseHero
    {
        private new const int Power = 100;
        public Paladin(string name) : base(name)
        {
            base.Power = Power;
        }

        public override string CastAbility()
        {
            return $"{nameof(Paladin)} - {this.Name} healed for {base.Power}";
        }
    }
}
