namespace HomeWorkSessionSix
{
    public class Zoo
    {
        private List<Animal> animals;
        private List<ZooWorkers> workers;
        private TicketSellers ticketSeller;
        private TicketCounterSession7Homework ticketCounter;
        private AnimalFeederSession7Homework animalFeeder;

        public Zoo()
        {
            animals = new List<Animal>();
            workers = new List<ZooWorkers>();
            ticketSeller = new TicketSellers { Name = "Barney" };
            workers.Add(ticketSeller);
            ticketCounter = new TicketCounterSession7Homework { Name = "Barney" };
            animalFeeder = new AnimalFeederSession7Homework { Name = "John" };

            workers.Add(ticketCounter);
            workers.Add(animalFeeder);


        }

       

        public void AddAnimal(string name, string food)
        {
            Animal animal = new Animal
            {
                Name = name,
                Food = food,
                IsFed = false
            };
            animals.Add(animal);

        }

        public void AddWorker(string name)
        {
            ZooWorkers worker = new ZooWorkers { Name = name };
            workers.Add(worker);
        }

        public void AssignWorkerToAnimals(string workerName, List<string> animalNames)
        {
            ZooWorkers worker = workers.Find(w => w.Name == workerName);
            if (worker != null)
            {
                foreach (string animalName in animalNames)
                {
                    Animal animal = animals.Find(a => a.Name == animalName);
                    if (animal != null)
                    {
                        worker.FeedAnimal(animal);
                    }
                }
            }
        }

        public void FeedAnimals()
        {
            foreach (Animal animal in animals)
            {
                if (!animal.IsFed)
                {
                    ZooWorkers worker = workers.Find(w => w is not TicketSellers); 
                    worker.FeedAnimal(animal);
                    animalFeeder.FeedAnimals(animals);
                }
            }
        }

        public void SellTicket()
        {
            ticketSeller.SellTicket();
            ticketCounter.SellTicket();
        }

        public void DisplayTicketsSold()
        {
            Console.WriteLine("Total Tickets Sold: " + ticketSeller.TicketsSold);
        }


        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public int GetTicketsSold()
        {
            return ticketCounter.TicketsSold;
        }


    }

}

