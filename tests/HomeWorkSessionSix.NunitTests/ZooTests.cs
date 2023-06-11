namespace HomeWorkSessionSix.NunitTests
{
    public class ZooTests
    {
        private Zoo zoo;

        [SetUp]
        public void Setup()
        {
            zoo = new Zoo();
        }

        [Test]
        public void FeedAnimals_WhenCalled_FeedsAllUnfedAnimals()
        {
            // Arrange
            zoo.AddAnimal("Tiger", "Meat");
            zoo.AddAnimal("Zebra", "Hay");

            // Act
            zoo.FeedAnimals();

            // Assert
            Assert.IsTrue(zoo.GetAnimals().All(a => a.IsFed));
        }

        [Test]
        public void SellTicket_WhenCalled_IncrementsTicketsSold()
        {
            // Arrange
            int initialTicketsSold = zoo.GetTicketsSold();

            // Act
            zoo.SellTicket();

            // Assert
            Assert.AreEqual(initialTicketsSold + 1, zoo.GetTicketsSold());
        }
    }
}