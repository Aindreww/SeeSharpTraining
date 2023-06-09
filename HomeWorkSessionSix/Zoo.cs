namespace HomeWorkSessionSix
{
    public class Zoo
    {
        private List<Animal> animals;
        private List<ZooWorkers> workers;
        private TicketSellers ticketSeller;

        public Zoo()
        {
            animals = new List<Animal>();
            workers = new List<ZooWorkers>();
            ticketSeller = new TicketSellers { Name = "Barney" };
            workers.Add(ticketSeller);
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
                }
            }
        }

        public void SellTicket()
        {
            ticketSeller.SellTicket();
        }

        public void DisplayTicketsSold()
        {
            Console.WriteLine("Total Tickets Sold: " + ticketSeller.TicketsSold);
        }







    }

}

