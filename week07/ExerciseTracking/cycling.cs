using System.Data.Common;

namespace ExercizeTracking
{
    public class Cycling : Exercize
    {
        public Cycling(int workout, int length, string distanceType, float pace) : base(workout, length, distanceType, "Ride")
        {
            SetDistance(pace * (GetLength() / 60));
            SetSpeed(pace);
        }

        protected override void Speed()
        {
            double Speed = (GetLength() / GetDistance());
            SetSpeed(Speed);
        }
    }
}