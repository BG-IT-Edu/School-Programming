using NUnit.Framework;
//using P04_FightingArena;
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        [Test]
        public void ArenaConstructorShouldWorkdProperly()
        {
            Arena arena = new Arena();
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void EnrollMethodShouldAddWarriorProperly()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("name", 10, 10);
            arena.Enroll(warrior);

            //Assert.That(arena.Warriors.Contains(warrior));
            var isAny = arena.Warriors.Any(x => x.Name == "name");
            Assert.IsTrue(isAny);
        }

        [Test]
        public void EnrollMethodShouldThrowExceptionWhenTryingToAddExistingWarrior()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("name", 10, 10);
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void EnrollMethodShouldThrowExceptionWhenTwoWarriorsHaveTheSameName()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("name", 10, 10);
            Warrior warrior2 = new Warrior("name", 10, 20);

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior2));
        }

        [Test]
        public void CountPropertyShouldWorkProperly()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("name", 10, 10);
            arena.Enroll(warrior);

            var expectedResult = 1;
            var actualResult = arena.Warriors.Count();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CountPropertyShouldWorkProperlyWithoutWarriors()
        {
            Arena arena = new Arena();

            var expectedResult = 0;
            var actualResult = arena.Warriors.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("name1", "name2")]
        public void FightMethodShouldThrowExceptionWhenAttackerDoesntExist(string attackerName, string attackedName)
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior(attackerName, 10, 10);

            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attackerName, attackedName));
        }

        [Test]
        [TestCase("name1", "name2")]
        public void FightMethodShouldThrowExceptionWhenAttackedDoesntExist(string attackerName, string attackedName)
        {
            Arena arena = new Arena();
            Warrior attacked = new Warrior(attackedName, 10, 10);

            arena.Enroll(attacked);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attackerName, attackedName));
        }

        [Test]
        [TestCase("name1", "name2")]
        public void FightMethodShouldThrowExceptionWhenAttackedrAndAttackedDoesntExist(string attackerName, string attackedName)
        {
            Arena arena = new Arena();

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attackerName, attackedName));
        }

        [Test]
        public void FightMethodShouldWorkProperly()
        {
            Arena arena = new Arena();
            Warrior attacker = new Warrior("name3", 100, 100);
            Warrior attacked = new Warrior("name2", 50, 50);

            arena.Enroll(attacker);
            arena.Enroll(attacked);
            arena.Fight(attacker.Name, attacked.Name);

            var expectedResult = 50;
            var actualResult = attacker.HP;

            var expectedResult2 = 0;
            var actualResult2 = attacked.HP;

            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedResult2, actualResult2);
        }
    }
}
