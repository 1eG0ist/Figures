namespace Figures
{
    public class Circle : IFigure
    {
        private float radius;
    
        public Circle(float rad)
        {
            radius = rad;
            Console.WriteLine($"radius - {rad}");
        }

        private float CalcSquare()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        private float CalcPerimeter()
        {
            return (float)(2 * Math.PI * radius);
        }
        
        public string ShowInfo()
        {
            return $"Perimeter - {CalcPerimeter()}, Square - {CalcSquare()}";
        }
    }
};