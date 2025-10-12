namespace ExercizeTracking
{
    public class Running : Exercize
    {
        private float _distance;
        public Running(int workout, int length, string distanceType, float distance) : base(workout, length, distanceType, "Run")
        {
            SetDistance(distance);
        }
        protected override void Speed()
        {
            double Speed = GetLength() / GetDistance() * 60;
            SetSpeed(Speed);
        }
    }
}