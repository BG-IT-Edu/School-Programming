namespace Raiding
{
   public class Warrior : BaseHero
    {
        private new const int Power = 100;
        public Warrior(string name) : base(name)
        {
            base.Power = Power;
        }

        public override string CastAbility()
        {
            return $"{nameof(Warrior)} - {this.Name} hit for {base.Power} damage";
        }
    }
}
