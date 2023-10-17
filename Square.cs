namespace Figures
{
    public class Square : IFigure
    {
        private float[][] points = new float[2][];

        public Square(float[] points)
        {
            for (int i = 0; i < points.Length/2; i++)
            {
                this.points[i] = new float[] { points[i * 2], points[i * 2 + 1] };
            }
        }

        private float CalcSquare()
        {
            return (float)Math.Pow(points[1][1] - points[0][1], 2);
        }

        private float CalcPerimeter()
        {
            return (points[1][1] - points[0][1]) * 4;
        }
        
        public string ShowInfo()
        {
            return $"Perimeter - {CalcPerimeter()}, Square - {CalcSquare()}";
        }
    }
};