namespace HomeWorkSessionSix
{
    public class ZooWorkers
    {
        public string Name { get; set; }

        public virtual void FeedAnimal(Animal animal)
        {
            animal.IsFed = true;
            Console.WriteLine(Name + " Fed " + animal.Name + " with " + animal.Food);
        }


    }
}
