using NUnit.Framework;
//using P02_ExtendedDatabase;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;

        [SetUp]
        public void Setup()
        {
            this.database = new ExtendedDatabase(
                new Person(1, "Pesho"),
                new Person(2, "Gosho"),
                new Person(3, "Tosho"));
        }

        // Test Count Property
        [Test]
        public void DatabaseCountPropertyShouldWorkCorrectly()
        {
            //Arrange
            int expectedResult = 3;
            int actualResult = this.database.Count;

            //Act - Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Test Add Method.
        [Test]
        public void AddMethodShouldThrowExceptionIfPersonUserNameExist()
        {
            //Arragne
            Person person = new Person(442, "Pesho");

            //Act - Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(person));
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfPersoIdExist()
        {
            //Arragne
            Person person = new Person(1, "Toto");

            //Act - Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(person));
        }

        [Test]
        public void AddMethodShouldWorkCorrectly()
        {
            //Arragne
            Person person = new Person(4, "Toto");

            //Act
            this.database.Add(person);
            int expectedCount = 4;
            int actualCount = this.database.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfNoMoreFreeSpaceInDatabase()
        {
            // Arrange
            for (int i = this.database.Count; i < 16; i++)
            {
                this.database.Add(new Person(i + 1, $"{i}{(char)i}"));
            }

            // Act - Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(17, "Last")));
        }

        // Test Remove Method.
        [Test]
        public void RemoveMethodShouldWorkCorrectly()
        {
            // Arrange - Act - Assert
            this.database.Remove();
            Assert.AreEqual(2, this.database.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionIfDatabaseIsEmpty()
        {
            // Arrange
            this.database = new ExtendedDatabase();
            // Act - Asset
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());

        }

        // Test Find By Username Method.
        [Test]
        public void CheckMethodFindByUsernameWorkCorrectly()
        {
            // Arrange
            string expectedResult = "Pesho";
            string actualResult = this.database.FindByUsername("Pesho").UserName;

            // Act - Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Kiko")]
        [TestCase("Diko")]
        public void FindByUserMethodShouldThrowExceptionIfNotUserByGivenUserNameIsFound(string username)
        {
            // Arrange - Act - Assert
            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername(username));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void FindByUserMethodShouldThrowExceptionIfNullArgumentIsGiven(string username)
        {
            // Arrange - Act - Assert
            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(username));
        }

        [Test]
        public void FindByUsernameMethodShouldBeCaseSensitive()
        {
            //Arrange
            string notExpectedResult = "peSho";
            string actualResult = this.database.FindByUsername("Pesho").UserName;

            // Act - Assert
            Assert.AreNotEqual(notExpectedResult, actualResult);

        }

        // Test Find By Id Method.
        [Test]
        public void CheckMethodFindByIdWorkCorrectly()
        {
            // Arrange
            string expectedResult = "Gosho";
            string actualResult = this.database.FindById(2).UserName;

            // Act - Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FindByIdMethodShouldThrowExceptionIfNegativeIdIsPasset()
        {
            //Arrange - Act - Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-1));
        }

        [Test]
        public void FindByIdMethodShouldThrowExceptionIfNotExistingIdIsGiven()
        {
            //Arrange - Act - Assert
            Assert.Throws<InvalidOperationException>(() => this.database.FindById(4));
        }

    }
}