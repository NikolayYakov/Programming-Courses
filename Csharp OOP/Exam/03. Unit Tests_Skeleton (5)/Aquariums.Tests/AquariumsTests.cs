namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        Fish fish;
        string fishName = "Pesho";
        string aquName = "More";
        int capacity = 10;
        Aquarium aqu;
        [SetUp]
        public void SetUp()
        {
            fish = new Fish(fishName);
            aqu = new Aquarium(aquName, capacity);
        }
        [Test]
        public void WhenFishIsCreatedPropShouldBeSet()
        {
            Assert.AreEqual(fish.Name, fishName);
            Assert.AreEqual(fish.Available, true);
        }
        [Test]
        public void PropShouldBeGettable()
        {
            string fishNameTest = fish.Name;
            bool test = fish.Available;
            Assert.AreEqual(fish.Name, fishNameTest);
            Assert.AreEqual(fish.Available, test);
        }
        [Test]
        public void WhenNameIsNullOrEmptyThrow()
        {
            Assert.Throws<ArgumentNullException>(() => aqu = new Aquarium(null, capacity));
            Assert.Throws<ArgumentNullException>(() => aqu = new Aquarium(string.Empty, capacity));
        }
        [Test]
        public void WhenCapacityIsNegativeThrow()
        {
            Assert.Throws<ArgumentException>(() => aqu = new Aquarium(aquName, -10));
        }
        [Test]
        public void WhenEveryThingIsCorrectSeProp()
        {
            Assert.AreEqual(aqu.Name, aquName);
            Assert.AreEqual(capacity, aqu.Capacity);
            Assert.AreEqual(aqu.Count, 0);
        }
        [Test]
        public void PropShouldBeGettableAqu()
        {
            string aquTest = aqu.Name;
            int capaTest = aqu.Capacity;
            int countTest = aqu.Count;
            Assert.AreEqual(aquTest, aqu.Name);
            Assert.AreEqual(capaTest, aqu.Capacity);
            Assert.AreEqual(countTest, aqu.Count);
        }
        [Test]
        public void WhenAquISFullThrow()
        {
            aqu = new Aquarium(aquName, 1);
            aqu.Add(fish);
            fish = new Fish("gOSHO");
            Assert.Throws<InvalidOperationException>(() => aqu.Add(fish));
        }
        [Test]
        public void WhenAddedSuccCountPlus()
        {
            aqu.Add(fish);
            aqu.Add(fish);
            aqu.Add(fish);
            Assert.AreEqual(aqu.Count, 3);

        }
        [Test]
        public void WhenRemovingNullThrow()
        {
            Assert.Throws<InvalidOperationException>(() => aqu.RemoveFish("Pesho"));
        }
        [Test]
        public void WhenRemovedCountDecrease()
        {
            aqu.Add(fish);
            aqu.RemoveFish(fish.Name);
            Assert.AreEqual(aqu.Count, 0);
        }
        [Test]
        public void WhenSellingNullThrow()
        {
            Assert.Throws<InvalidOperationException>(() => aqu.SellFish("Pesho"));

        }
        [Test]
        public void WhenSelledFishShoulBeFalseAndShouldBeReturned()
        {
            aqu.Add(fish);
            Fish selledFish = aqu.SellFish(fish.Name);
            Assert.AreEqual(fish, selledFish);
            Assert.AreEqual(fish.Available, false);
        }
        [Test]
        public void WhenReprtedReturnWhatIsAvailable()
        {
            aqu.Add(fish);
            aqu.Add(new Fish("Niko"));
            string report = aqu.Report();
            Assert.AreEqual(report, $"Fish available at {aqu.Name}: {fish.Name}, Niko");
        }
        [Test]
        public void FishPropShouldBeSettable()
        {
            fish.Name = "Gope";
            fish.Available = false;
            Assert.AreEqual(fish.Name, "Gope");
            Assert.AreEqual(fish.Available, false);
        }
    }
}
