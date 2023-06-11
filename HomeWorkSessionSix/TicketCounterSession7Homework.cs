namespace HomeWorkSessionSix
{
    public class TicketCounterSession7Homework : ZooWorkers
    {
        public int TicketsSold { get; private set; }

        public void SellTicket()
        {
            TicketsSold++;
            Console.WriteLine($"{Name} sold a ticket!");
        }
    }
}
