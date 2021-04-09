using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private const string owner = "Pesho";
        private const string itemId = "123";
        private Item item;
        private BankVault bankValue;
        [SetUp]
        public void Setup()
        {
            item = new Item(owner, itemId);
            bankValue = new BankVault();
        }

        [Test]
        public void WhenValueIsSetItShouldBeGettable()
        {
            string nameTest = item.Owner;
            string idTest = item.ItemId;
            Assert.AreEqual(nameTest, item.Owner);
            Assert.AreEqual(idTest, item.ItemId);
        }
        [Test]
        public void WhenCraatedItsValuesShouldBeSetCorrectly()
        {
            Assert.AreEqual(owner, item.Owner);
            Assert.AreEqual(itemId, item.ItemId);
        }
        [Test]
        public void WhenYouTryToAddToACellThatDontExcistThrow()
        {
           Assert.Throws<ArgumentException>(()=>bankValue.AddItem("Pesho", item));
        }
        [Test]
        public void WhenTheCellIsTackenThrow()
        {
            bankValue.AddItem("A1", item);
            Item secondItem = new Item("Gosho", "256");
            Assert.Throws<ArgumentException>(() => bankValue.AddItem("A1", secondItem));
        }
        [Test]
        public void WhenItemIdIsPressentThrowException()
        {
            bankValue.AddItem("A1", item);
            Assert.Throws<InvalidOperationException>(() => bankValue.AddItem("A2", item));
        }
        [Test]
        public void WhenEverythingIsCorrectShouldAdd()
        {
            bankValue.AddItem("A1", item);
            Assert.AreEqual(bankValue.VaultCells["A1"], item);
        }
        [Test]
        public void WhenAddedShouldReturnAMassage()
        {
            string massage = bankValue.AddItem("A1", item);
            string originalMessage = $"Item:{itemId} saved successfully!";
            Assert.AreEqual(massage, originalMessage);
        }
        [Test]
        public void WhenRemovedFromNonExistingCellThrow()
        {
            Assert.Throws<ArgumentException>(() => bankValue.RemoveItem("Pesho", item));
        }
        [Test]
        public void WhenItemInCellIsDiFferentThrow()
        {
            Assert.Throws<ArgumentException>(() => bankValue.RemoveItem("A1", item));
            Item secondItem = new Item("Gosho", "987");
            bankValue.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() => bankValue.RemoveItem("A1",secondItem));
        }
        [Test]
        public void WhenItemIsRemovedShouldBecomeNull()
        {
            bankValue.AddItem("A1", item);
            bankValue.RemoveItem("A1", item);
            Assert.AreEqual(bankValue.VaultCells["A1"], null);
        }
        [Test]
        public void WhenRemovedShouldReturnAMessage()
        {
            bankValue.AddItem("A1", item);
            string massage = bankValue.RemoveItem("A1", item);
            string originalMassage = $"Remove item:{item.ItemId} successfully!";
            Assert.AreEqual(massage, originalMassage);
        }
        [Test]
        public void WhenCreatedShouldCreateData()
        {
            Assert.AreEqual(bankValue.VaultCells.Count, 12);
        }
        [Test]
        public void EveryDataShouldBeNull()
        {

            Assert.AreEqual(bankValue.VaultCells["A1"], null);
           
        }
    }
}