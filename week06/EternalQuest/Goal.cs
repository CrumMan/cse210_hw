using System.Runtime.CompilerServices;

namespace EternalQuest
{
    public abstract class Goal
    {
        private int _typeOfGoal;
        private string _shortName;
        private string _description;
        private int _points;
        private bool _bool = false;
        protected Goal(int typeOfGoal, string name, string description, int points)
        {
            _typeOfGoal = typeOfGoal;
            _shortName = name;
            _description = description;
            _points = points;
        }
        protected void SetPoints(int points)
        {
            _points = points;
        }
        public abstract void RecordEvent();
        public bool GetComplete()
        {
            return _bool;
        }
        public virtual void IsComplete()
        {
            _bool = true;
        }
        public string GetName()
        {
            return _shortName;
        }
        public string GetDetailsString()
        {
            return _description;
        }
        public virtual string GetStringRepresentation()
        {
            if (GetComplete())
            {
                return $"[X] {GetName()}: {GetDetailsString()}";
            }
            else
            {
                return $"[] {GetName()}: {GetDetailsString()}";
            }
        }
        public int GetPoints()
        {
            return _points;
        }
        public int GetTypeOfGoal()
        {
            return _typeOfGoal;
        }
        protected int GetNumber(string input)
        {
            int choice;
            while (true)
            {
                if (int.TryParse(input, out choice))
                {
                    return choice;
                }
                else
                {
                    System.Console.WriteLine("Please enter a number");
                    input = Console.ReadLine();

                }
            }

        }
    }
}