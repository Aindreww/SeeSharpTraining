namespace HomeWorkSessionSix
{
    public class TicketSellers : ZooWorkers
    {
        public int TicketsSold { get; set; }

        public void SellTicket()
        {
            TicketsSold++;
            Console.WriteLine(Name + " " + "Sold a ticket!");
        }
    }
}
