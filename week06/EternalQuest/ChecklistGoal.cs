using System.Dynamic;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;
        public ChecklistGoal(string name, string description, int points, int amountCompleted, int bonusRepitions, int bonusPoints) : base(2, name, description, points)
        {
            _amountCompleted = amountCompleted;
            _target = bonusRepitions;
            _bonus = bonusPoints;
        }

        public override string GetStringRepresentation()
        {
            if (GetComplete())
            {
                return $"[X] {GetName()}: {GetDetailsString()}";
            }
            else
            {
                return $"[] {GetName()}: {GetDetailsString()} {GetAmountCompleted()}/{GetTarget()}";
            }
        }
        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }
        public int GetTarget()
        {
            return _target;
        }
        public int GetBonus()
        {
            return _bonus;
        }
        public override void RecordEvent()
        {
            _amountCompleted += 1;
            int points = GetPoints();
            if (_amountCompleted == _target)
            {
                IsComplete();
                points += _bonus;
                SetPoints(points);
                System.Console.WriteLine($"You have completed a checklist goal and have gotten a {_bonus} point bonus! \n You have gained {points} points!");
            }
            else
            {
                System.Console.WriteLine($"You got {points} Points!\n You have done this goal {_amountCompleted}/{_target} times!");
            }


        }
    }
}