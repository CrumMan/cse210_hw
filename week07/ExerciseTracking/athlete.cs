using System.ComponentModel.DataAnnotations;
using System.Configuration.Assemblies;

namespace ExercizeTracking
{
    public class Athlete
    {
        public string _name;
        public string _distanceType;
        public int _workout = 1;
        List<Exercize> exercizes = new List<Exercize>();
        public string GetName() { return _name; }
        public void SetName(string name) { _name = name; }
        public string GetDistanceType() { return _distanceType; }
        private void SetDistanceType(string distanceType) { _distanceType = distanceType; }
        private int GetWorkout() { return _workout; }
        private void SetWorkout() { _workout++; }
        public Athlete() { }

        public Athlete(string name, string distanceType)
        {
            SetName(name);
            SetDistanceType(distanceType);
        }
        public void AddCycleWorkout(int length, float pace)
        {
            exercizes.Add(new Cycling(GetWorkout(), length, GetDistanceType(), pace));
            SetWorkout();
        }
        public void AddRunningWorkout(int length, float distance)
        {
            exercizes.Add(new Running(GetWorkout(), length, GetDistanceType(), distance));
            SetWorkout();
        }
        public void AddSwimmingWorkout(int length, int Laps)
        {
            exercizes.Add(new Swimming(GetWorkout(), length, GetDistanceType(), Laps));
            SetWorkout();
        }
        public void DisplayExercizes()
        {
            System.Console.WriteLine($"Athlete:{GetName()}");
            foreach (Exercize exercize in exercizes)
            {
                exercize.DisplayExercize();
            }
        }
    }
}