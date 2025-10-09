namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(1, name, description, points)
        {

        }
        public override void RecordEvent()
        {
            IsComplete();
            System.Console.WriteLine($"You have completed the {GetName()} Goal!\nYou get {GetPoints()} Points!");
        }

    }
}