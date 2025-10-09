namespace shapes
{
    public abstract class Shape
    {
        private string _color;
        public abstract double GetArea();
        public string GetColor()
        {
            return _color;
        }
        public void setColor(string color)
        {
            _color = color;
        }
    }
    public class Square : Shape
    {
        private double _side;
        private double GetSide()
        {
            return _side;
        }
        private void setSide(double side)
        {
            _side = side;
        }
        public override double GetArea()
        {
            double side = GetSide();
            return side * side;
        }
        public Square()
        {
            double side = 6;
            setSide(side);
        }

    }
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;
        private double GetLength()
        {
            return _length;
        }
        private double GetWidth()
        {
            return _width;
        }
        private void SetSides(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override double GetArea()
        {
            double width = GetWidth();
            double length = GetLength();
            return width * length;
        }
        public Rectangle()
        {
            double width = 5;
            double length = 7;
            SetSides(length, width);
        }
    }
    public class Circle : Shape
    {
        private double _radius;
        private double GetRadius()
        {
            return _radius;
        }
        private void setRadius(double radius)
        {
            _radius = radius;
        }
        public override double GetArea()
        {
            double radius = GetRadius();
            return radius * radius * Math.PI;
        }
        public Circle()
        {
            double radius = 4.0;
            setRadius(radius);
        }
    }
}