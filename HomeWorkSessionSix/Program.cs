namespace HomeWorkSessionSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            // Add animals to the zoo
            zoo.AddAnimal("Tiger", "Meat");
            zoo.AddAnimal("Zebra", "Hay");
            zoo.AddAnimal("Giraffe", "Leaves");

            // Add workers to the zoo
            zoo.AddWorker("Mike");
            zoo.AddWorker("Clyde");
            zoo.AddWorker("Jody");

            // Assign workers to animals
           zoo.AssignWorkerToAnimals("Mike", new List<string> { "Zebra" });
           zoo.AssignWorkerToAnimals("Clyde", new List<string> { "Giraffe" });
           zoo.AssignWorkerToAnimals("Jody", new List<string> { "Tiger" });

            // Feed animals
            zoo.FeedAnimals();

            // Sell tickets
            zoo.SellTicket();
            zoo.SellTicket();

            // Display tickets sold
            zoo.DisplayTicketsSold();
        }
    }
}
