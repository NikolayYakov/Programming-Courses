using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        UnitCar car;
        string model = "Honda";
        int horsePower = 150;
        double cubic = 2000;
        UnitDriver driver;
        string name = "Pesh0";
        RaceEntry race;

        [SetUp]
        public void Setup()
        {
            car = new UnitCar(model, horsePower, cubic);
            driver = new UnitDriver(name, car);
            race = new RaceEntry();
        }

        [Test]
        public void WhenCarIsCreatedValuesShouldBeGiven()
        {
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(horsePower, car.HorsePower);
            Assert.AreEqual(cubic, car.CubicCentimeters);
        }
        [Test]
        public void CarPropertiesShouldBeGettable()
        {
            string modelTest = car.Model;
            int horsePowerTest = car.HorsePower;
            double cubicTest = car.CubicCentimeters;
            Assert.AreEqual(modelTest, car.Model);
            Assert.AreEqual(horsePowerTest, car.HorsePower);
            Assert.AreEqual(cubicTest, car.CubicCentimeters);
        }
        [Test]
        public void WhenNameIsNullThrow()
        {
            Assert.Throws<ArgumentNullException>(()=> driver = new UnitDriver(null, car));
        }
        [Test]
        public void WhenEverythingIsCorrectPropSet()
        {
            Assert.AreEqual(name, driver.Name);
            Assert.AreEqual(car, driver.Car);
        }
        [Test]
        public void DataShouldBeGettable()
        {
            UnitCar carTest = driver.Car;
            string nameTest = driver.Name;
            Assert.AreEqual(nameTest, driver.Name);
            Assert.AreEqual(carTest, driver.Car);
        }
        [Test]
        public void WhenRaceIsCreatedCountIsZero()
        {
            Assert.AreEqual(race.Counter, 0);
        }
        [Test]
        public void WhenAddNullDriverThrow()
        {
            driver = null;
            Assert.Throws<InvalidOperationException>(() => race.AddDriver(driver));
        }
        [Test]
        public void WhenDriverIsThereThrow()
        {
            race.AddDriver(driver);
            Assert.Throws<InvalidOperationException>(() => race.AddDriver(driver));

        }
        [Test]
        public void WhenCorrectAddDriverIncreaseTheCountAndRetuntMsg()
        {
           string msg = race.AddDriver(driver);
            Assert.AreEqual(race.Counter, 1);
            Assert.AreEqual(msg, $"Driver {driver.Name} added in race.");
        }
        [Test]
        public void WhenThereAreLessThanTwoDriversThrow()
        {
            race.AddDriver(driver);
            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());

        }
        [Test]
        public void WhenDriversAreTwoOrMoreReturnAverageHorsePower()
        {
            race.AddDriver(driver);
            driver = new UnitDriver("Gosho", new UnitCar("Golf", 300, 5000));
            race.AddDriver(driver);
            double horse = race.CalculateAverageHorsePower();
            Assert.AreEqual(horse, 225);
        }
    }
}