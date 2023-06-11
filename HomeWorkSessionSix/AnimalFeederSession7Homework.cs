namespace HomeWorkSessionSix
{
    public class AnimalFeederSession7Homework : ZooWorkers
    {
        public void FeedAnimals(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                if (!animal.IsFed)
                {
                    FeedAnimal(animal);
                }
            }
        }
    }
}
