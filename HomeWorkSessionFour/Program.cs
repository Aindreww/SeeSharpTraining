namespace HomeWorkSessionFour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ScoreTracker scoreTracker = new ScoreTracker();

            scoreTracker.AddParticipant("Andrei", 8, 1);
            scoreTracker.AddParticipant("Willi", 7, 2);
            scoreTracker.AddParticipant("Cristian", 6, 3);
            scoreTracker.AddParticipant("Vlad", 9, 4);
            scoreTracker.AddParticipant("Daniel", 5, 5);

            scoreTracker.AddParticipantAtPosition("Mihai", 10, 6, 2);
            scoreTracker.DeleteParticipantAtPosition(3);
            scoreTracker.ModifyParticipantScore(4, 9);

            Console.WriteLine("Participants with a score less than 7:");
            scoreTracker.PrintParticipantsWithScoreLessThan(7);

            Console.WriteLine("Participants in ascending order by score:");
            scoreTracker.PrintParticipantsByScoreAscending();

            Console.WriteLine("Participants with a score greater than 7 in ascending order by score:");
            scoreTracker.PrintParticipantsWithScoreGreaterThan(7);


            Console.WriteLine("Calculating arithmetic mean of scores...");

            int start = 2;
            int end = 6;

            double mean = scoreTracker.CalculateArithmeticMean(start, end);

            Console.WriteLine("Arithmetic mean of scores for participants from position " + start + " to " + end + " is euqal to: " + mean);
        }
    }
 }
