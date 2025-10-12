namespace ExercizeTracking
{
    public class Swimming : Exercize
    {
        private int _laps;
        public Swimming(int workout, int length, string distanceType, int Laps) : base(workout, length, distanceType, "Swim")
        {
            if (distanceType == "Kilometers") DistanceKilometers();
            else if (distanceType == "Miles") DistanceMiles();
        }

        protected override void Speed()
        {
            double Speed = (GetLength() / GetDistance()) * 60;
            SetSpeed(Speed);
        }
        private int GetLaps()
        {
            return _laps;
        }

        protected override void DistanceMiles()
        {
            int laps = GetLaps();
            SetDistance(laps * 50 / 1000 * 0.62);
        }
        protected override void DistanceKilometers()
        {
            int laps = GetLaps();
            SetDistance(laps * 50 / 1000);
        }

    }
}