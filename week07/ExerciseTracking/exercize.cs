using System.ComponentModel.DataAnnotations;
using System.Configuration.Assemblies;

namespace ExercizeTracking
{
    public abstract class Exercize
    {
        private DateTime _date;
        private int _length;
        private double _speed;
        private string _distanceType;
        private string _type;
        private double _distance;
        private int _workout;
        public Exercize(int workout, int length, string distanceType, string type)
        {
            SetDistanceType(distanceType);
            SetLength(length);
            SetExercizeType(type);
            SetDate();
            SetWorkout(workout);
        }
        private void SetWorkout(int workout)
        {
            _workout = workout;
        }
        private int GetWorkout()
        {
            return _workout;
        }
        private void SetDate()
        {
            DateTime now = DateTime.Now;
            _date = now.Date;
        }
        private double GetSpeed()
        {
            return _speed;
        }
        private string GetDate()
        {
            return _date.ToString();
        }
        private string GetExercizeType()
        {
            return _type;
        }
        private void SetExercizeType(string type)
        {
            _type = type;
        }
        private string GetDistanceType()
        {
            return _distanceType;
        }
        private void SetDistanceType(string type)
        {
            _distanceType = type;
        }
        protected int GetLength()
        {
            return _length;
        }
        private void SetLength(int length)
        {
            _length = length;
        }
        protected double GetDistance()
        {
            return _distance;
        }
        protected void SetDistance(double distance)
        {
            _distance = distance;
        }
        protected virtual void DistanceKilometers() { }
        protected virtual void DistanceMiles() { }
        protected abstract void Speed();
        protected void SetSpeed(double speed)
        {
            _speed = speed;
        }
        private string ShortDistanceType()
        {
            if (GetDistanceType() == "Kilometers") return "Km/h";
            else if (GetDistanceType() == "Kilometers") return "MPH";
            else return "";
        }
        public void DisplayExercize()
        {
            int hour = (int)Math.Floor((double)GetLength() / 60);
            int minutes = GetLength() - (int)Math.Floor((double)GetLength() / 60) * 60;
            System.Console.WriteLine($"Workout {GetWorkout()}:\nWorkout Date: {GetDate()}\nWorkout type: {GetType()} for {GetDistance()} {GetDistanceType()}.\nWorkout Time: {hour} hour(s) and {minutes} minute(s) \nWith an average pace of {GetSpeed()} {ShortDistanceType()}\n\n");
        }

    }
}