using NUnit.Framework;
//using P03_CarManager;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            this.car = new Car("BMW", "E46", 20, 60);
        }
        // Test Car Make Property

        [Test]
        [TestCase("BMW")]
        [TestCase("VW")]
        public void CarMakePropertyShouldSetValueCorrectly(string make)
        {
            //Arrange
            this.car = new Car(make, "E46", 20, 60);
            //Act - Assert
            string expectedResult = make;
            Assert.AreEqual(expectedResult, this.car.Make);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CarMakePropertyShouldThrowExeptionIfMakeIsNullOrEmpty(string make)
        {
            //Arrange - Act - Assert
            Assert.Throws<ArgumentException>(() => new Car(make, "E46", 20, 60));
        }

        [Test]
        public void CarMakePropertyGetterShouldWorkCorrectly()
        {
            //Arrange - Act - Assert
            string expectedResult = "BMW";
            string actualResult = this.car.Make;

            Assert.AreEqual(expectedResult, actualResult);
        }

        // Test Car Model Property

        [Test]
        [TestCase("E46")]
        [TestCase("X5")]
        public void CarModelPropertyShouldSetValueCorrectly(string model)
        {
            //Arrange
            this.car = new Car("BMW", model, 20, 60);
            //Act - Assert
            string expectedResult = model;
            Assert.AreEqual(expectedResult, this.car.Model);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CarModelPropertyShouldThrowExeptionIfModelIsNullOrEmpty(string model)
        {
            //Arrange - Act - Assert
            Assert.Throws<ArgumentException>(() => new Car("BMW", model, 20, 60));
        }

        [Test]
        public void CarModelPropertyGetterShouldWorkCorrectly()
        {
            //Arrange - Act - Assert
            string expectedResult = "E46";
            string actualResult = this.car.Model;

            Assert.AreEqual(expectedResult, actualResult);
        }

        // Test Car FuelConsumption Property

        [Test]
        [TestCase(2.20)]
        [TestCase(5)]
        public void CarFuelConsumptionPropertySetterShouldWorkCorrectly(double fuelConsumption)
        {
            // Arrange
            this.car = new Car("BMW", "E46", fuelConsumption, 60);
            // Act
            double expectedResult = fuelConsumption;
            double actualResult = this.car.FuelConsumption;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarFuelConsumptionPropertyShouldThrowExceptionIfIsNegativeOrZeroNumber(
            double fuelConsumption)
        {
            // Arrange - Act - Assert
            Assert.Throws<ArgumentException>(() => new Car("BMW", "E46", fuelConsumption, 60));
        }

        [Test]
        public void CarFuelConsumptionPropertyGetterShouldWorkCorrectly()
        {
            // Arrange - Act - Assert
            double expectedResul = 20;
            double actualResul = this.car.FuelConsumption;

            Assert.AreEqual(expectedResul, actualResul);
        }


        // Test Car FuelCapacity Property

        [Test]
        [TestCase(2.20)]
        [TestCase(5)]
        public void CarFuelCapacityPropertySetterShouldWorkCorrectly(double fuelCapacity)
        {
            // Arrange
            this.car = new Car("BMW", "E46", 20, fuelCapacity);
            // Act
            double expectedResult = fuelCapacity;
            double actualResult = this.car.FuelCapacity;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarFuelCapacityPropertyShouldThrowExceptionIfIsNegativeOrZeroNumber(
            double fuelCapacity)
        {
            // Arrange - Act - Assert
            Assert.Throws<ArgumentException>(() => new Car("BMW", "E46", 20, fuelCapacity));
        }

        [Test]
        public void CarFuelCapacityPropertyGetterShouldWorkCorrectly()
        {
            // Arrange - Act - Assert
            double expectedResul = 60;
            double actualResul = this.car.FuelCapacity;

            Assert.AreEqual(expectedResul, actualResul);
        }

        // Test Car Refuel Method

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarRefuelMethodShouldThrowExeptionIfFuelToRefuelIsZeroOrNegativeNumber(double fuelToRefuel)
        {
            // Arrange - Act - Assert
            Assert.Throws<ArgumentException>(() => this.car.Refuel(fuelToRefuel));

        }

        [Test]
        [TestCase(20)]
        [TestCase(10)]
        public void CarRefuelMethodShouldWorkCorrectly(double fuelToRefuel)
        {
            // Arrange - Act
            this.car.Refuel(fuelToRefuel);
            double expectedResult = fuelToRefuel;
            double actualResult = this.car.FuelAmount;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        [TestCase(70)]
        [TestCase(100)]
        public void CarRefuelMethodCannotOverflowCapacity(double fuelToRefuel)
        {
            // Arrange - Act
            this.car.Refuel(fuelToRefuel);
            double expectedResult = this.car.FuelCapacity;
            double actualResult = this.car.FuelAmount;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        // Test Car Drive Method

        [Test]
        [TestCase(400)]
        [TestCase(700)]
        public void CarDriveMethodShouldThrowExeptionIfAmountNeededIsNotEnough(double distance)
        {
            // Arrange - Act - Assert
            Assert.Throws<InvalidOperationException>(() => this.car.Drive(distance));
        }

        [Test]
        [TestCase(200)]
        [TestCase(300)]
        public void CarDriveMethodShouldWorkCorrectly(double distance)
        {
            // Aarange
            this.car.Refuel(60);
            // Act
            double expectedResult = 60 - (distance / 100) * this.car.FuelConsumption;
            this.car.Drive(distance);
            double actualResult = this.car.FuelAmount;

            // Asset
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}