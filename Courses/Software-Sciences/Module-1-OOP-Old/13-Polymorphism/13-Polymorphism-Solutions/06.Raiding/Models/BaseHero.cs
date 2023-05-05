using System.Runtime.CompilerServices;

namespace Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public int Power { get; set; }

        public abstract string CastAbility();

    }
}
