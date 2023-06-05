namespace HomeWorkSessionFour
{
    public class ScoreTracker
    {
        public List<Participants> MyParticipants;

        public ScoreTracker()
        {
            MyParticipants = new List<Participants>();
        }

        public void AddParticipant(string name, int score, int id)
        {
            Participants participant = new Participants
            {
                Name = name,
                Score = score,
                IdentiticationNumber = id
            };
            MyParticipants.Add(participant);
        }

        public void AddParticipantAtPosition(string name, int score, int id, int position)
        {
            Participants participant = new Participants
            {
                Name = name,
                Score = score,
                IdentiticationNumber = id
            };

            MyParticipants.Insert(position, participant);
        }

        public void DeleteParticipantAtPosition(int position)
        {
            if (position >= 0 && position < MyParticipants.Count)
            {
                MyParticipants.RemoveAt(position);
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
        }

        public void ModifyParticipantScore(int id, int newScore)
        {
            Participants participant = MyParticipants.Find(p => p.IdentiticationNumber == id);
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
            var filteredParticipants = MyParticipants.Where(p => p.Score < score);
            foreach (var participant in filteredParticipants)
            {
                Console.WriteLine($"Name: {participant.Name}, Score: {participant.Score}");
            }
        }

        public void PrintParticipantsByScoreAscending()
        {
            var sortedParticipants = MyParticipants.OrderBy(p => p.Score);
            foreach (var participant in sortedParticipants)
            {
                Console.WriteLine($"Name: {participant.Name}, Score: {participant.Score}");
            }
        }

        public void PrintParticipantsWithScoreGreaterThan(int score)
        {
            var filteredParticipants = MyParticipants.Where(p => p.Score > score).OrderBy(p => p.Score);
            foreach (var participant in filteredParticipants)
            {
                Console.WriteLine($"Name: {participant.Name}, Score: {participant.Score}");
            }
        }

        public double CalculateArithmeticMean(int start, int end)
        {
            var selectedParticipants = MyParticipants.Where(p => p.IdentiticationNumber >= start && p.IdentiticationNumber <= end);
            int sum = selectedParticipants.Sum(p => p.Score);
            int count = selectedParticipants.Count();
            return (double)sum / count;
        }

    }
}
