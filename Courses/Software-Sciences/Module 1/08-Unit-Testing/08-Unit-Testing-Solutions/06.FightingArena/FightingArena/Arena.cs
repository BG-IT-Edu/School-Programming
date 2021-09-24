using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_FightingArena
{
    public class Arena
    {
        private readonly List<Warrior> warriors;

        public Arena()
        {
            this.warriors = new List<Warrior>();
        }

        public IReadOnlyCollection<Warrior> Warriors =>
            this.warriors;

        public int Count => this.warriors.Count;

        public void Enroll(Warrior warrior)
        {
            if (this.warriors.Any(w => w.Name == warrior.Name))
            {
                throw new InvalidOperationException("Warrior is already enrolled for the fights!");
            }

            this.warriors.Add(warrior);
        }

        public void Fight(string attackerName, string defenderName)
        {
            Warrior attacker = this.warriors
                .FirstOrDefault(w => w.Name == attackerName);
            Warrior defender = this.warriors
                .FirstOrDefault(w => w.Name == defenderName);

            if (attacker == null || defender == null)
            {
                string missingName = attackerName;

                if (defender == null)
                {
                    missingName = defenderName;
                }

                throw new InvalidOperationException($"There is no fighter with name {missingName} enrolled for the fights!");
            }

            attacker.Attack(defender);
        }
    }
}
