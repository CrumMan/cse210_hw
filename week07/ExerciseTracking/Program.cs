using System;
using System.Security.Cryptography.X509Certificates;

namespace ExercizeTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Athlete> athletes = new List<Athlete>();
            Athlete John = new("John Marston", "Miles");
            Athlete Kara = new("Laura Croft", "Kilometers");
            Athlete JT = new("JT Pyle", "Miles");
            John.AddRunningWorkout(120, 6);
            JT.AddSwimmingWorkout(120, 65);
            Kara.AddSwimmingWorkout(120, 100);
            Kara.AddCycleWorkout(120, 15);
            JT.AddCycleWorkout(60, 22);
            athletes.Add(JT);
            athletes.Add(Kara);
            athletes.Add(John);
            DisplayAthlete("John Marston");
            DisplayAthlete("Kara Croft");
            DisplayAthlete("JT Pyle");
            void DisplayAthlete(string name)
            {
                foreach (Athlete athlete in athletes)
                {
                    if (athlete.GetName() == name)
                    {
                        athlete.DisplayExercizes();
                        break;
                    }
                }
            }
        }
    }
}