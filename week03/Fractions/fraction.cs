using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Fractions
{
    public class FractionC()
    {
        private int _top;
        private int _bottom;
        public double Fraction()
        {
            return GetTop() / GetBottom();
        }
        public void Fraction(int wholeNumber)
        {
            SetTop(wholeNumber);
            SetBottom(1);
        }
        public void Fraction(int topNumber, int bottomNumber)
        {
            SetTop(topNumber);
            SetBottom(bottomNumber);
        }
        public int GetTop()
        {
            return _top;
        }
        public void SetTop(int top)
        {
            _top = top;
        }
        public int GetBottom()
        {
            return _bottom;
        }
        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }
        public string getFractionString()
        {
            return $"{GetTop()}/{GetBottom()}";
        }
        public double getDecimalValue()
        {
            int top = GetTop();
            int bottom = GetBottom();
            return (double)top / bottom;
        }

    }
}