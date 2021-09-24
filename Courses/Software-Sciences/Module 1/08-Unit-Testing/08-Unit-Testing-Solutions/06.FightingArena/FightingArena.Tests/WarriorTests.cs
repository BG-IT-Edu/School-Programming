using NUnit.Framework;
//using P04_FightingArena;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [Test]
        [TestCase("name", 10, 10)]
        public void WarriorConstructorShouldWorkProperly(string name, int damage, int hp)
        {
            Warrior warrior = new Warrior(name, damage, hp);

            Assert.AreEqual(warrior.Name, name);
            Assert.AreEqual(warrior.Damage, damage);
            Assert.AreEqual(warrior.HP, hp);
        }

        [Test]
        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("")]
        public void NamePropertyShouldThrowExceptionWithNameNullOrEmptySpace(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 10, 10));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void DamagePropertyShouldThrowExceptionWithDamageBelowOrEqualToZero(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("name", damage, 10));
        }

        [Test]
        public void HPPropertyShouldThrowExceptionWithHPBelowZero()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("name", 10, -5));
        }

        [Test]
        [TestCase(29)]
        [TestCase(30)]
        public void AttackMethodShouldThrowExceptionWhenAttackersHPIsBelowMin(int hp)
        {
            Warrior attacker = new Warrior("name", 10, hp);
            Warrior attacked = new Warrior("name2", 10, 35);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked));
        }

        [Test]
        [TestCase(29)]
        [TestCase(30)]
        public void AttackMethodShouldThrowExceptionWhenAttackedsHPIsBelowMin(int hp)
        {
            Warrior attacker = new Warrior("name", 10, 35);
            Warrior attacked = new Warrior("name2", 10, hp);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked));
        }

        [Test]
        public void AttackMethodShouldThrowExceptionWhenAttackersHPIsBelowAttackeds()
        {
            Warrior attacker = new Warrior("name", 10, 35);
            Warrior attacked = new Warrior("name2", 40, 35);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(attacked));
        }

        [Test]
        public void AttackMethodShouldReduceHPProperly()
        {
            Warrior attacker = new Warrior("name", 10, 35);
            Warrior attacked = new Warrior("name2", 10, 35);

            attacker.Attack(attacked);

            var expectedResult = 25;
            var actualResult = attacker.HP;
            var expectedResult2 = 25;
            var actualResult2 = attacked.HP;

            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedResult2, actualResult2);
        }

        [Test]
        public void AttackMethodShouldWorkProperlyIfAttackersDamageIsGreaterThanAttackedsHP()
        {
            Warrior attacker = new Warrior("name", 45, 35);
            Warrior attacked = new Warrior("name2", 10, 35);

            attacker.Attack(attacked);

            var expectedResult = 0;
            var actualResult = attacked.HP;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AttackMethodShouldWorkProperlyIfAttackersDamageIsBelowAttackedsHP()
        {
            Warrior attacker = new Warrior("name", 45, 35);
            Warrior attacked = new Warrior("name2", 10, 55);

            attacker.Attack(attacked);

            var expectedResult = 10;
            var actualResult = attacked.HP;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}