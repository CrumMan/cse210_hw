using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace EternalQuest
{
    public class GoalManager
    {
        private string _menu = "\n  1.View your Goals \n  2.Report on your Goals\n  3.Create a Goal \n  4.Delete Goal\n  0.Save and Exit";
        private List<Goal> _goals = new List<Goal>();
        EternalGoal eternalGoal;
        ChecklistGoal checklistGoal;
        SimpleGoal simpleGoal;
        int playerPoints = 0;

        public GoalManager()
        {
            LoadGoals();
            Start();
            SaveGoals();
        }
        public void Start()
        {
            string input = "";
            while (input != "0")
            {
                input = GetMenuOption();
                if (input == "1")
                {
                    ListGoalDetails();
                    System.Console.WriteLine("Enter a key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "2")
                {
                    RecordEvent();
                    System.Console.WriteLine("Enter a key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "3")
                {
                    CreateGoal();
                    System.Console.WriteLine("Enter a key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == "4")
                {
                    DeleteGoal();
                    System.Console.WriteLine("Enter a key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            SaveGoals();
            Console.Clear();
        }
        public void DeleteGoal()
        {

            if (GetGoals().Count < 1)
            {
                System.Console.WriteLine("You have no goals to Delete!");
                return;
            }
            ListGoalDetails();
            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("What goal do you wish to complete?");
            string input = Console.ReadLine();
            int number = GetNumber(input);
            while (number > GetGoals().Count)
            {
                System.Console.WriteLine("You entered a number that was too Large! ");
                number = GetNumber(input);
            }
            int index = number - 1;
            RemoveGoal(index);

        }
        public void ListGoalDetails()
        {
            List<Goal> goals = GetGoals();
            if (goals.Count > 0)
            {
                int count = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(count + ". " + goal.GetStringRepresentation());
                    count++;
                }
            }
            else
            {
                System.Console.WriteLine("You have no goals! Create a goal to view your goals!");
            }
        }
        public void CreateGoal()
        {

            string input = CreateGoalMenu();
            if (input == "1")
            {
                System.Console.WriteLine("What is the name your goal?");
                string name = Console.ReadLine();
                System.Console.WriteLine("What is the description your goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How Many Points is your goal worth?");
                string pointsS = Console.ReadLine();
                int points = GetNumber(pointsS);
                simpleGoal = new SimpleGoal(name, description, points);
                AddGoal(simpleGoal);

            }
            else if (input == "2")
            {
                System.Console.WriteLine("What is the name your goal?");
                string name = Console.ReadLine();
                System.Console.WriteLine("What is the description your goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How Many Points is your goal worth?");
                string pointsS = Console.ReadLine();
                int points = GetNumber(pointsS);
                System.Console.WriteLine("How many times will you do this goal?");
                string bonusRepitionsS = Console.ReadLine();
                int bonusRepitions = GetNumber(bonusRepitionsS);
                System.Console.WriteLine($"How many Bonus points will doing this goal give after you have completed it {bonusRepitions} times?");
                string bonusPointsS = Console.ReadLine();
                int bonusPoints = GetNumber(bonusPointsS);
                checklistGoal = new ChecklistGoal(name, description, points, 0, bonusRepitions, bonusPoints);
                AddGoal(checklistGoal);
            }
            else if (input == "3")
            {
                System.Console.WriteLine("What is the name your goal?");
                string name = Console.ReadLine();
                System.Console.WriteLine("What is the description your goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How Many Points is your goal worth?");
                string pointsS = Console.ReadLine();
                int points = GetNumber(pointsS);
                eternalGoal = new EternalGoal(name, description, points);
                AddGoal(eternalGoal);
            }

        }
        public void RecordEvent()
        {
            ListGoalDetails();
            if (GetGoals().Count >= 1)
            {
                System.Console.WriteLine("\n\n");
                System.Console.WriteLine("What Goal did you complete?");
                string input = Console.ReadLine();
                int number = GetNumber(input);
                while (number > GetGoals().Count)
                {
                    System.Console.WriteLine("You entered a number that was too Large! ");
                    number = GetNumber(input);
                }
                int index = number - 1;
                Goal chosenGoal = GetGoals()[index];
                if (chosenGoal.GetComplete())
                {
                    System.Console.WriteLine("You have already completed this Goal!");
                }
                else
                {
                    chosenGoal.RecordEvent();
                    SetPlayerPoints(chosenGoal.GetPoints());
                }
            }
        }
        public void SaveGoals()
        {
            string filepath = "goals.txt";
            List<string> lines = new List<string>();
            lines.Add($"Points:{GetPoints()}");
            foreach (Goal goal in GetGoals())
            {
                string line = "";
                if (goal.GetTypeOfGoal() == 1 || goal.GetTypeOfGoal() == 3)
                {
                    line = $"{goal.GetTypeOfGoal()}|{goal.GetName()}|{goal.GetDetailsString()}|{goal.GetPoints()}|{goal.GetComplete()}";
                }
                else if (goal.GetTypeOfGoal() == 2)
                {
                    line = $"{goal.GetTypeOfGoal()}|{goal.GetName()}|{goal.GetDetailsString()}|{goal.GetPoints()}|{goal.GetComplete()}|{checklistGoal.GetAmountCompleted()}|{checklistGoal.GetTarget()}|{checklistGoal.GetBonus()}";
                }
                lines.Add(line);
            }
            File.WriteAllLines(filepath, lines);

        }
        public void LoadGoals()
        {
            string filepath = "goals.txt";
            if (!File.Exists(filepath))
            {
                return;
            }
            string[] lines = File.ReadAllLines(filepath);

            int totalPoints = 0;

            foreach (string line in lines)
            {

                if (line.StartsWith("Points:"))
                {
                    totalPoints = int.Parse(line.Split(':')[1]);
                    SetPlayerPoints(totalPoints);
                }
                if (!line.StartsWith("Points:"))
                {
                    string[] parts = line.Split('|');
                    int type = int.Parse(parts[0]);
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool complete = bool.Parse(parts[4]);
                    if (type == 1)
                    {
                        simpleGoal = new SimpleGoal(name, description, points);
                        if (complete) simpleGoal.IsComplete();
                        AddGoal(simpleGoal);
                    }
                    else if (type == 3)
                    {
                        eternalGoal = new EternalGoal(name, description, points);
                        AddGoal(eternalGoal);
                    }
                    else if (type == 2)
                    {
                        int amountCompleted = int.Parse(parts[5]);
                        int target = int.Parse(parts[6]);
                        int bonus = int.Parse(parts[7]);
                        checklistGoal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                        if (complete) checklistGoal.IsComplete();
                        AddGoal(checklistGoal);
                    }
                }
            }
            System.Console.WriteLine("File Loaded");
        }
        public string DisplayMenu()
        {
            return _menu;
        }
        public List<Goal> GetGoals()
        {
            return _goals;
        }
        public int GetPoints()
        {
            return playerPoints;
        }
        public void SetPlayerPoints(int _playerPoints)
        {
            playerPoints += _playerPoints;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }
        public void RemoveGoal(int index)
        {
            _goals.RemoveAt(index);
        }
        public string TypesOfGoals()
        {
            return "1. A Simple goal \n2. A Checklist Goal \n3. An eternal goal";
        }
        public string GetMenuOption()
        {
            System.Console.WriteLine($"You have {GetPoints()} Points! \n{DisplayMenu()}");
            string input = Console.ReadLine();
            int number = GetNumber(input);
            while (number > 4)
            {
                Console.Clear();
                System.Console.WriteLine($"This is not a proper input for the menu response. Please enter {DisplayMenu()}");
                input = Console.ReadLine();
            }
            return input;
        }
        public string CreateGoalMenu()
        {
            System.Console.WriteLine(TypesOfGoals());
            string input = Console.ReadLine();
            int number = GetNumber(input);
            while (number > 4)
            {
                Console.Clear();
                System.Console.WriteLine($"\n1.This is not a proper input for the menu response. Please enter \n");
                System.Console.WriteLine(TypesOfGoals());
                input = Console.ReadLine();
            }
            return input;
        }

        private int GetNumber(string input)
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