namespace HomeWorkSessionFour
{
    public class ScoreTracker
    {
        private List<Participants> participants = new List<Participants>();

        public void AddParticipant(string name, int score, int id)
        {
            participants.Add(new Participants { Name = name, Score = score, IdentiticationNumber = id });
        }

        public void AddParticipantAtPosition(string name, int score, int id, int position)
        {
            participants.Insert(position, new Participants { Name = name, Score = score, IdentiticationNumber = id });
        }

        public void DeleteParticipantAtPosition(int position)
        {
            if (position >= 0 && position < participants.Count)
            {
                participants.RemoveAt(position);
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
        }

        public void ModifyParticipantScore(int id, int newScore)
        {
            Participants participant = participants.Find(p => p.IdentiticationNumber == id);
            if (participant != null)
            {
                participant.Score = newScore;
            }
            else
            {
                Console.WriteLine("Participant not found!");
            }
        }

        public void PrintParticipantsWithScoreLessThan(int score)
        {
            foreach (var participant in participants.Where(p => p.Score < score))
            {
                Console.WriteLine($"Name: {participant.Name}, Score: {participant.Score}");
            }
        }

        public void PrintParticipantsByScoreAscending()
        {
            foreach (var participant in participants.OrderBy(p => p.Score))
            {
                Console.WriteLine($"Name: {participant.Name}, Score: {participant.Score}");
            }
        }

        public void PrintParticipantsWithScoreGreaterThan(int score)
        {
            foreach (var participant in participants.Where(p => p.Score > score).OrderBy(p => p.Score))
            {
                Console.WriteLine($"Name: {participant.Name}, Score: {participant.Score}");
            }
        }

        public double CalculateArithmeticMean(int start, int end)
        {
            var selectedParticipants = participants.Where(p => p.IdentiticationNumber >= start && p.IdentiticationNumber <= end);
            return selectedParticipants.Average(p => p.Score);
        }

    }
}
