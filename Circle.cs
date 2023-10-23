namespace Figures
{
    internal class Circle : Figure
    {
        private float radius;
    
        public Circle(float rad)
        {
            radius = rad;
            Console.WriteLine($"radius - {rad}");
        }

        private new float CalcSquare()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        private new float CalcPerimeter()
        {
            return (float)(2 * Math.PI * radius);
        }
        
        public new string ShowInfo()
        {
            return $"Perimeter - {CalcPerimeter()}, Square - {CalcSquare()}";
        }
    }
};