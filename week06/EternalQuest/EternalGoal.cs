namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(3, name, description, points)
        {
        }

        public override void RecordEvent()
        {
            IsComplete();
            System.Console.WriteLine($"You have gained {GetPoints()} Points!");
        }
        public override void IsComplete()
        {
        }

    }
}